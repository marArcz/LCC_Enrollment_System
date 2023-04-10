using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCC_ENROLLMENT_SYSTEM.Models
{
    internal class Enrollment
    {
        public int id { get; set; }
        public int year_level { get; set; }
        public int studentId { get; set; }
        public int grade_level_id { get; set; }
        public int section_id { get; set; }
        public Student? student { get; set; }

        public Section? section { get; set; }
        public GradeLevel gradeLevel { get; set; }

        public List<SubjectsEnrolled> subjectsEnrolled;
        public string Tracks { get; set; }
    }
}
