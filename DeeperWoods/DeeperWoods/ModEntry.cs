using System;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;


using xTile;
using xTile.Dimensions;
using xTile.ObjectModel;
using xTile.Tiles;

namespace DeeperWoods
{
    /// <summary>The mod entry point.</summary>
    public class ModEntry : Mod, IAssetLoader
    {
        /*********
        ** Public methods
        *********/
        /// <summary>The mod entry point, called after the mod is first loaded.</summary>
        /// <param name="helper">Provides simplified APIs for writing mods.</param>
        public override void Entry(IModHelper helper)
        {
            // Adds button press to console
            //helper.Events.Input.ButtonPressed += this.OnButtonPressed;

            // Adds a DeepWoods map
            // the game clears locations when loading the save, so do it after the save loads
            helper.Events.GameLoop.SaveLoaded += this.OnSaveLoaded;
            
            //Implemented using ContentPatcher instead
            //GameEvents.UpdateTick += this.GameEvents_UpdateTick;
        }

        /// <summary>Get whether this instance can load the initial version of the given asset.</summary>
        /// <param name="asset">Basic metadata about the asset being loaded.</param>
        public bool CanLoad<T>(IAssetInfo asset)
        {
            return asset.AssetNameEquals("Maps/Woods");
        }

        /// <summary>Load a matched asset.</summary>
        /// <param name="asset">Basic metadata about the asset being loaded.</param>
        public T Load<T>(IAssetInfo asset)
        {
            return this.Helper.Content.Load<T>("assets/Woods.tbin");
        }

        /*********
        ** Private methods
        *********/
        //Removed, no longer a necessary test feature
        /*/// <summary>Raised after the player presses a button on the keyboard, controller, or mouse.</summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event data.</param>
        private void OnButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            // ignore if player hasn't loaded a save yet
            if (!Context.IsWorldReady)
                return;

            // print button presses to the console window
            this.Monitor.Log($"{Game1.player.Name} pressed {e.Button}.");
        }*/

        private void OnSaveLoaded(object sender, SaveLoadedEventArgs args)
        {
            // load the DeepWoods map file from your mod folder
            this.Helper.Content.Load<Map>("assets/DeepWoods.tbin", ContentSource.ModFolder);

            // get the internal asset key for the DeepWoods map file
            string mapAssetKey = this.Helper.Content.GetActualAssetKey("assets/DeepWoods.tbin", ContentSource.ModFolder);

            // add the new location
            GameLocation location = new GameLocation(mapAssetKey, "DeepWoods") { IsOutdoors = true, IsFarm = false };
            Game1.locations.Add(location);
        }

        private void GameEvents_UpdateTick(object sender, EventArgs e)
        {
           //Implemented using ContentPatcher
           /* if (Game1.currentLocation != null)
            {
                if (Game1.getCharacterFromName("Ent") == null)
                {
                    foreach (var i in Game1.locations)
                        if (i.Name == "Town")
                        {
                            //public NPC(AnimatedSprite sprite, Vector2 position, int facingDir, string name, LocalizedContentManager content = null);
                            var ent = new NPC(new AnimatedSprite("Characters\\Ent"), new Vector2(39, 58), 0, "Ent");
                            //var ent = new EntNPC(new AnimatedSprite(Game1.content.Load<Texture2D>("Characters\\Ent"), 0, 24, Game1.tileSize * 2 / 4), new Vector2((float)(2 * Game1.tileSize), (float)(6 * Game1.tileSize)), "DeepWoods", 3, "Ent", false, (Dictionary<int, int[]>)null, Game1.content.Load<Texture2D>("Portraits\\Ent"));
                            i.addCharacter(ent);
                            ent.reloadSprite();
                        }
                }
            }*/
            var ent = new NPC(new AnimatedSprite("Characters\\Ent"), new Vector2(5, 22), 0, "Ent");
            if (ent == null) Console.WriteLine("frick!");
            if (Game1.getLocationFromName("Town") == null) Console.WriteLine("Frick again!");
            Game1.getLocationFromName("Town").addCharacter(ent);
            ent.reloadSprite();
        }
    }
}