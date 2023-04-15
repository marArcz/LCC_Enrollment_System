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
        public int studentId { get; set; }
        public int sectionId { get; set; }
        public int? trackId { get; set; }
        public int? strandId { get; set; }
        public int gradeLevelId { get; set; }
        public int schoolLevelId { get; set; }
        public SchoolLevel schoolLevel { get; set; }
        public GradeLevel gradeLevel { get; set; }
        public Strand? StrandModel { get; set; }
        public Track? TrackModel  { get; set; }
        public Student student { get; set; }
        public Section section { get; set; }

        public List<SubjectsEnrolled> subjectsEnrolled;

    }
}
