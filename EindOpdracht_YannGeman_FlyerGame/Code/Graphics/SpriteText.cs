using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.Graphics
{
    public class SpriteText
    {
        public SpriteFont Font { get; private set; }
        public string Text { get; private set; }

        public Color TintColor { get; set; } = Color.Black;

        public SpriteText(SpriteFont texture, string text)
        {
            Font = texture;
            Text = text;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            spriteBatch.DrawString(Font, Text, position, TintColor);
        }
    }
}
