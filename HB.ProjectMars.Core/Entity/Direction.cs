using HB.ProjectMars.Core.Enums;
using HB.ProjectMars.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HB.ProjectMars.Core.Entity
{
    public class Direction : IDirection
    {

        public readonly Directions currentDirection;
        
        public Direction(Directions direction)
        {
            this.currentDirection = direction;
        }

        public Direction TurnRightDirection()
        {
            int nextDirection = (int)currentDirection - 1;
            nextDirection = nextDirection < 0 ? nextDirection + Constants.DirectionConstants.DirectionsCounts : nextDirection;
            nextDirection %= Constants.DirectionConstants.DirectionsCounts;
            return new Direction((Directions)nextDirection);
        }

        public Direction TurnLeftDirection()
        {
            int nextDirection = (int)currentDirection + 1;
            nextDirection %= Constants.DirectionConstants.DirectionsCounts;
            return new Direction((Directions)nextDirection);
        }
    }
}
