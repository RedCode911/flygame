using Code.GameCore.Entities.Interfaces;
using Code.GameCore.System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.GameCore.Entities.Sprites
{
    public class PlayerSprite : Sprite
    {
        private IPlayerInputService _inputService;



        public PlayerSprite(Texture2D texture, Vector2 position, float speed, float scale,
                            IPlayerInputService inputService)
            : base(texture, position, speed, scale)
        {
            _inputService = inputService;

        }


        public override void Update()
        {
            if (_inputService.ShouldGoRight())
                UpdatePositionX(+Speed);

            if (_inputService.ShouldGoLeft())
                UpdatePositionX(-Speed);

            if (_inputService.ShouldGoUp())
                UpdatePositionY(-Speed);

            if (_inputService.ShouldGoDown())
                UpdatePositionY(+Speed);
        }
        public Rectangle CollisionBox
        {
            get
            {
                Rectangle box = new Rectangle(
                    (int)Math.Round(Position.X),
                    (int)Math.Round(Position.Y),
                    24,
                    17
                );
                return box;
            }
        }
    }
}
