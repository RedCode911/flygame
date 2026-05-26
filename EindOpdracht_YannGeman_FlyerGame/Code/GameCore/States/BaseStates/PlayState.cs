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

namespace Code.GameCore.States.BaseStates
{
    public class PlayState : AbstractState
    {
        private readonly ObstacleManager _enemySpawner;

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

            _enemySpawner = new ObstacleManager(
                context.Enemies,
                enemyTextures);
        }

        public override void Update(GameTime gameTime)
        {
            // TODO: Zet the background om naar een sprite
            UpdateBackgroundPosition();

            Context.Player.Update();

            foreach (var enemy in Context.Enemies)
                enemy.Update();

            // TODO: Controlleer of de speler een haai aanraakt. Indien 'ja', ga naar de GameOver staat.

            _enemySpawner.Update(gameTime);

            // TODO: Als een haai links uit beeld is, dan mag deze uit de lijst. Nu blijven de haaien oneindig in de lijst staan, ook al zijn ze al lang uit beeld.

            if (WasKeyJustPressed(Keys.P))
                Context.ChangeState(new PauseState(Context, this));
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            // TODO: Zet the background om naar een sprite
            spriteBatch.Draw(Context.AssetsManager.GetTexture(AssetNames.BACKGROUND_TEXTURE),
                             Context.BackgroundPosition,
                             Const.BACKGROUND_SCALE);

            // TODO: We zouden bij het spawned van de haaien een bepaalde random scale kunnen geven aan een specifieke haai, zo zien sommige er groter uit dan anderen. Dit zou het speelveld interessanter maken. Nu hebben alle haaien dezelfde grootte.
            foreach (var enemySprite in Context.Enemies)
                enemySprite.Draw(spriteBatch);

            Context.Player.Draw(spriteBatch);
        }

        private void UpdateBackgroundPosition()
        {
            Context.BackgroundPosition = Context.BackgroundPosition with { Y = Context.BackgroundPosition.Y + Const.BACKGROUND_SPEED };
        }


    }
}
