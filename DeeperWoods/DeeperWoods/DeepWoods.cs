using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;
using StardewValley.Monsters;
using xTile;
using xTile.Dimensions;

namespace StardewValley.Locations
{
    class DeepWoods : GameLocation
    {
        public override bool answerDialogue(Response answer)
        {
            return base.answerDialogue(answer);
        }

        public override bool answerDialogueAction(string questionAndAnswer, string[] questionParams)
        {
            return base.answerDialogueAction(questionAndAnswer, questionParams);
        }

        public override bool canFishHere()
        {
            return base.canFishHere();
        }

        public override bool canSlimeHatchHere()
        {
            return base.canSlimeHatchHere();
        }

        public override bool canSlimeMateHere()
        {
            return base.canSlimeMateHere();
        }

        public override bool checkAction(Location tileLocation, xTile.Dimensions.Rectangle viewport, Farmer who)
        {
            return base.checkAction(tileLocation, viewport, who);
        }

        public override string checkForBuriedItem(int xLocation, int yLocation, bool explosion, bool detectOnly)
        {
            return base.checkForBuriedItem(xLocation, yLocation, explosion, detectOnly);
        }

        public override void checkForMusic(GameTime time)
        {
            base.checkForMusic(time);
        }

        public override void cleanupBeforePlayerExit()
        {
            base.cleanupBeforePlayerExit();
        }

        public override void cleanupBeforeSave()
        {
            base.cleanupBeforeSave();
        }

        public override void DayUpdate(int dayOfMonth)
        {
            base.DayUpdate(dayOfMonth);
        }

        public override void draw(SpriteBatch b)
        {
            base.draw(b);
        }

        public override void drawAboveAlwaysFrontLayer(SpriteBatch b)
        {
            base.drawAboveAlwaysFrontLayer(b);
        }

        public override void drawAboveFrontLayer(SpriteBatch b)
        {
            base.drawAboveFrontLayer(b);
        }

        public override void drawLightGlows(SpriteBatch b)
        {
            base.drawLightGlows(b);
        }

        public override void drawWater(SpriteBatch b)
        {
            base.drawWater(b);
        }

