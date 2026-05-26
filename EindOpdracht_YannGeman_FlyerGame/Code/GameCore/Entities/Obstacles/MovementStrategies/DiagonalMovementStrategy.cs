using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.GameCore.Entities.Obstacles.MovementStrategies
{
    public class DiagonalMovementStrategy : IMovementStrategy
    {
        public void Update(object shark)
        {
            if (shark is BlueHouseSprite s)
            {
                s.UpdatePosition(-s.Speed, s.Speed * 0.25F);
            }
            if (shark is RedHouseSprite s1)
            {
                s1.UpdatePosition(-s1.Speed, s1.Speed * 0.25F);
            }
            if (shark is EnemyPlane1Sprite s2)
            {
                s2.UpdatePosition(-s2.Speed, s2.Speed * 0.25F);
            }
            if (shark is EnemyPlane2Sprite s3)
            {
                s3.UpdatePosition(-s3.Speed, s3.Speed * 0.25F);
            }
            if (shark is TreeSprite s4)
            {
                s4.UpdatePosition(-s4.Speed, s4.Speed * 0.25F);
            }
            if (shark is TreesSprite s5)
            {
                s5.UpdatePosition(-s5.Speed, s5.Speed * 0.25F);
            }
        }
    }
}
