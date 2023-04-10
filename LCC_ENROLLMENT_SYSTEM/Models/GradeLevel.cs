using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCC_ENROLLMENT_SYSTEM.Models
{
    internal class GradeLevel
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public string Description { get; set; } = String.Empty;
    }
}