        public override bool dropObject(Object obj, Vector2 dropLocation, xTile.Dimensions.Rectangle viewport, bool initialPlacement, Farmer who = null)
        {
            return base.dropObject(obj, dropLocation, viewport, initialPlacement, who);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int getExtraMillisecondsPerInGameMinuteForThisLocation()
        {
            return base.getExtraMillisecondsPerInGameMinuteForThisLocation();
        }

        public override Object getFish(float millisecondsAfterNibble, int bait, int waterDepth, Farmer who, double baitPotency)
        {
            return base.getFish(millisecondsAfterNibble, bait, waterDepth, who, baitPotency);
        }

        public override Object getFish(float millisecondsAfterNibble, int bait, int waterDepth, Farmer who, double baitPotency, string locationName = null)
        {
            return base.getFish(millisecondsAfterNibble, bait, waterDepth, who, baitPotency, locationName);
        }

        public override int getFishingLocation(Vector2 tile)
        {
            return base.getFishingLocation(tile);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override Object getObjectAt(int x, int y)
        {
            return base.getObjectAt(x, y);
        }

        public override void hostSetup()
        {
            base.hostSetup();
        }

        public override bool isActionableTile(int xTile, int yTile, Farmer who)
        {
            return base.isActionableTile(xTile, yTile, who);
        }

        public override bool isCollidingPosition(Microsoft.Xna.Framework.Rectangle position, xTile.Dimensions.Rectangle viewport, bool isFarmer, int damagesFarmer, bool glider, Character character)
        {
            return base.isCollidingPosition(position, viewport, isFarmer, damagesFarmer, glider, character);
        }

        public override bool isCollidingPosition(Microsoft.Xna.Framework.Rectangle position, xTile.Dimensions.Rectangle viewport, bool isFarmer, int damagesFarmer, bool glider, Character character, bool pathfinding, bool projectile = false, bool ignoreCharacterRequirement = false)
        {
            return base.isCollidingPosition(position, viewport, isFarmer, damagesFarmer, glider, character, pathfinding, projectile, ignoreCharacterRequirement);
        }

        public override bool isObjectAt(int x, int y)
        {
            return base.isObjectAt(x, y);
        }

        public override bool isObjectAtTile(int tileX, int tileY)
        {
            return base.isObjectAtTile(tileX, tileY);
        }

        public override bool isTileLocationTotallyClearAndPlaceable(Vector2 v)
        {
            return base.isTileLocationTotallyClearAndPlaceable(v);
        }

        public override bool isTileLocationTotallyClearAndPlaceableIgnoreFloors(Vector2 v)
        {
            return base.isTileLocationTotallyClearAndPlaceableIgnoreFloors(v);
        }

        public override bool isTileOccupied(Vector2 tileLocation, string characterToIgnore = "")
        {
            return base.isTileOccupied(tileLocation, characterToIgnore);
        }

        public override bool isTileOccupiedForPlacement(Vector2 tileLocation, Object toPlace = null)
        {
            return base.isTileOccupiedForPlacement(tileLocation, toPlace);
        }

        public override bool isTileOccupiedIgnoreFloors(Vector2 tileLocation, string characterToIgnore = "")
        {
            return base.isTileOccupiedIgnoreFloors(tileLocation, characterToIgnore);
        }

        public override bool isTilePlaceable(Vector2 v, Item item = null)
        {
            return base.isTilePlaceable(v, item);
        }

        public override bool leftClick(int x, int y, Farmer who)
        {
            return base.leftClick(x, y, who);
        }

        public override void monsterDrop(Monster monster, int x, int y)
        {
            base.monsterDrop(monster, x, y);
        }

        public override bool performAction(string action, Farmer who, Location tileLocation)
        {
            return base.performAction(action, who, tileLocation);
        }

        public override void performTenMinuteUpdate(int timeOfDay)
        {
            base.performTenMinuteUpdate(timeOfDay);
        }

        public override bool performToolAction(Tool t, int tileX, int tileY)
        {
            return base.performToolAction(t, tileX, tileY);
        }

        public override void performTouchAction(string fullActionString, Vector2 playerStandingPosition)
        {
            base.performTouchAction(fullActionString, playerStandingPosition);
        }

        public override void removeEverythingExceptCharactersFromThisTile(int x, int y)
        {
            base.removeEverythingExceptCharactersFromThisTile(x, y);
        }

        public override void removeEverythingFromThisTile(int x, int y)
        {
            base.removeEverythingFromThisTile(x, y);
        }

        public override void seasonUpdate(string season, bool onLoad = false)
        {
            base.seasonUpdate(season, onLoad);
        }

        public override void shiftObjects(int dx, int dy)
        {
            base.shiftObjects(dx, dy);
        }

        public override bool shouldHideCharacters()
        {
            return base.shouldHideCharacters();
        }

        public override bool shouldShadowBeDrawnAboveBuildingsLayer(Vector2 p)
        {
            return base.shouldShadowBeDrawnAboveBuildingsLayer(p);
        }

        public override void spawnObjects()
        {
            base.spawnObjects();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void updateEvenIfFarmerIsntHere(GameTime time, bool ignoreWasUpdatedFlush = false)
        {
            base.updateEvenIfFarmerIsntHere(time, ignoreWasUpdatedFlush);
        }

        public override void updateMap()
        {
            base.updateMap();
        }

        public override void UpdateWhenCurrentLocation(GameTime time)
        {
            base.UpdateWhenCurrentLocation(time);
        }

        protected override void drawCharacters(SpriteBatch b)
        {
            base.drawCharacters(b);
        }

        protected override void drawFarmers(SpriteBatch b)
        {
            base.drawFarmers(b);
        }

        protected override LocalizedContentManager getMapLoader()
        {
            return base.getMapLoader();
        }

        protected override void initNetFields()
        {
            base.initNetFields();
        }

        protected override void resetLocalState()
        {
            base.resetLocalState();
        }

        protected override void resetSharedState()
        {
            base.resetSharedState();
        }

        protected override void updateCharacters(GameTime time)
        {
            base.updateCharacters(time);
        }

        protected override void updateWarps()
        {
            base.updateWarps();
        }
    }
}
