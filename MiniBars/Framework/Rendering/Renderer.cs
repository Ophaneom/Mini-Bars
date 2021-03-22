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
                Color _border_color = Color.White;
                int _height = 3;
                float _current_health = monster.Health;
                float _current_max_health = Math.Max(monster.Health, monster.MaxHealth);

                ModEntry.instance.Monitor.Log($"Monster Name: {monster.Name}", LogLevel.Info);
                //ModEntry.instance.Monitor.Log($"Current health: {_current_health} / Max health: {_current_max_health}", LogLevel.Info);
                //ModEntry.instance.Monitor.Log($"Actual bar: {(Textures.GetPixel().Width * Game1.pixelZoom) * (int)((_current_health / _current_max_health) * 20)} / Max: {(Textures.GetPixel().Width * Game1.pixelZoom) * 20}", LogLevel.Info);

                if (_current_health >= _current_max_health && ModEntry.config.Show_Full_Life) continue;

                if (monster is GreenSlime slime)
                {
                    if (monster.Name == "Frost Jelly")
                    {
                        _current_sprite = Textures.blueslime_theme;
                        _bar_color = new Color(69, 142, 212);
                        _border_color = slime.color;
                    }
                    else if (monster.Name == "Tiger Slime")
                    {
                        _current_sprite = Textures.tigerslime_theme;
                        _bar_color = new Color(174, 84, 18);
                    }
                    else
                    {
                        Color c1 = slime.color;
                        float cR = c1.R * 1.2f;
                        float cG = c1.G * 1.2f;
                        float cB = c1.B * 1.2f;
                        byte cA = 255;
                        Color c2 = new Color((int)cR, (int)cG, (int)cB, cA);

                        _current_sprite = Textures.greenslime_theme;
                        _bar_color = c2;
                        _border_color = slime.color;
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
                    else if (monster.Name == "Magma Sprite")
                    {
                        _current_sprite = Textures.magmasprite_theme;
                        _bar_color = new Color(255, 204, 51);
                    }
                    else if (monster.Name == "Magma Sparker")
                    {
                        _current_sprite = Textures.magmasparker_theme;
                        _bar_color = new Color(221, 250, 117);
                    }
                    else if (monster.Name == "Haunted Skull")
                    {
                        _current_sprite = Textures.hauntedskull_theme;
                        _bar_color = new Color(172, 172, 172);
                    }
                    else
                    {
                        _current_sprite = Textures.bat_theme;
                    }
                }
                else if (monster is Bug bug)
                {
                    if (bug.isArmoredBug.Value)
                    {
                        _current_sprite = Textures.armoredbug_theme;
                    }
                    else
                    {
                        _current_sprite = Textures.bug_theme;
                        _bar_color = new Color(130, 199, 171);
                    }
                    _height = 15;
                }
                else if (monster is Fly)
                {
                    if (monster.Name == "Mutant Fly")
                    {
                        _current_sprite = Textures.mutantfly_theme;
                        _bar_color = new Color(0, 194, 31);
                    }
                    else
                    {
                        _current_sprite = Textures.cavefly_theme;
                        _bar_color = new Color(207, 43, 156);
                    }
                }
                else if (monster is Duggy)
                {
                    if (monster.Name == "Magma Duggy")
                    {
                        _current_sprite = Textures.magmaduggy_theme;
                        _bar_color = new Color(246, 59, 59);
                    }
                    else
                    {
                        _current_sprite = Textures.duggy_theme;
                    }
                }
                else if (monster is Grub)
                {
                    if (monster.Name == "Mutant Grub")
                    {
                        _current_sprite = Textures.mutantgrub_theme;
                        _bar_color = new Color(75, 242, 63);
                    }
                    else
                    {
                        _current_sprite = Textures.grub_theme;
                        _bar_color = new Color(255, 215, 135);
                    }
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
                else if (monster is RockGolem golem)
                {
                    if (monster.Sprite.CurrentFrame % 4 == 0) continue;
                    
                    if (golem.wildernessFarmMonster)
                    {
                        _current_sprite = Textures.wildernessgolem_theme;
                        _bar_color = new Color(78, 62, 41);
                    }
                    else
                    {
                        _current_sprite = Textures.stonegolem_theme;
                        _bar_color = new Color(121, 121, 121);
                    }
                }
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
                    if (monster.Name == "Hot Head")
                    {
                        _current_sprite = Textures.hothead_theme;
                        _bar_color = new Color(255, 93, 43);
                    }
                    else
                    {
                        _current_sprite = Textures.metalhead_theme;
                        _bar_color = new Color(220, 123, 5);
                    }
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
                else if (monster is Mummy)
                {
                    _current_sprite = Textures.mummy_theme;
                    _bar_color = new Color(225, 203, 101);
                }
                else if (monster is DinoMonster)
                {
                    _current_sprite = Textures.pepperrex_theme;
                    _bar_color = new Color(137, 180, 56);
                }
                else if (monster is Serpent)
                {
                    _current_sprite = Textures.serpent_theme;
                    _bar_color = new Color(82, 251, 163);
                    _height = -2;
                }
                else if (monster is DwarvishSentry)
                {
                    _current_sprite = Textures.dwarvishsentry_theme;
                    _bar_color = new Color(172, 112, 105);
                    _height = 14;
                }
                else if (monster is LavaLurk)
                {
                    _current_sprite = Textures.lavalurk_theme;
                    _bar_color = new Color(220, 123, 5);
                }
                else if (monster.Name == "False Magma Cap")
                {
                    _current_sprite = Textures.falsemagmacap_theme;
                    _bar_color = new Color(255, 242, 201);
                }
                /*
                else if (monster is BigSlime bigslime)
                {
                    _current_sprite = Textures.greenslime_theme;
                    _bar_color = new Color(97, 212, 69);
                    _border_color = bigslime.hard;
                }
                */
                else if (monster is Spiker)
                {
                    continue;
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
                    _border_color);
            }
        }
    }
}
