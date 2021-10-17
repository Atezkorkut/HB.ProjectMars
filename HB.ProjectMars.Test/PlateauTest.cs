using HB.ProjectMars.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HB.ProjectMars.Test
{
    public class PlateauTest
    {
        private readonly Coordinate plateauSize = new Coordinate(5, 5);

        [Theory]
        [ClassData(typeof(PlateauLimitData_Sucecss))]
        public void CheckPlateauLimit_Success(Coordinate c)
        {
            Plateau p = new Plateau(plateauSize);
            Assert.True(p.CheckPlateauLimit(c));

        }

        [Theory]
        [ClassData(typeof(PlateauLimitData_Fail))]
        public void CheckPlateauLimit_Fail(Coordinate c)
        {
            Plateau p = new Plateau(plateauSize);
            Assert.False(p.CheckPlateauLimit(c));
        }
    }

    public class PlateauLimitData_Sucecss : TheoryData<Coordinate>
    {

        public PlateauLimitData_Sucecss()
        {
            Add(new Coordinate(1, 1));
            Add(new Coordinate(2, 3));
            Add(new Coordinate(0, 4));
            Add(new Coordinate(5, 4));
            Add(new Coordinate(4, 5));
        }
    }



    public class PlateauLimitData_Fail : TheoryData<Coordinate>
    {
        public PlateauLimitData_Fail()
        {
            Add(new Coordinate(6, 1));
            Add(new Coordinate(8, 8));
            Add(new Coordinate(1, 9));
            Add(new Coordinate(10, 0));
        }
    }
}
