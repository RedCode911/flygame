using Code.GameCore.Entities.Interfaces;
using Code.GameCore.Entities.Sprites;
using Code.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.GameCore.Entities.Factorys
{
    public static class PlayerFactory
    {
        public static PlayerSprite CreatePlayerInVerticalCenter(Texture2D texture, float speed, float scale, IPlayerInputService inputService)
        {
            return CreatePlayer(texture, GraphicsFacade.GetWindowVerticalCenter(), speed, scale, inputService);
        }

        public static PlayerSprite CreatePlayer(Texture2D texture, float y, float speed, float scale, IPlayerInputService inputService)
        {
            return new PlayerSprite(texture, new Vector2(0, y), speed, scale, inputService);
        }

    }
}
