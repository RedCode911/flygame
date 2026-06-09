using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.GameCore.Entities.Obstacles.MovementStrategies
{
    public class FastHorizontalMovementStrategy : IMovementStrategy
    {
        public void Update(object shark)
        {
            if (shark is HouseSprite s)
            {
                s.UpdatePositionY( s.Speed);
            }
            if (shark is EnemyPlaneSprite s2)
            {
                s2.UpdatePositionY(1.25F * s2.Speed);
            }
            if (shark is TreeSprite s4)
            {
                s4.UpdatePositionY( s4.Speed);
            }
        }
    }
}
