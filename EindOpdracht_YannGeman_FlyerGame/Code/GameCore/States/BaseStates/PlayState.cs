using Code.GameCore.Entities.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Code.GameCore.Entities.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code.GameCore.Entities;

namespace Code.GameCore.States.BaseStates
{
    public class PlayState : AbstractState
    {
        private readonly ObstacleManager _enemySpawner;
        private Texture2D _background;

        public PlayState(GameContext context)
            : base(context)
        {
            List<Texture2D> enemyTextures = new List<Texture2D>
            {
                context.AssetsManager.GetTexture(AssetNames.ENEMY1_TEXTURE),
                context.AssetsManager.GetTexture(AssetNames.ENEMY2_TEXTURE),
                context.AssetsManager.GetTexture(AssetNames.HOUSE1_TEXTURE),
                context.AssetsManager.GetTexture(AssetNames.HOUSE2_TEXTURE),
                context.AssetsManager.GetTexture(AssetNames.TREE_TEXTURE),
                context.AssetsManager.GetTexture(AssetNames.TREEs_TEXTURE)
            };

            _background= context.AssetsManager.GetTexture(AssetNames.BACKGROUND_TEXTURE);


            _enemySpawner = new ObstacleManager(
                context.Enemies,
                enemyTextures, context);
        }

        public override void Update(GameTime gameTime)
        {
            for (int i = 0; i < Context.BackgroundPositions.Count; i++)
            {
                Context.BackgroundPositions[i] = Context.BackgroundPositions[i] with { Y = Context.BackgroundPositions[i].Y + Const.BACKGROUND_SPEED };
                if (Context.BackgroundPositions[i].Y >= 0)
                {
                    Context.BackgroundPositions[i] = new Vector2(Context.BackgroundPositions[i].X, -1500);
                }
            }

            Context.Score = gameTime.TotalGameTime.Seconds;


            foreach (var enemy in Context.Enemies)
                enemy.Update();

            _enemySpawner.Update(gameTime);

            if (WasKeyJustPressed(Keys.P))
                Context.ChangeState(new PauseState(Context, this));
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            for (int i = 0; i < Context.BackgroundPositions.Count; i++)
            {
                spriteBatch.Draw(_background, Context.BackgroundPositions[i], Const.BACKGROUND_SCALE);
            }

            foreach (var enemySprite in Context.Enemies)
                enemySprite.Draw(spriteBatch);

            spriteBatch.DrawString(Context.AssetsManager.GetFont(AssetNames.GAME_FONT), $"Score: {Context.Score}", new Vector2(10, 10), Color.White);

            Context.Player.Draw(spriteBatch);
        }
    }
}
