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
    public class GameOverState : AbstractState
    {
        public GameOverState(GameContext context)
            : base(context)
        {
        }

        public override void Update(GameTime gameTime)
        {
            if (IsKeyDown(Keys.Enter))
                Context.ChangeState(new ManuState(Context));
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(Context.AssetsManager.GetFont(AssetNames.GAME_FONT),
                                   "GameOver. Druk op enter om terug naar het menu te gaan",
                                   Vector2.Zero,
                                   Color.White);
        }
    }
}
