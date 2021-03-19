using StardewModdingAPI;
using StardewValley;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MiniBars.Framework.Rendering
{
    public class Textures
    {
        public static Texture2D bar_background;

        public static Texture2D default_theme,
            greenslime_theme,
            blueslime_theme,
            redslime_theme,
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

        public static Texture2D GetPixel()
        {
            Texture2D _pixel = new Texture2D(Game1.graphics.GraphicsDevice, 1, 1);
            _pixel.SetData(new[] { Color.White });
            return _pixel;
        }

        public static void LoadTextures()
        {
            IModHelper helper = ModEntry.instance.Helper;

            bar_background = helper.Content.Load<Texture2D>("Assets/Themes/Others/bar_background.png", ContentSource.ModFolder);

            default_theme = helper.Content.Load<Texture2D>("Assets/Themes/Others/default_theme.png", ContentSource.ModFolder);

            //NORMAL MINES
            greenslime_theme = helper.Content.Load<Texture2D>("Assets/Themes/Normal_Mines/greenslime_theme.png", ContentSource.ModFolder);
            blueslime_theme = helper.Content.Load<Texture2D>("Assets/Themes/Normal_Mines/blueslime_theme.png", ContentSource.ModFolder);
            redslime_theme = helper.Content.Load<Texture2D>("Assets/Themes/Normal_Mines/redslime_theme.png", ContentSource.ModFolder);
            bat_theme = helper.Content.Load<Texture2D>("Assets/Themes/Normal_Mines/bat_theme.png", ContentSource.ModFolder);
            frostbat_theme = helper.Content.Load<Texture2D>("Assets/Themes/Normal_Mines/frostbat_theme.png", ContentSource.ModFolder);
            lavabat_theme = helper.Content.Load<Texture2D>("Assets/Themes/Normal_Mines/lavabat_theme.png", ContentSource.ModFolder);
            bug_theme = helper.Content.Load<Texture2D>("Assets/Themes/Normal_Mines/bug_theme.png", ContentSource.ModFolder);
            cavefly_theme = helper.Content.Load<Texture2D>("Assets/Themes/Normal_Mines/cavefly_theme.png", ContentSource.ModFolder);
            duggy_theme = helper.Content.Load<Texture2D>("Assets/Themes/Normal_Mines/duggy_theme.png", ContentSource.ModFolder);
            grub_theme = helper.Content.Load<Texture2D>("Assets/Themes/Normal_Mines/grub_theme.png", ContentSource.ModFolder);
            rockcrab_theme = helper.Content.Load<Texture2D>("Assets/Themes/Normal_Mines/rockcrab_theme.png", ContentSource.ModFolder);
            lavacrab_theme = helper.Content.Load<Texture2D>("Assets/Themes/Normal_Mines/lavacrab_theme.png", ContentSource.ModFolder);
            stonegolem_theme = helper.Content.Load<Texture2D>("Assets/Themes/Normal_Mines/stonegolem_theme.png", ContentSource.ModFolder);
            dust_theme = helper.Content.Load<Texture2D>("Assets/Themes/Normal_Mines/dust_theme.png", ContentSource.ModFolder);
            ghost_theme = helper.Content.Load<Texture2D>("Assets/Themes/Normal_Mines/ghost_theme.png", ContentSource.ModFolder);
            skeleton_theme = helper.Content.Load<Texture2D>("Assets/Themes/Normal_Mines/skeleton_theme.png", ContentSource.ModFolder);
            metalhead_theme = helper.Content.Load<Texture2D>("Assets/Themes/Normal_Mines/metalhead_theme.png", ContentSource.ModFolder);
            shadowbrute_theme = helper.Content.Load<Texture2D>("Assets/Themes/Normal_Mines/shadowbrute_theme.png", ContentSource.ModFolder);
            shadowshaman_theme = helper.Content.Load<Texture2D>("Assets/Themes/Normal_Mines/shadowshaman_theme.png", ContentSource.ModFolder);
            squidkid_theme = helper.Content.Load<Texture2D>("Assets/Themes/Normal_Mines/squidkid_theme.png", ContentSource.ModFolder);
        }
    }
}
