using Code.GameCore.Entities.Factorys;
using Code.GameCore.Entities.Managers;
using Code.GameCore.Entities.Obstacles.Base;
using Code.GameCore.Entities.Sprites;
using Code.GameCore.States;
using Code.GameCore.States.BaseStates;
using Code.GameCore.System.inputs;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.GameCore
{
    public class GameContext
    {
        public AbstractState CurrentState { get; private set; }

        public PlayerSprite Player { get; private set; }

        public PlayerSprite Player1 { get; private set; }

        public List<EnemySprite> Enemies { get; set; }

        public EntityManager AssetsManager { get; }

        public Vector2 BackgroundPosition { get; set; }

        public GameContext(Game game)
        {
            BackgroundPosition = new Vector2(0, -800);
            Enemies = new List<EnemySprite>();

            AssetsManager = new EntityManager(game);
            Player = PlayerFactory.CreatePlayerInVerticalCenter(AssetsManager.GetTexture(AssetNames.PLAYER_TEXTURE), Const.PLAYER_SPEED,
                Const.PLAYER_SCALE, new PlayerInputService());

            Player1 = PlayerFactory.CreatePlayerInVerticalCenter(AssetsManager.GetTexture(AssetNames.PLAYER_TEXTURE), Const.PLAYER_SPEED,
                Const.PLAYER_SCALE, new PlayerInputServicePlayer1());

            CurrentState = new ManuState(this);
        }
        public void ChangeState(AbstractState newActiveState)
        {
            CurrentState = newActiveState;
        }

        public void Update(GameTime gameTime)
        {
            CurrentState.Update(gameTime);
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            CurrentState.Draw(gameTime, spriteBatch);
        }
    }
}
