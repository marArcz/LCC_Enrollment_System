using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCC_ENROLLMENT_SYSTEM.Models
{
    internal class Admin
    {
        public int id { get; set; }
        [Required]
        public string fullname { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
