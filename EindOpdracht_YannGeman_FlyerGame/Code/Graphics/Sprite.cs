using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.Graphics
{
    public class Sprite
    {
        public Texture2D Texture {  get; private set; }

        public Color TintColor { get;  set; } = Color.White;

        public Sprite(Texture2D texture) 
        {
            Texture = texture;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            spriteBatch.Draw(Texture, position, TintColor);
        }
    }
}
