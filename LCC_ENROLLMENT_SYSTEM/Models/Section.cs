using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCC_ENROLLMENT_SYSTEM.Models
{
    internal class Section
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GradeLevelId { get; set; }
        public GradeLevel gradeLevel { get; set; }

    }
}
