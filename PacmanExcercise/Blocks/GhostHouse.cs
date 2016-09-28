﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacmanExcercise.Actors;

namespace PacmanExcercise.Blocks
{
    public class GhostHouse : ConstructionBlockType
    {
        #region Overrides of ConstructionBlockType

        public override Point nextPositionForGoing(Actor anActor, Point aMovement)
        {
            if (anActor is Ghost)
            {
                return anActor.position().plus(aMovement);
            }
            else if (anActor is Pacman)
            {
                return anActor.position();
            }
            else
            {
                throw new NotImplementedException();
            }

        }

        #endregion
    }
}