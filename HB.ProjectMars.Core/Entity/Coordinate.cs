using HB.ProjectMars.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HB.ProjectMars.Core.Entity
{
    public class Coordinate : ICoordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
