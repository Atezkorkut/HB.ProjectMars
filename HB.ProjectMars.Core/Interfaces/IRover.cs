using HB.ProjectMars.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HB.ProjectMars.Core.Interfaces
{
    public interface IRover
    {
        void Move(Commands command);
        string GetCurrentPosition();
    }
}
