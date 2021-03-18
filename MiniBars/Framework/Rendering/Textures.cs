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

            bar_background = helper.Content.Load<Texture2D>("Assets/Themes/bar_background.png", ContentSource.ModFolder);

            default_theme = helper.Content.Load<Texture2D>("Assets/Themes/default_theme.png", ContentSource.ModFolder);

            greenslime_theme = helper.Content.Load<Texture2D>("Assets/Themes/greenslime_theme.png", ContentSource.ModFolder);
            blueslime_theme = helper.Content.Load<Texture2D>("Assets/Themes/blueslime_theme.png", ContentSource.ModFolder);
            redslime_theme = helper.Content.Load<Texture2D>("Assets/Themes/redslime_theme.png", ContentSource.ModFolder);
            bat_theme = helper.Content.Load<Texture2D>("Assets/Themes/bat_theme.png", ContentSource.ModFolder);
            frostbat_theme = helper.Content.Load<Texture2D>("Assets/Themes/frostbat_theme.png", ContentSource.ModFolder);
            lavabat_theme = helper.Content.Load<Texture2D>("Assets/Themes/lavabat_theme.png", ContentSource.ModFolder);
            bug_theme = helper.Content.Load<Texture2D>("Assets/Themes/bug_theme.png", ContentSource.ModFolder);
            cavefly_theme = helper.Content.Load<Texture2D>("Assets/Themes/cavefly_theme.png", ContentSource.ModFolder);
            duggy_theme = helper.Content.Load<Texture2D>("Assets/Themes/duggy_theme.png", ContentSource.ModFolder);
            grub_theme = helper.Content.Load<Texture2D>("Assets/Themes/grub_theme.png", ContentSource.ModFolder);
            rockcrab_theme = helper.Content.Load<Texture2D>("Assets/Themes/rockcrab_theme.png", ContentSource.ModFolder);
            lavacrab_theme = helper.Content.Load<Texture2D>("Assets/Themes/lavacrab_theme.png", ContentSource.ModFolder);
            stonegolem_theme = helper.Content.Load<Texture2D>("Assets/Themes/stonegolem_theme.png", ContentSource.ModFolder);
            dust_theme = helper.Content.Load<Texture2D>("Assets/Themes/dust_theme.png", ContentSource.ModFolder);
            ghost_theme = helper.Content.Load<Texture2D>("Assets/Themes/ghost_theme.png", ContentSource.ModFolder);
            skeleton_theme = helper.Content.Load<Texture2D>("Assets/Themes/skeleton_theme.png", ContentSource.ModFolder);
            metalhead_theme = helper.Content.Load<Texture2D>("Assets/Themes/metalhead_theme.png", ContentSource.ModFolder);
            shadowbrute_theme = helper.Content.Load<Texture2D>("Assets/Themes/shadowbrute_theme.png", ContentSource.ModFolder);
            shadowshaman_theme = helper.Content.Load<Texture2D>("Assets/Themes/shadowshaman_theme.png", ContentSource.ModFolder);
            squidkid_theme = helper.Content.Load<Texture2D>("Assets/Themes/squidkid_theme.png", ContentSource.ModFolder);
        }
    }
}
