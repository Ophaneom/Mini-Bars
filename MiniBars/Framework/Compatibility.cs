using System;
using System.Collections.Generic;
using System.Linq;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
using StardewValley.Monsters;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MiniBars.Framework
{
    public class Compatibility
    {
        public static bool BlackListedMonster(string _monster_name)
        {
            if (Game1.player.currentLocation.Name == "UnderwaterBeach")
            {
                return _monster_name is "Serpent" or "Rock Crab";
            }
            else if (Game1.player.currentLocation.Name == "UnderwaterMountain")
            {
                return _monster_name is "Pepper Rex";
            }
            return false;
        }
    }
}
