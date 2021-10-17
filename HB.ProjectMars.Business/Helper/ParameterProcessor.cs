using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HB.ProjectMars.Business.Helper
{
    public class ParameterProcessor
    {
        public static List<string> ParameterParser(string parameter)
        {
            return parameter.ToUpper().Trim().Split(' ').ToList();
        }

    }
}
