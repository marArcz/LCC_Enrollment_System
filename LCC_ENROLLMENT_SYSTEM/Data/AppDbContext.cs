using LCC_ENROLLMENT_SYSTEM.Models;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.IsisMtt.X509;
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
        public DbSet<SpecializedCourse> SpecializedCourses { get; set; }
        public DbSet<SchoolLevel> SchoolLevels { get; set; }
        public DbSet<SubjectGroup> SubjectGroups { get; set; }
        public DbSet<SchoolYear> SchoolYears { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Adviser> Advisers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConfigurationManager.ConnectionStrings["mysql_connection"].ConnectionString,new MySqlServerVersion("10.4.25"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User() { Id=1, FullName = "Admin",Username = "admin", Password="admin"}
            );
            modelBuilder.Entity<GradeLevel>().HasData(GetGradeLevels());
            modelBuilder.Entity<Track>().HasData(GetTracks());
            modelBuilder.Entity<SchoolYear>().HasData(GetSchoolYears());
            modelBuilder.Entity<SchoolLevel>().HasData(GetSchoolLevels());
        }

        private List<GradeLevel> GetGradeLevels()
        {
            return Enumerable.Range(0, 12)
                .Select(i => new GradeLevel()
                {
                    Id = i+1,
                    Level = i+1,
                    Description = ""
                }).ToList();
        }
        private List<Track> GetTracks()
        {
            return new List<Track>()
            {
                new Track { Id=1, Name="Academic" },
                new Track { Id=2, Name="Technical Vocational Livelihood" },
                new Track { Id=3, Name="GAS" }
            };
        }  private List<SchoolYear> GetSchoolYears()
        {
            return new List<SchoolYear>()
            {
                new SchoolYear(){ Id=1, From=2022,To=2023 },
            };
        }

        private List<SchoolLevel> GetSchoolLevels()
        {
            return new List<SchoolLevel>()
            {
                new SchoolLevel(){ Id=1,Description="Elementary" },
                new SchoolLevel(){ Id=2,Description="Junior Highschool" },
                new SchoolLevel(){ Id=3,Description="Senior Highschool" },
            };
        }


    }
}
