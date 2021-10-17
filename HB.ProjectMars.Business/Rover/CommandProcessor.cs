using HB.ProjectMars.Core.Entity;
using HB.ProjectMars.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HB.ProjectMars.Business.Rover
{
    public class CommandProcessor
    {
        public static void ProcessCommand(MarsRover r, string commands)
        {
            foreach (var command in commands)
            {
                Enum.TryParse(command.ToString(), out Commands commandResult);
                r.Move(commandResult);
            }
        }
    }
}
