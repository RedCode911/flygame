using Code.GameCore.Entities.Interfaces;
using Code.GameCore.Entities.Managers;
using Code.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.GameCore.Entities
{
    public class GroundMapper : IGameEntity
    {
        private Sprite sprite;

        private const float BASE_SPEED_X = 0;
        private const float BASE_SPEED_Y = (float)-0.5;

        public int DrawOrder { get; set; }

        public EntityManager _entityManager;


        public GroundMapper(Texture2D texture, Vector2 position, Game game)
        {
            sprite = new Sprite(texture);
            Position = position;
            _entityManager = new EntityManager(game);
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            sprite.Draw(spriteBatch, Position);
        }

        public void Update(GameTime gameTime)
        {
            if (Position.Y <= -1500)
                Position += new Vector2(BASE_SPEED_X, 3000);
            Position += new Vector2(BASE_SPEED_X, BASE_SPEED_Y);
        }

        public Vector2 Position { get; set; }
    }
}