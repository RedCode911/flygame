using Code.GameCore.Entities.Interfaces;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.GameCore.System.inputs
{
    public class PlayerInputServicePlayer1 : IPlayerInputService
    {
        // TODO: We zouden deze toetsen kunnen uitlezen uit een bestand (denk aan wat jullie bij programmeren gedaan hebben).
        // Dit zou het makkelijker maken om de controls aan te passen, zonder dat je de code moet aanpassen. Nu zijn de controls hardcoded.

        public bool ShouldGoRight()
        {
            return ControllerManager.IsKeyDown(Keys.D);
        }

        public bool ShouldGoLeft()
        {
            return ControllerManager.IsKeyDown(Keys.Q);
        }

        public bool ShouldGoUp()
        {
            return ControllerManager.IsKeyDown( Keys.Z);
        }

        public bool ShouldGoDown()
        {
            return ControllerManager.IsKeyDown(Keys.S);
        }

    }
}
