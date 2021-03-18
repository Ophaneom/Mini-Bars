using System;
using System.Collections.Generic;
using System.Linq;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
using StardewValley.Monsters;
using MiniBars.Framework.Rendering;

namespace MiniBars
{
    public class ModEntry : Mod
    {
        public static ModEntry instance;
        public static Config config;

        public override void Entry(IModHelper helper)
        {
            instance = this;
            config = helper.ReadConfig<Config>();

            Textures.LoadTextures();

            helper.Events.Display.RenderedWorld += Renderer.OnRendered;
        }
    }
}
