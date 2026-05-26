using Code.GameCore.Entities.Obstacles;
using Code.GameCore.Entities.Obstacles.MovementStrategies;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.GameCore.Entities.Factorys.Enemys
{
    internal class EnemyPlane1Factorys
    {
        public static EnemyPlane1Sprite CreateBig(Texture2D texture, float x, float y, float speed, float baseScale)
        {
            return Create(texture, new Vector2(x, y), speed, baseScale * 1.5F);
        }

        public static EnemyPlane1Sprite CreateSmall(Texture2D texture, float x, float y, float speed, float baseScale)
        {
            return Create(texture, new Vector2(x, y), speed, baseScale * 0.75F);
        }

        public static EnemyPlane1Sprite Create(Texture2D texture, float x, float y, float speed, float scale)
        {
            return Create(texture, new Vector2(x, y), speed, scale);
        }

        public static EnemyPlane1Sprite Create(Texture2D texture, Vector2 position, float speed, float scale)
        {
            // OPGEPAST: De volgende code zal random een movementStrategy genereren, dit is iets wat je meegeeft aan de Create van de Factory en veelal gegenereerd door een klasse
            // Het hier random genereren is puur om het principe te tonen
            var r = Random.Shared.Next(3);
            IMovementStrategy movementStrategy = null;
            switch (r)
            {
                case 0: movementStrategy = new DiagonalMovementStrategy(); break;
                case 1: movementStrategy = new HorizontalMovementStrategy(); break;
                case 2: movementStrategy = new FastHorizontalMovementStrategy(); break;
            }

            return new EnemyPlane1Sprite(texture, position, speed, movementStrategy, scale);
        }
    }
}
