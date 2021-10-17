using System;
using System.Collections.Generic;
using System.Text;

namespace HB.ProjectMars.Core.Entity
{
    public class Plateau
    {
        private readonly Coordinate size;

        public Plateau(Coordinate c)
        {
            size = c;
        }

        public bool CheckPlateauLimit(Coordinate c)
        {
            if (c.X > size.X || c.Y > size.Y || c.X < 0 || c.Y < 0)
                return false;
            else
                return true;
        }
    }
}
