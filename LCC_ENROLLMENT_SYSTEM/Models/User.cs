using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCC_ENROLLMENT_SYSTEM.Models
{
    internal class User
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; } = String.Empty;
        [Required]
        public string Username { get; set; } = String.Empty;
        [Required]
        public string Password { get; set; } = String.Empty;
    }
}
