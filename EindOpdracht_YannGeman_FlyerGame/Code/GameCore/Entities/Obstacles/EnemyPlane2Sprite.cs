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
    internal class EnemyPlane2Sprite : EnemySprite
    {
        private readonly IMovementStrategy _movementStrategy;
        public bool Left { get; set; }

        public EnemyPlane2Sprite(Texture2D texture, Vector2 position, float speed,
                           IMovementStrategy movementStrategy, float scale = 1)
            : base(texture, position, speed, scale)
        {
            _movementStrategy = movementStrategy;
        }

        public override void Update()
        {
            _movementStrategy.Update(this);
        }
    }
}
