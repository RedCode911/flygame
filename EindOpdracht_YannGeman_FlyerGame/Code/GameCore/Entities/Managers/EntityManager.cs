using Code.GameCore.Entities.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Code.GameCore.Entities.Managers
{
    public class EntityManager
    {
        private readonly ContentManager _contentManager;
        private readonly Dictionary<string, Texture2D> _textureAssets;
        private readonly Dictionary<string, SpriteFont> _fontAssets;
        private readonly Game _game;


        public EntityManager(Game game)
        {
            _game = game;
            _contentManager = new ContentManager(_game.Services, "Content");
            _textureAssets = new Dictionary<string, Texture2D>();
            _fontAssets = new Dictionary<string, SpriteFont>();
        }

        public Texture2D GetTexture(string name)
        {
            
            if (!_textureAssets.TryGetValue(name, out var texture))
            {
                
                texture = _contentManager.Load<Texture2D>(name);
                _textureAssets.Add(name, texture);
            }

            return texture;
        }

        public SpriteFont GetFont(string name)
        {
            if (!_fontAssets.TryGetValue(name, out var font))
            {
                font = _contentManager.Load<SpriteFont>(name);
                _fontAssets.Add(name, font);
            }

            return font;
        }
        
    }
}
