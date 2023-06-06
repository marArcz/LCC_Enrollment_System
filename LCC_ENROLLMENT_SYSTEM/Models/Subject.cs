using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCC_ENROLLMENT_SYSTEM.Models
{
    public  class Subject
    {
        public int id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string From { get; set; }
        public string To { get; set; }
        public String Days { get; set; }
        public int Level { get; set; }

        public List<SubjectGroup> subjectGroups { get; set; }
    }
}
