using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCC_ENROLLMENT_SYSTEM
{
    public class AppSettings
    {
        public enum Level
        {
            ELEMENTARY,
            JUNIOR_HIGHSCHOOL,
            SENIOR_HIGHSCHOOL
        }

        private static Level schoolLevel = Level.ELEMENTARY;

        public static Level SchoolLevel { get => schoolLevel; set => schoolLevel = value; }
    }
}
