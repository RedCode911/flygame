using Code.GameCore.States.BaseStates;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.GameCore.States.GameStates
{
    public class TwoPlayerState : PlayState
    {
        private readonly GameContext _context;
        public TwoPlayerState(GameContext context) : base(context)
        {
            _context = context;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            _context.Player.Update();
            _context.Player1.Update();
        }
    }
}
