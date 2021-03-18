using System;
using System.Collections.Generic;
using System.Linq;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
using StardewValley.Monsters;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MiniBars.Framework.Rendering
{
    public class Renderer
    {
        private static int _verification_range = ModEntry.config.Distance * Game1.pixelZoom;
        public static void OnRendered(object sender, RenderedWorldEventArgs e)
        {
            if (!Context.IsWorldReady) return;
            if (Game1.activeClickableMenu != null || Game1.currentMinigame != null) return;

            foreach (Monster monster in Game1.currentLocation.characters.OfType<Monster>())
            {
                if (monster.IsInvisible) continue;
                if ((monster.Position.X > Game1.player.Position.X + _verification_range ||
                    monster.Position.X < Game1.player.Position.X - _verification_range ||
                    monster.Position.Y > Game1.player.Position.Y + _verification_range ||
                    monster.Position.Y < Game1.player.Position.Y - _verification_range) && 
                    ModEntry.config.Range_Verification) continue;


                Texture2D _current_sprite;
                Color _bar_color = new Color(172, 50, 50);
                int _height = 3;
                float _current_health = monster.Health;
                float _current_max_health = Math.Max(monster.Health, monster.MaxHealth);


                if (monster is GreenSlime)
                {
                    if (monster.Name == "Frost Jelly")
                    {
                        _current_sprite = Textures.blueslime_theme;
                        _bar_color = new Color(69, 142, 212);
                    }
                    else if (monster.Name == "Sludge")
                    {
                        _current_sprite = Textures.redslime_theme;
                        _bar_color = new Color(212, 50, 55);
                    }
                    else
                    {
                        _current_sprite = Textures.greenslime_theme;
                        _bar_color = new Color(97, 212, 69);
                    }
                }
                else if (monster is Bat)
                {
                    if (monster.Name == "Frost Bat")
                    {
                        _current_sprite = Textures.frostbat_theme;
                        _bar_color = new Color(77, 122, 145);
                    }
                    else if (monster.Name == "Lava Bat")
                    {
                        _current_sprite = Textures.lavabat_theme;
                        _bar_color = new Color(190, 23, 23);
                    }
                    else
                    {
                        _current_sprite = Textures.bat_theme;
                    }
                }
                else if (monster is Bug)
                {
                    _current_sprite = Textures.bug_theme;
                    _bar_color = new Color(130, 199, 171);
                    _height = 15;
                }
                else if (monster is Fly)
                {
                    _current_sprite = Textures.cavefly_theme;
                    _bar_color = new Color(207, 43, 156);
                }
                else if (monster is Duggy)
                {
                    _current_sprite = Textures.duggy_theme;
                }
                else if (monster is Grub)
                {
                    _current_sprite = Textures.grub_theme;
                    _bar_color = new Color(255, 215, 135);
                }
                else if (monster is RockCrab)
                {
                    if (monster.Sprite.CurrentFrame % 4 == 0) continue;
                    if (monster.Name == "Lava Crab")
                    {
                        _current_sprite = Textures.lavacrab_theme;
                        _bar_color = new Color(172, 50, 101);
                    }
                    else
                    {
                        _current_sprite = Textures.rockcrab_theme;
                    }
                }
                else if (monster is RockGolem)
                {
                    _current_sprite = Textures.stonegolem_theme;
                    _bar_color = new Color(121, 121, 121);
                }
                //--
                else if (monster is DustSpirit)
                {
                    _current_sprite = Textures.dust_theme;
                    _bar_color = new Color(86, 88, 104);
                }
                else if (monster is Ghost)
                {
                    _current_sprite = Textures.ghost_theme;
                    _bar_color = new Color(197, 238, 155);
                }
                else if (monster is Skeleton)
                {
                    _current_sprite = Textures.skeleton_theme;
                    _bar_color = new Color(255, 255, 255);
                }
                else if (monster is MetalHead)
                {
                    _current_sprite = Textures.metalhead_theme;
                    _bar_color = new Color(220, 123, 5);
                }
                else if (monster is ShadowBrute)
                {
                    _current_sprite = Textures.shadowbrute_theme;
                    _bar_color = new Color(52, 52, 52);
                }
                else if (monster is ShadowShaman)
                {
                    _current_sprite = Textures.shadowshaman_theme;
                    _bar_color = new Color(98, 164, 59);
                }
                else if (monster is SquidKid)
                {
                    _current_sprite = Textures.squidkid_theme;
                    _bar_color = new Color(255, 145, 130);
                }
                else
                {
                    _current_sprite = Textures.default_theme;
                }

                if (ModEntry.config.Simple_Bars)
                {
                    _current_sprite = Textures.default_theme;
                    _bar_color = new Color(172, 50, 50);
                }


                Vector2 _monsterPos = monster.getLocalPosition(Game1.viewport);

                Game1.spriteBatch.Draw(
                    Textures.bar_background,
                    new Rectangle(
                        (int)_monsterPos.X - (Textures.bar_background.Width * Game1.pixelZoom) / 2 + (monster.Sprite.SpriteWidth * Game1.pixelZoom) / 2,
                        (int)_monsterPos.Y - monster.Sprite.SpriteHeight * Game1.pixelZoom - _height * Game1.pixelZoom,
                        Textures.bar_background.Width * Game1.pixelZoom,
                        Textures.bar_background.Height * Game1.pixelZoom),
                    Color.White);

                Game1.spriteBatch.Draw(
                    Textures.GetPixel(),
                    new Rectangle(
                        (int)_monsterPos.X - (Textures.GetPixel().Width * Game1.pixelZoom) / 2 + (monster.Sprite.SpriteWidth * Game1.pixelZoom) / 2 - 4 * Game1.pixelZoom,
                        (int)_monsterPos.Y - monster.Sprite.SpriteHeight * Game1.pixelZoom - _height * Game1.pixelZoom + 8 * Game1.pixelZoom,
                        (Textures.GetPixel().Width * Game1.pixelZoom) * (int)((_current_health / _current_max_health) * 20),
                        (Textures.GetPixel().Height * Game1.pixelZoom) * 4),
                    _bar_color);

                Game1.spriteBatch.Draw(
                    _current_sprite,
                    new Rectangle(
                        (int)_monsterPos.X - (_current_sprite.Width * Game1.pixelZoom) / 2 + (monster.Sprite.SpriteWidth * Game1.pixelZoom) / 2,
                        (int)_monsterPos.Y - monster.Sprite.SpriteHeight * Game1.pixelZoom - _height * Game1.pixelZoom,
                        _current_sprite.Width * Game1.pixelZoom,
                        _current_sprite.Height * Game1.pixelZoom),
                    Color.White);
            }
        }
    }
}
