using HB.ProjectMars.Core.Enums;
using HB.ProjectMars.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HB.ProjectMars.Core.Entity
{
    public class MarsRover : IRover
    {
        private readonly Coordinate currentCoordinate;
        private Direction currentDirection;
        private readonly Plateau currentPlateau;

        public MarsRover(Coordinate c, Direction d, Plateau p)
        {
            currentCoordinate = c;
            currentDirection = d;
            currentPlateau = p;
        }

        public string GetCurrentPosition()
        {
            return string.Format("{0} {1} {2}", currentCoordinate.X, currentCoordinate.Y, currentDirection.currentDirection);
        }

        public void Move(Commands command)
        {
            switch (command)
            {
                case Commands.L:
                    currentDirection = currentDirection.TurnLeftDirection();
                    break;

                case Commands.R:
                    currentDirection = currentDirection.TurnRightDirection();
                    break;

                case Commands.M:
                    SetCoordinates();
                    break;

                default:
                    throw new ArgumentException(message: "unkown command");
            }

            if (!currentPlateau.CheckPlateauLimit(currentCoordinate))
            {
                throw new InvalidOperationException("out of limit");
            }
        }

        private void SetCoordinates()
        {
            currentCoordinate.X += Constants.DirectionConstants.directionForwardXValue[(int)currentDirection.currentDirection];
            currentCoordinate.Y += Constants.DirectionConstants.directionForwardYValue[(int)currentDirection.currentDirection];
        }
    }
}
