using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCC_ENROLLMENT_SYSTEM.Models
{
    internal class Student
    {
        public int id { get; set; }
        [Required]
        public string student_id { get; set; } = String.Empty;
        public string firstname { get; set; } = String.Empty;
        public string middlename { get; set; } = String.Empty;
        public string lastname { get; set; } = String.Empty;
        public string address { get; set; } = String.Empty;
        public string birth_place { get; set; } = String.Empty;
        public DateOnly birth_date { get; set; }
        public int age { get; set; }
        public string sex { get; set; } = String.Empty;
        public string weight { get; set; } = String.Empty;
        public string height { get; set; } = String.Empty;
        public string guardian { get; set; } = String.Empty;
        public string guardian_address { get; set; } = String.Empty;
        public string guardian_phone { get; set; } = String.Empty;
        public string last_school_attended { get; set; } = String.Empty;
        public string last_school_year { get; set; } = String.Empty;
        public int has_report_card { get; set; }
        public int has_birth_certificate { get; set; }
        public int has_id_picture { get; set; }
        public int has_certification { get; set; }
        public int has_good_moral { get; set; }
        public int is_deleted { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime created_at { get; set; }
        public int year_added { get; set; }

        public override string? ToString()
        {
            return $"{this.lastname}, {this.firstname} {this.middlename}";
        }
    }
}
