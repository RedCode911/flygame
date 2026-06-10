using Code.Database;
using Code.GameCore.States.GameStates;
using Code.GameCore.System.Score;
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
        private ScoreKeeper ScoreKeeper;

        public GameOverState(GameContext context, int score)
            : base(context)
        {
            ScoreKeeper = new ScoreKeeper(score);
            //if(context.PereviousState is SoloState)
            //{
            //    DatabaseConnection con = new DatabaseConnection();
            //    ScoreSoloRepository repo = new ScoreSoloRepository(con);
            //    repo.Add(context.Score);
            //}
            //if (context.PereviousState is TwoPlayerState)
            //{
            //    DatabaseConnection con = new DatabaseConnection();
            //    ScoreVsRepository repo = new ScoreVsRepository(con);
            //    repo.Add(context.Score);
            //}
            DatabaseConnection con = new DatabaseConnection();
            ScoreSoloRepository repo = new ScoreSoloRepository(con);
            repo.Add(ScoreKeeper);

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
