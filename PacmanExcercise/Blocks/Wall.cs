﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanExcercise.Blocks
{
    public class Wall:ConstructionBlockType
    {
        #region Overrides of ConstructionBlockType

        public override Point nextPositionForGoing(Actor anActor, Point aMovement)
        {
            return anActor.position();
        }

        #endregion
    }
}
