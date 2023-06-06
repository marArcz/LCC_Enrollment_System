using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCC_ENROLLMENT_SYSTEM.Models
{
    internal class SubjectsEnrolled
    {
        public int id { get; set; }
        public int enrollmentId { get; set; }
        public int subjectId { get; set; }

        public Enrollment enrollment { get; set; }
        public Subject subject { get; set; }
    }
}
