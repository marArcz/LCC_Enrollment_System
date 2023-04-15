using LCC_ENROLLMENT_SYSTEM.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCC_ENROLLMENT_SYSTEM.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<GradeLevel> GradeLevels { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SubjectsEnrolled> SubjectsEnrolled { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Strand> Strands { get; set; }
        public DbSet<SchoolLevel> SchoolLevels { get; set; }
        public DbSet<SubjectGroup> SubjectGroups { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConfigurationManager.ConnectionStrings["mysql_connection"].ConnectionString,new MySqlServerVersion("10.4.25"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GradeLevel>().HasData(GetGradeLevels());
            modelBuilder.Entity<Track>().HasData(GetTracks());
        }

        private List<GradeLevel> GetGradeLevels()
        {
            int[] levels = {7,8,9,10,11,12};
            return Enumerable.Range(0, levels.Length)
                .Select(i => new GradeLevel()
                {
                    Id = i+1,
                    Level = levels[i],
                    Description = ""
                }).ToList();
        }
        private List<Track> GetTracks()
        {
            return new List<Track>()
            {
                new Track { Id=1, Name="Academic" },
                new Track { Id=2,Name="Technical Vocational Livelihood" },
                new Track { Id=3,Name="GAS" }
            };
        }

    }
}
