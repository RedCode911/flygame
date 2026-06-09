using Code.Graphics;
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
            if (shark is HouseSprite s)
            {
                s.UpdatePosition(0, s.Speed );
            }
            if (shark is EnemyPlaneSprite s2)
            {
                if (s2.Left)
                {
                    if (s2.Position.X <= 15)
                        s2.Left = false;  
                    s2.UpdatePosition(-s2.Speed * 0.25F, s2.Speed);
                } 
                if (!s2.Left)
                {
                    if (s2.Position.X >= GraphicsFacade.GetWindowWidth()-30)
                        s2.Left = true;
                    s2.UpdatePosition(s2.Speed * 0.25F, s2.Speed);
                }  
            }
            if (shark is TreeSprite s4)
            {
                s4.UpdatePosition(0  , s4.Speed );
            }
        }
    }
}
