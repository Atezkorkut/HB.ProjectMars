using HB.ProjectMars.Core.Entity;
using HB.ProjectMars.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HB.ProjectMars.Test
{
    public class DirectionTest
    {
        [Fact]
        public void Direction_TurnOnLeft_Success()
        {
            Direction d = new Direction(Directions.N);
            Assert.Equal(Directions.W, d.TurnLeftDirection().currentDirection);
        }

        [Fact]
        public void Direction_TurnOnRight_Success()
        {
            Direction d = new Direction(Directions.N);
            Assert.Equal(Directions.E, d.TurnRightDirection().currentDirection);
        }
    }
}
