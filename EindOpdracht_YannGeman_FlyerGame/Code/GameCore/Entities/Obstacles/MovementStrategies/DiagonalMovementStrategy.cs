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
            if (shark is BlueHouseSprite s)
            {
                s.UpdatePosition(0, s.Speed );
            }
            if (shark is RedHouseSprite s1)
            {
                s1.UpdatePosition(0, s1.Speed );
            }
            if (shark is EnemyPlane1Sprite s2)
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
            if (shark is EnemyPlane2Sprite s3)
            {
                if (s3.Left)
                {
                    if (s3.Position.X <= 15)
                        s3.Left = false;
                    s3.UpdatePosition(-s3.Speed * 0.25F, s3.Speed);
                }
                if (!s3.Left)
                {
                    if (s3.Position.X >= GraphicsFacade.GetWindowWidth()-15)
                        s3.Left = true;
                    s3.UpdatePosition(s3.Speed * 0.25F, s3.Speed);
                }     
            }
            if (shark is TreeSprite s4)
            {
                s4.UpdatePosition(0  , s4.Speed );
            }
            if (shark is TreesSprite s5)
            {
                s5.UpdatePosition(0, s5.Speed );
            }
        }
    }
}
