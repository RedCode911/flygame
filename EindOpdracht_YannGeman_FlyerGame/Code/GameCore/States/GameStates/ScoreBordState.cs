using Code.Database;
using Code.GameCore.States.BaseStates;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.GameCore.States.GameStates
{
    public class ScoreBordState : AbstractState
    {
        private List<int> solo;
        private List<int> multi;
        public ScoreBordState(GameContext context) : base(context)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            ScoreSoloRepository soloRepo = new ScoreSoloRepository(databaseConnection);
            ScoreVsRepository multiRepo = new ScoreVsRepository(databaseConnection);

                solo = soloRepo.GetAll().Select(s => s.score).ToList();
                multi = multiRepo.GetAll().Select(s => s.score).ToList();
            solo.Sort((a, b) => b.CompareTo(a));
            multi.Sort((a, b) => b.CompareTo(a));
        }

        public override void Update(GameTime gameTime)
        {
            if (IsKeyDown(Keys.Enter))
                Context.ChangeState(new ManuState(Context));
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(Context.AssetsManager.GetFont(AssetNames.GAME_FONT),
                                   $"Druk op enter om terug naar het menu te gaan"+
                                   $"\n Solo: \n1. {solo[0]} \n2. {solo[1]} \n3. {solo[2]} \n4. {solo[3]}\n5. {solo[4]}",
                                   // + $"\n multi: \n1. {multi[0]} \n2. {multi[1]} \n3. {multi[2]} \n4. {multi[3]}\n5. {multi[4]}",
                                   Vector2.Zero,
                                   Color.White);
        }
    }
}
