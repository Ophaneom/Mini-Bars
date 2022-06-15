using System;
using StardewModdingAPI;
using StardewValley;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MiniBars.Framework;

namespace MiniBars.Framework.Rendering
{
    public class Textures
    {
        public static Texture2D hp_sprite;
        public static Texture2D default_theme;
        public static Texture2D greenslime_theme,
            blueslime_theme,
            bat_theme,
            frostbat_theme,
            lavabat_theme,
            bug_theme,
            cavefly_theme,
            duggy_theme,
            grub_theme,
            rockcrab_theme,
            lavacrab_theme,
            stonegolem_theme,
            dust_theme,
            ghost_theme,
            skeleton_theme,
            metalhead_theme,
            shadowbrute_theme,
            shadowshaman_theme,
            squidkid_theme;
        public static Texture2D armoredbug_theme,
            carbonghost_theme,
            iridiumbat_theme,
            iridiumcrab_theme,
            mummy_theme,
            pepperrex_theme,
            serpent_theme;
        public static Texture2D hauntedskull_theme;
        public static Texture2D mutantfly_theme,
            mutantgrub_theme;
        public static Texture2D wildernessgolem_theme;
        public static Texture2D dwarvishsentry_theme,
            falsemagmacap_theme,
            hothead_theme,
            lavalurk_theme,
            magmaduggy_theme,
            magmasparker_theme,
            magmasprite_theme,
            tigerslime_theme;
        public static Texture2D hardmode_bug,
            hardmode_crab,
            hardmode_duggy,
            hardmode_dust,
            hardmode_frostbat,
            hardmode_squid,
            hardmode_putridghost,
            hardmode_skeleton,
            hardmode_spider,
            hardmode_lavacrab,
            hardmode_metalhead,
            hardmode_squidkid,
            hardmode_shadowshaman,
            hardmode_stickbug;

        private static Lazy<Texture2D> _pixelLazy = new(() =>
        {
            Texture2D _pixel = new Texture2D(Game1.graphics.GraphicsDevice, 1, 1);
            _pixel.SetData(new[] { Color.White });
            return _pixel;
        });

        public static Texture2D Pixel => _pixelLazy.Value;

        public static void LoadTextures()
        {
            IModHelper helper = ModEntry.instance.Helper;

            Database.GetTheme();

            hp_sprite = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Others/hp_sprite.png");
            default_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Others/default_theme.png");

            //NORMAL MINES
            greenslime_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Normal_Mines/greenslime_theme.png");
            blueslime_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Normal_Mines/blueslime_theme.png");
            bat_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Normal_Mines/bat_theme.png");
            frostbat_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Normal_Mines/frostbat_theme.png");
            lavabat_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Normal_Mines/lavabat_theme.png");
            bug_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Normal_Mines/bug_theme.png");
            cavefly_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Normal_Mines/cavefly_theme.png");
            duggy_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Normal_Mines/duggy_theme.png");
            grub_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Normal_Mines/grub_theme.png");
            rockcrab_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Normal_Mines/rockcrab_theme.png");
            lavacrab_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Normal_Mines/lavacrab_theme.png");
            stonegolem_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Normal_Mines/stonegolem_theme.png");
            dust_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Normal_Mines/dust_theme.png");
            ghost_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Normal_Mines/ghost_theme.png");
            skeleton_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Normal_Mines/skeleton_theme.png");
            metalhead_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Normal_Mines/metalhead_theme.png");
            shadowbrute_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Normal_Mines/shadowbrute_theme.png");
            shadowshaman_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Normal_Mines/shadowshaman_theme.png");
            squidkid_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Normal_Mines/squidkid_theme.png");

            //SKULL CAVERN
            armoredbug_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Skull_Cavern/armoredbug_theme.png");
            carbonghost_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Skull_Cavern/carbonghost_theme.png");
            iridiumbat_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Skull_Cavern/iridiumbat_theme.png");
            iridiumcrab_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Skull_Cavern/iridiumcrab_theme.png");
            mummy_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Skull_Cavern/mummy_theme.png");
            pepperrex_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Skull_Cavern/pepperrex_theme.png");
            serpent_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Skull_Cavern/serpent_theme.png");

            //QUARRY MINE
            hauntedskull_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Quarry_Mine/hauntedskull_theme.png");

            //MUTANT BUG LAIR
            mutantfly_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Mutant_Bug_Lair/mutantfly_theme.png");
            mutantgrub_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Mutant_Bug_Lair/mutantgrub_theme.png");

            //WILDERNESS
            wildernessgolem_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Wilderness/wildernessgolem_theme.png");

            //VOLCANO DUNGEON
            dwarvishsentry_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Volcano_Dungeon/dwarvishsentry_theme.png");
            falsemagmacap_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Volcano_Dungeon/falsemagmacap_theme.png");
            hothead_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Volcano_Dungeon/hothead_theme.png");
            lavalurk_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Volcano_Dungeon/lavalurk_theme.png");
            magmaduggy_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Volcano_Dungeon/magmaduggy_theme.png");
            magmasparker_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Volcano_Dungeon/magmasparker_theme.png");
            magmasprite_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Volcano_Dungeon/magmasprite_theme.png");
            tigerslime_theme = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/Volcano_Dungeon/tigerslime_theme.png");

            //HARDMODE
            hardmode_bug = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/HardMode/hardmode_bug.png");
            hardmode_crab = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/HardMode/hardmode_crab.png");
            hardmode_duggy = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/HardMode/hardmode_duggy.png");
            hardmode_dust = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/HardMode/hardmode_dust.png");
            hardmode_frostbat = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/HardMode/hardmode_frostbat.png");
            hardmode_squid = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/HardMode/hardmode_squid.png");
            hardmode_putridghost = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/HardMode/hardmode_putridghost.png");
            hardmode_skeleton = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/HardMode/hardmode_skeleton.png");
            hardmode_spider = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/HardMode/hardmode_spider.png");
            hardmode_lavacrab = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/HardMode/hardmode_lavacrab.png");
            hardmode_metalhead = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/HardMode/hardmode_metalhead.png");
            hardmode_squidkid = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/HardMode/hardmode_squidkid.png");
            hardmode_shadowshaman = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/HardMode/hardmode_shadowshaman.png");
            hardmode_stickbug = helper.ModContent.Load<Texture2D>($"assets/{Database.bars_theme}/HardMode/hardmode_stickbug.png");
        }
    }
}
