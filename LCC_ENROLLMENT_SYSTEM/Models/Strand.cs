using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCC_ENROLLMENT_SYSTEM.Models
{
    internal class Strand
    {
        public int Id { get; set; }
        public int TrackId { get; set; }
        public string Name { get; set; }
        public Track TrackModel { get; set; }
    }
}
