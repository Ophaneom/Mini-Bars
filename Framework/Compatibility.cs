using StardewValley;

namespace MiniBars.Framework
{
    public class Compatibility
    {
        public static bool IsBlackListed(string _monster_name)
        {
            if (Game1.player.currentLocation.Name == "UnderwaterBeach")
            {
                if (_monster_name == "Serpent") return true;
                else if (_monster_name == "Rock Crab") return true;
                else return false;
            }
            else if (Game1.player.currentLocation.Name == "UnderwaterMountain")
            {
                if (_monster_name == "Pepper Rex") return true;
                else return false;
            }
            else if (Game1.player.currentLocation.Name == "Slime Hutch")
            {
                return true;
            }
            return false;
        }
    }
}
