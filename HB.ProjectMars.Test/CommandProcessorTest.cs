using HB.ProjectMars.Business.Rover;
using HB.ProjectMars.Core.Entity;
using HB.ProjectMars.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HB.ProjectMars.Test
{
    public class CommandProcessorTest
    {
        [Fact]
        public void ProcessCommand_Move_Success()
        {
            MarsRover marsRover = new MarsRover(new Coordinate(0, 0), new Direction(Directions.N), new Plateau(new Coordinate(2, 2)));
            string command = "M";
            CommandProcessor.ProcessCommand(marsRover, command);
            Assert.Equal("0 1 N", marsRover.GetCurrentPosition());
        }

        [Fact]
        public void ProcessCommand_MoveNStep_Success()
        {
            MarsRover marsRover = new MarsRover(new Coordinate(0, 0), new Direction(Directions.N), new Plateau(new Coordinate(2, 2)));
            string command = "MMRMMLL";
            CommandProcessor.ProcessCommand(marsRover, command);
            Assert.Equal("2 2 W", marsRover.GetCurrentPosition());
        }
    }
}
