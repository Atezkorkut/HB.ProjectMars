using System;
using System.Collections.Generic;
using System.Text;

namespace HB.ProjectMars.Core.Constants
{
    public static class DirectionConstants
    {
        public static int DirectionsCounts { get; set; } = Enum.GetNames(typeof(Enums.Directions)).Length;

        public static readonly Dictionary<int, int> directionForwardXValue = new Dictionary<int, int>()
        {
            { (int)Enums.Directions.N, 0 },
            { (int)Enums.Directions.W, -1},
            { (int)Enums.Directions.S, 0},
            { (int)Enums.Directions.E, 1}
        };

        public static readonly Dictionary<int, int> directionForwardYValue = new Dictionary<int, int>()
        {
            { (int)Enums.Directions.N, 1 },
            { (int)Enums.Directions.W, 0 },
            { (int)Enums.Directions.S, -1},
            { (int)Enums.Directions.E, 0}
        };
    }
}
