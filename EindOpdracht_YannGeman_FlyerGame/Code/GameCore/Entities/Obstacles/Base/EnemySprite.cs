using Code.GameCore.Entities.Sprites;
using Code.GameCore.States.BaseStates;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.GameCore.Entities.Obstacles.Base
{
    public class EnemySprite : Sprite
    {
        public EnemySprite(Texture2D texture, Vector2 position, float speed, float scale = 1)
            : base(texture, position, speed, scale)
        {
        }

        
        public void CheckCollisions(GameContext vliegtuig)
        {
            Rectangle obstacleCollisionBox = CollisionBox;
            Rectangle skierCollisionBox = vliegtuig.Player.CollisionBox;

            if (obstacleCollisionBox.Intersects(skierCollisionBox))
                if (obstacleCollisionBox.Intersects(skierCollisionBox))
                {
                    vliegtuig.ChangeState(new GameOverState(vliegtuig));
                }

        }
    }
}

