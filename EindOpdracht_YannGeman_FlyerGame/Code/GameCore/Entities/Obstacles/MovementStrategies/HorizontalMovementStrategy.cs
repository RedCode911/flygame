using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.GameCore.Entities.Obstacles.MovementStrategies
{
    public class HorizontalMovementStrategy : IMovementStrategy
    {
        public void Update(object shark)
        {
            if (shark is BlueHouseSprite s)
            {
                s.UpdatePositionY(s.Speed);
            }
            if (shark is RedHouseSprite s1)
            {
                s1.UpdatePositionY(s1.Speed);
            }
            if (shark is EnemyPlane1Sprite s2)
            {
                s2.UpdatePositionY(s2.Speed);
            }
            if (shark is EnemyPlane2Sprite s3)
            {
                s3.UpdatePositionY(s3.Speed);
            }
            if (shark is TreeSprite s4)
            {
                s4.UpdatePositionY(s4.Speed);
            }
            if (shark is TreesSprite s5)
            {
                s5.UpdatePositionY(s5.Speed);
            }
        }
    }
}
