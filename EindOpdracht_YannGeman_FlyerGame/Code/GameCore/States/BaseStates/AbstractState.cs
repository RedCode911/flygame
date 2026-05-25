using Code.GameCore.System;
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
    public abstract class AbstractState
    {
        protected GameContext Context { get; init; }

        public AbstractState(GameContext context)
        {
            Context = context;
        }

        public abstract void Update(GameTime gameTime);

        public abstract void Draw(GameTime gameTime, SpriteBatch spriteBatch);

        protected bool IsKeyDown(Keys key1, Keys key2)
            => ControllerManager.IsKeyDown(key1, key2);

        protected bool IsKeyDown(Keys key)
            => ControllerManager.IsKeyDown(key);

        protected bool WasKeyJustPressed(Keys key)
            => ControllerManager.WasKeyJustPressed(key);
    }
}
