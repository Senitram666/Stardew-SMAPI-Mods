using Microsoft.Xna.Framework;
using StardewValley;
using StardewValley.Menus;

namespace ChibiKyu.StardewMods.FishingAssistant2.Frameworks
{
    internal class SBobberBar(BobberBar bobberBar)
    {
        internal BobberBar Instance { get; set; } = bobberBar;
        
        internal void OverrideFishDifficult(float difficultyMultiplier, float difficultyAdditive)
        {
            Instance.difficulty *= difficultyMultiplier;
            Instance.difficulty += difficultyAdditive;
            if (Instance.difficulty < 0) Instance.difficulty = 0;
        }

        internal void OverrideTreasureChance(string treasureChance)
        {
            if (Game1.isFestival()) return;
            
            if (treasureChance == "Always")
                Instance.treasure = true;
            else if (treasureChance == "Never") 
                Instance.treasure = false;
        }

        internal void InstantCatchTreasure(bool catchTreasure)
        {
            if (Instance.treasure) Instance.treasureCaught = catchTreasure;
        }
        
        internal void InstantCatchFish()
        {
            Instance.distanceFromCatching = 1.0f;
        }
        
        internal void AlwaysPerfect(bool alwaysPerfect)
        {
            if (alwaysPerfect)
            {
                Instance.perfect = true;
                Instance.fishShake = Vector2.Zero;
            }
        }
    }
}