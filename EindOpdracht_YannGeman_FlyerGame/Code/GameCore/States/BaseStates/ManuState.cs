using Code.GameCore.States.GameStates;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.GameCore.States.BaseStates
{
    public class ManuState : AbstractState
    {
        public ManuState(GameContext context) : base(context)
        {
        }

        public override void Update(GameTime gameTime)
        {
            if (IsKeyDown(Keys.NumPad1))
                Context.ChangeState(new SoloState(Context));
            if (IsKeyDown(Keys.NumPad2))
                Context.ChangeState(new TwoPlayerState(Context));
            if (IsKeyDown(Keys.NumPad3))
                Context.ChangeState(new ScoreBordState(Context));
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(Context.AssetsManager.GetFont(AssetNames.GAME_FONT), 
                "Selecteer een optie :\n1. Start Solo Game\n2. Start 2 Player Game\n3. Scorebord", Vector2.Zero, Color.White);
        }
    }
}
