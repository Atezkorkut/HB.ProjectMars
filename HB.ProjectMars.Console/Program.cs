using HB.ProjectMars.Business.Helper;
using HB.ProjectMars.Business.Rover;
using HB.ProjectMars.Core.Entity;
using HB.ProjectMars.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HB.ProjectMars.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Plateau p1;
            MarsRover r1;

            string plateauSize = System.Console.ReadLine();
            List<string> plateauSizeList = ParameterProcessor.ParameterParser(plateauSize);
            if (int.TryParse(plateauSizeList[0], out int plateauSizeX) && int.TryParse(plateauSizeList[1], out int plateauSizeY))
            {
                Coordinate plateauSizeResult = new Coordinate(plateauSizeX, plateauSizeY);
                p1 = new Plateau(plateauSizeResult);
            }
            else
            {
                throw new ArgumentException("Invalid Plateau Size");
            }

            string roverStartPosition = System.Console.ReadLine();
            List<string> roverStartPositionList = ParameterProcessor.ParameterParser(roverStartPosition);
            if (int.TryParse(roverStartPositionList[0], out int roverStartPositionX)
                && int.TryParse(roverStartPositionList[1], out int roverStartPositionY))
            {
                Coordinate marsRoverStartCoordinate = new Coordinate(roverStartPositionX, roverStartPositionY);
                Enum.TryParse(roverStartPositionList[2], out Directions directionResult);
                Direction marsRoverStartDirection = new Direction(directionResult);
                r1 = new MarsRover(marsRoverStartCoordinate, marsRoverStartDirection, p1);
            }
            else
            {
                throw new ArgumentException("Invalid Mars Rover Start Position");
            }

            string commands = System.Console.ReadLine();
            CommandProcessor.ProcessCommand(r1, commands);
            System.Console.WriteLine(r1.GetCurrentPosition());            



            /* TEST CASES
            Coordinate plateauSize = new Coordinate(5, 5);
            Plateau p1 = new Plateau(plateauSize);

            Coordinate marsRoverStartCoordinate = new Coordinate(1, 2);
            Direction marsRoverStartDirection = new Direction(Directions.N);
            MarsRover r1 = new MarsRover(marsRoverStartCoordinate, marsRoverStartDirection,p1);

            string commands = "LMLMLMLMM";
            CommandProcessor.ProcessCommand(r1, commands);
            System.Console.WriteLine(r1.GetCurrentPosition());

            marsRoverStartCoordinate = new Coordinate(3,3);
            marsRoverStartDirection = new Direction(Directions.E);
            MarsRover r2 = new MarsRover(marsRoverStartCoordinate, marsRoverStartDirection,p1);

            commands = "MMRMMRMRRM";
            CommandProcessor.ProcessCommand(r2, commands);
            System.Console.WriteLine(r2.GetCurrentPosition());
            */
            System.Console.ReadLine();
        }
    }
}
