using Code.GameCore.Entities.Interfaces;
using Code.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.GameCore.Entities
{
    public class Vliegtuig : IGameEntity
    {
        private const float BASE_SPEED_X = 0;
        private const float BASE_SPEED_Y = (float)-0.5;

        private int BREETE_SKIER = 16;
        private int LENGT_SKIER = 20;

        private const int COLLISION_BOX_INSET = 3;

        public int DrawOrder { get; set; }

        public void Update(GameTime gameTime)
        {
            Position += BaseSpeed;
            Position += VectorMovement;
            if (Position.Y < -LENGT_SKIER)
            {
                IsDead = Die();
            }
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            Sprite.Draw(spriteBatch, Position);
        }

        public Vliegtuig(Texture2D skierTexture, Vector2 position, bool player1)
        {

            Player1 = player1;
            Sprite = new Sprite(skierTexture);
            Position = position;
            BaseSpeed = new Vector2(BASE_SPEED_X, BASE_SPEED_Y);

        }

        private bool Player1;

        public bool getPlayer1 { get; set; }

        public Sprite Sprite { get; private set; }

        public Vector2 Position { get; set; }

        public Vector2 VectorMovement { get; set; }

        public Vector2 BaseSpeed { get; private set; }

        public bool isPlayer1()
        {
            if (Player1 == true)
                return true;
            return false;
        }

        public bool IsDead { get; private set; }

        public bool Die()
        {
            return true;
        }

        public Rectangle CollisionBox
        {
            get
            {
                Rectangle box = new Rectangle(
                    (int)Math.Round(Position.X),
                    (int)Math.Round(Position.Y),
                    BREETE_SKIER,
                    LENGT_SKIER
                );


                return box;
            }
        }
    }
}
