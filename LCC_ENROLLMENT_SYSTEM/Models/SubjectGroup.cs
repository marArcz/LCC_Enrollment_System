using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCC_ENROLLMENT_SYSTEM.Models
{
    public class SubjectGroup
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public Subject SubjectModel { get; set; }
        public int Level { get; set; }
    }
}
