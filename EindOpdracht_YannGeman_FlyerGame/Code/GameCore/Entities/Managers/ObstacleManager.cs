using Code.GameCore.Entities.Factorys.Enemys;
using Code.GameCore.Entities.Interfaces;
using Code.GameCore.Entities.Obstacles;
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
        private readonly List<Texture2D> _enemyTexture;
        private double _elapsedTimeInMs1, _elapsedTimeInMs2, _elapsedTimeInMs3, _elapsedTimeInMs4, _elapsedTimeInMs5, _elapsedTimeInMs6;

        public ObstacleManager(List<EnemySprite> enemies, List<Texture2D> enemyTexture)
        {
            _enemies = enemies;
            _enemyTexture = enemyTexture;
        }

        public void Update(GameTime gameTime)
        {
            _elapsedTimeInMs1 += gameTime.ElapsedGameTime.TotalMilliseconds;
            _elapsedTimeInMs2 += gameTime.ElapsedGameTime.TotalMilliseconds;
            _elapsedTimeInMs3 += gameTime.ElapsedGameTime.TotalMilliseconds;
            _elapsedTimeInMs4 += gameTime.ElapsedGameTime.TotalMilliseconds;
            _elapsedTimeInMs5 += gameTime.ElapsedGameTime.TotalMilliseconds;
            _elapsedTimeInMs6 += gameTime.ElapsedGameTime.TotalMilliseconds;

            if (_elapsedTimeInMs1 >= Const.BLUEHOUSE_SPAWN_TIME_IN_MS)
            {
                _enemies.Add(BlueHouseFactory.CreateBig(
                    _enemyTexture[2],
                    GraphicsFacade.GetWindowWidth(),
                    GraphicsFacade.GetWindowVerticalCenter(),
                    Const.BACKGROUND_SPEED,
                    Const.BLUEHOUSE_BASE_SCALE));

                _elapsedTimeInMs1 = 0;
            }
            if (_elapsedTimeInMs2 >= Const.REDHOUSE_SPAWN_TIME_IN_MS)
            {
                _enemies.Add(RedHouseFactory.CreateBig(
                    _enemyTexture[3],
                    GraphicsFacade.GetWindowWidth(),
                    GraphicsFacade.GetWindowVerticalCenter(),
                    Const.REDHOUSE_SPEED,
                    Const.REDHOUSE_BASE_SCALE));

                _elapsedTimeInMs2 = 0;
            }
            if (_elapsedTimeInMs3 >= Const.TREES_SPAWN_TIME_IN_MS)
            {
                _enemies.Add(TreesFactory.CreateBig(
                    _enemyTexture[5],
                    GraphicsFacade.GetWindowWidth(),
                    GraphicsFacade.GetWindowVerticalCenter(),
                    Const.TREES_SPEED,
                    Const.TREES_BASE_SCALE));

                _elapsedTimeInMs3 = 0;
            }
            if (_elapsedTimeInMs4 >= Const.TREE_SPAWN_TIME_IN_MS)
            {
                _enemies.Add(TreeFactory.CreateBig(
                    _enemyTexture[4],
                    GraphicsFacade.GetWindowWidth(),
                    GraphicsFacade.GetWindowVerticalCenter(),
                    Const.TREE_SPEED,
                    Const.TREE_BASE_SCALE));

                _elapsedTimeInMs4 = 0;
            }
            if (_elapsedTimeInMs5 >= Const.ENEMYPLANE1_SPAWN_TIME_IN_MS)
            {
                _enemies.Add(EnemyPlane1Factorys.CreateBig(
                    _enemyTexture[0],
                    GraphicsFacade.GetWindowWidth(),
                    GraphicsFacade.GetWindowVerticalCenter(),
                    Const.ENEMYPLANE1_SPEED,
                    Const.ENEMYPLANE1_BASE_SCALE));

                _elapsedTimeInMs5 = 0;
            }
            if (_elapsedTimeInMs6 >= Const.ENEMYPLANE2_SPAWN_TIME_IN_MS)
            {
                _enemies.Add(EnemyPlane2Factorys.CreateBig(
                    _enemyTexture[1],
                    GraphicsFacade.GetWindowWidth(),
                    GraphicsFacade.GetWindowVerticalCenter(),
                    Const.ENEMYPLANE2_SPEED,
                    Const.ENEMYPLANE2_BASE_SCALE));

                _elapsedTimeInMs6 = 0;
            }
        }
    }
}
