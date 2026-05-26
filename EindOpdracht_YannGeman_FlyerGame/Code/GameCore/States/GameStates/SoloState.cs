using Code.GameCore.States.BaseStates;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.GameCore.States.GameStates
{
    public class SoloState : PlayState
    {
        private readonly GameContext _context;
        public SoloState(GameContext context) : base(context)
        {
            _context = context;
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            _context.Player.Update();
        }
    }
}
