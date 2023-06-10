using StardewValley;

namespace MiniBars.Framework
{
    public class Compatibility
    {
        public static bool IsBlackListed(string _monster_name)
        {
            if (ModEntry.instance.Helper.ModRegistry.IsLoaded("aedenthorn.Swim"))
            {
                if (Game1.player.currentLocation.Name == "Custom_UnderwaterBeach" ||
                    Game1.player.currentLocation.Name == "Custom_UnderwaterMountain" ||
                    Game1.player.currentLocation.Name == "Custom_UnderwaterTown" ||
                    Game1.player.currentLocation.Name == "Custom_ScubaAbigailCave")
                {
                    return true;
                }
            }
            
            if (Game1.player.currentLocation.Name == "Slime Hutch")
            {
                return true;
            }
            return false;
        }
    }
}
