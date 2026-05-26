using Code.GameCore.Entities.Obstacles.Base;
using Code.GameCore.Entities.Obstacles.MovementStrategies;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.GameCore.Entities.Obstacles
{
    public class BlueHouseSprite : EnemySprite
    {
        private readonly IMovementStrategy _movementStrategy;

        public BlueHouseSprite(Texture2D texture, Vector2 position, float speed,
                           IMovementStrategy movementStrategy, float scale = 1)
            : base(texture, position, speed, scale)
        {
            _movementStrategy = movementStrategy;
        }
        public override Rectangle CollisionBox
        {
            get
            {
                Rectangle box = new Rectangle((int)Math.Round(Position.X), (int)Math.Round(Position.Y), 16, 14);
                return box;
            }
        }

        public override void Update()
        {
            _movementStrategy.Update(this);
        }
    }
}
