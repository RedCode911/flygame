using Code.GameCore.Entities.Interfaces;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.GameCore.System.inputs
{
    public class PlayerInputService : IPlayerInputService
    {
        // TODO: We zouden deze toetsen kunnen uitlezen uit een bestand (denk aan wat jullie bij programmeren gedaan hebben).
        // Dit zou het makkelijker maken om de controls aan te passen, zonder dat je de code moet aanpassen. Nu zijn de controls hardcoded.

        public bool ShouldGoRight()
        {
            return ControllerManager.IsKeyDown(Keys.Right, Keys.D);
        }

        public bool ShouldGoLeft()
        {
            return ControllerManager.IsKeyDown(Keys.Left, Keys.Q);
        }

        public bool ShouldGoUp()
        {
            return ControllerManager.IsKeyDown(Keys.Up, Keys.Z);
        }

        public bool ShouldGoDown()
        {
            return ControllerManager.IsKeyDown(Keys.Down, Keys.S);
        }

    }
}
