using Code.GameCore.Entities.Interfaces;
using Code.GameCore.Entities.Obstacles.Base;
using Code.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.GameCore.Entities.Managers
{
    public class ObstacleManager 
    {
        private readonly List<EnemySprite> _enemies;
        private readonly Texture2D _enemyTexture;
        private double _elapsedTimeInMs;

        public ObstacleManager(List<EnemySprite> enemies, Texture2D enemyTexture)
        {
            _enemies = enemies;
            _enemyTexture = enemyTexture;
        }

        public void Update(GameTime gameTime)
        {
            _elapsedTimeInMs += gameTime.ElapsedGameTime.TotalMilliseconds;

            //if (_elapsedTimeInMs >= Const.SHARK_SPAWN_TIME_IN_MS)
            //{
            //    // TODO: Spawn elke haai op een random hoogte, nu spawnen ze altijd in het midden van het scherm.
            //    // TODO: Geef een haai ook verschillende snelheden (bv. random tussen 1 en 3).
            //    // TODO: Voeg een limiet toe van 8 haaien tegelijk.
            //    _enemies.Add(SharkFactory.CreateBig(
            //        _enemyTexture,
            //        GraphicsFacade.GetWindowWidth(),
            //        GraphicsFacade.GetWindowVerticalCenter(),
            //        Const.SHARK_SPEED,
            //        Const.SHARK_BASE_SCALE));

            //    _elapsedTimeInMs = 0;
            //}
        }
    }
}
