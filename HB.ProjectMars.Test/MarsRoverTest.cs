using HB.ProjectMars.Core.Entity;
using HB.ProjectMars.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HB.ProjectMars.Test
{
    public class MarsRoverTest
    {
        private readonly Coordinate plateauSize;
        private Direction direction;
        private readonly Plateau plateau;
        private readonly Coordinate startCoordinate;

        public MarsRoverTest()
        {
            plateauSize = new Coordinate(2, 2);
            plateau = new Plateau(plateauSize);
            direction = new Direction(Core.Enums.Directions.N);
            startCoordinate = new Coordinate(0, 0);
        }

        [Fact]
        public void GetCurrentPosition_Success()
        {
            MarsRover r = new MarsRover(startCoordinate, direction, plateau);
            Assert.NotNull(r.GetCurrentPosition());
        }

        [Theory]
        [ClassData(typeof(MoveData_Sucecss))]
        public void Move_Success(Commands c)
        {
            MarsRover r = new MarsRover(startCoordinate, direction, plateau);

            try
            {
                r.Move(c);
                Assert.True(true);
            }
            catch (Exception)
            {
                Assert.True(false);
            }

        }

        [Theory]
        [ClassData(typeof(MoveData_UnkownCommand_Fail))]
        public void Move_UnkwonCommand_Fail(Commands c)
        {
            direction = new Direction(Directions.S);
            MarsRover r = new MarsRover(startCoordinate, direction, plateau);

            try
            {
                r.Move(c);
                Assert.True(false);
            }
            catch (Exception exc)
            {
                Assert.IsType<ArgumentException>(exc);
                Assert.Equal("unkown command", exc.Message);
            }
        }

        [Theory]
        [ClassData(typeof(MoveData_OutOfLimit_Fail))]
        public void Move_OutOfLimit_Fail(Commands c)
        {
            direction = new Direction(Directions.S);
            MarsRover r = new MarsRover(startCoordinate, direction, plateau);

            try
            {
                r.Move(c);
                Assert.True(false);
            }
            catch (Exception exc)
            {
                Assert.IsType<InvalidOperationException>(exc);
                Assert.Equal("out of limit", exc.Message);
            }
        }
    }

    public class MoveData_Sucecss : TheoryData<Commands>
    {
        public MoveData_Sucecss()
        {
            Add(Commands.L);
            Add(Commands.M);
            Add(Commands.R);
        }
    }

    public class MoveData_UnkownCommand_Fail : TheoryData<Commands>
    {
        public MoveData_UnkownCommand_Fail()
        {
            Add((Commands)5);
            Add((Commands)9);
            Add((Commands)10);
            Add((Commands)25);
        }
    }

    public class MoveData_OutOfLimit_Fail : TheoryData<Commands>
    {
        public MoveData_OutOfLimit_Fail()
        {
            Add(Commands.M);
        }
    }
}
