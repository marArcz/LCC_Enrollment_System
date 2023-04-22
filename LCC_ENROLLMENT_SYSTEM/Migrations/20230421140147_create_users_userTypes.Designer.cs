﻿// <auto-generated />
using System;
using LCC_ENROLLMENT_SYSTEM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LCC_ENROLLMENT_SYSTEM.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230421140147_create_users_userTypes")]
    partial class create_users_userTypes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LCC_ENROLLMENT_SYSTEM.Models.Admin", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("fullname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            id = 1,
                            email = "admin@gmail.com",
                            fullname = "admin",
                            password = "admin",
                            username = "admin"
                        });
                });

            modelBuilder.Entity("LCC_ENROLLMENT_SYSTEM.Models.Enrollment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("gradeLevelId")
                        .HasColumnType("int");

                    b.Property<int>("schoolLevelId")
                        .HasColumnType("int");

                    b.Property<int>("schoolYearId")
                        .HasColumnType("int");

                    b.Property<int>("sectionId")
                        .HasColumnType("int");

                    b.Property<int?>("specializedCourseId")
                        .HasColumnType("int");

                    b.Property<int?>("strandId")
                        .HasColumnType("int");

                    b.Property<int>("studentId")
                        .HasColumnType("int");

                    b.Property<int?>("trackId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("gradeLevelId");

                    b.HasIndex("schoolLevelId");

                    b.HasIndex("schoolYearId");

                    b.HasIndex("sectionId");

                    b.HasIndex("specializedCourseId");

                    b.HasIndex("strandId");

                    b.HasIndex("studentId");

                    b.HasIndex("trackId");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("LCC_ENROLLMENT_SYSTEM.Models.GradeLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GradeLevels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "",
                            Level = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            Level = 2
                        },
                        new
                        {
                            Id = 3,
                            Description = "",
                            Level = 3
                        },
                        new
                        {
                            Id = 4,
                            Description = "",
                            Level = 4
                        },
                        new
                        {
                            Id = 5,
                            Description = "",
                            Level = 5
                        },
                        new
                        {
                            Id = 6,
                            Description = "",
                            Level = 6
                        },
                        new
                        {
                            Id = 7,
                            Description = "",
                            Level = 7
                        },
                        new
                        {
                            Id = 8,
                            Description = "",
                            Level = 8
                        },
                        new
                        {
                            Id = 9,
                            Description = "",
                            Level = 9
                        },
                        new
                        {
                            Id = 10,
                            Description = "",
                            Level = 10
                        },
                        new
                        {
                            Id = 11,
                            Description = "",
                            Level = 11
                        },
                        new
                        {
                            Id = 12,
                            Description = "",
                            Level = 12
                        });
                });

            modelBuilder.Entity("LCC_ENROLLMENT_SYSTEM.Models.SchoolLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("SchoolLevels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Elementary"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Junior Highschool"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Senior Highschool"
                        });
                });

            modelBuilder.Entity("LCC_ENROLLMENT_SYSTEM.Models.SchoolYear", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("From")
                        .HasColumnType("int");

                    b.Property<int>("To")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SchoolYears");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            From = 2022,
                            To = 2023
                        });
                });

            modelBuilder.Entity("LCC_ENROLLMENT_SYSTEM.Models.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("GradeLevelId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("GradeLevelId");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("LCC_ENROLLMENT_SYSTEM.Models.SpecializedCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("SpecializedCourses");
                });

            modelBuilder.Entity("LCC_ENROLLMENT_SYSTEM.Models.Strand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("TrackId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TrackId");

                    b.ToTable("Strands");
                });

            modelBuilder.Entity("LCC_ENROLLMENT_SYSTEM.Models.Student", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<DateOnly>("birth_date")
                        .HasColumnType("date");

                    b.Property<string>("birth_place")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("created_at")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("firstname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("guardian")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("guardian_address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("guardian_phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("has_birth_certificate")
                        .HasColumnType("int");

                    b.Property<int>("has_certification")
                        .HasColumnType("int");

                    b.Property<int>("has_good_moral")
                        .HasColumnType("int");

                    b.Property<int>("has_id_picture")
                        .HasColumnType("int");

                    b.Property<int>("has_report_card")
                        .HasColumnType("int");

                    b.Property<string>("height")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("is_deleted")
                        .HasColumnType("int");

                    b.Property<string>("last_school_attended")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("last_school_year")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("lastname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("middlename")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("sex")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("student_id")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("weight")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("year_added")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("LCC_ENROLLMENT_SYSTEM.Models.Subject", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("LCC_ENROLLMENT_SYSTEM.Models.SubjectGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("SubjectGroups");
                });

            modelBuilder.Entity("LCC_ENROLLMENT_SYSTEM.Models.SubjectsEnrolled", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("enrollmentId")
                        .HasColumnType("int");

                    b.Property<int>("subjectId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("enrollmentId");

                    b.HasIndex("subjectId");

                    b.ToTable("SubjectsEnrolled");
                });

            modelBuilder.Entity("LCC_ENROLLMENT_SYSTEM.Models.Track", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Tracks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Academic"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Technical Vocational Livelihood"
                        },
                        new
                        {
                            Id = 3,
                            Name = "GAS"
                        });
                });

            modelBuilder.Entity("LCC_ENROLLMENT_SYSTEM.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LCC_ENROLLMENT_SYSTEM.Models.UserType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("UserTypes");
                });

            modelBuilder.Entity("LCC_ENROLLMENT_SYSTEM.Models.Enrollment", b =>
                {
                    b.HasOne("LCC_ENROLLMENT_SYSTEM.Models.GradeLevel", "gradeLevel")
                        .WithMany()
                        .HasForeignKey("gradeLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LCC_ENROLLMENT_SYSTEM.Models.SchoolLevel", "schoolLevel")
                        .WithMany()
                        .HasForeignKey("schoolLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LCC_ENROLLMENT_SYSTEM.Models.SchoolYear", "schoolYear")
                        .WithMany()
                        .HasForeignKey("schoolYearId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LCC_ENROLLMENT_SYSTEM.Models.Section", "section")
                        .WithMany()
                        .HasForeignKey("sectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LCC_ENROLLMENT_SYSTEM.Models.SpecializedCourse", "specializedCourse")
                        .WithMany()
                        .HasForeignKey("specializedCourseId");

                    b.HasOne("LCC_ENROLLMENT_SYSTEM.Models.Strand", "StrandModel")
                        .WithMany()
                        .HasForeignKey("strandId");

                    b.HasOne("LCC_ENROLLMENT_SYSTEM.Models.Student", "student")
                        .WithMany()
                        .HasForeignKey("studentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LCC_ENROLLMENT_SYSTEM.Models.Track", "TrackModel")
                        .WithMany()
                        .HasForeignKey("trackId");

                    b.Navigation("StrandModel");

                    b.Navigation("TrackModel");

                    b.Navigation("gradeLevel");

                    b.Navigation("schoolLevel");

                    b.Navigation("schoolYear");

                    b.Navigation("section");

                    b.Navigation("specializedCourse");

                    b.Navigation("student");
                });

            modelBuilder.Entity("LCC_ENROLLMENT_SYSTEM.Models.Section", b =>
                {
                    b.HasOne("LCC_ENROLLMENT_SYSTEM.Models.GradeLevel", "gradeLevel")
                        .WithMany()
                        .HasForeignKey("GradeLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("gradeLevel");
                });

            modelBuilder.Entity("LCC_ENROLLMENT_SYSTEM.Models.Strand", b =>
                {
                    b.HasOne("LCC_ENROLLMENT_SYSTEM.Models.Track", "TrackModel")
                        .WithMany()
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TrackModel");
                });

            modelBuilder.Entity("LCC_ENROLLMENT_SYSTEM.Models.SubjectGroup", b =>
                {
                    b.HasOne("LCC_ENROLLMENT_SYSTEM.Models.Subject", "SubjectModel")
                        .WithMany("subjectGroups")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SubjectModel");
                });

            modelBuilder.Entity("LCC_ENROLLMENT_SYSTEM.Models.SubjectsEnrolled", b =>
                {
                    b.HasOne("LCC_ENROLLMENT_SYSTEM.Models.Enrollment", "enrollment")
                        .WithMany()
                        .HasForeignKey("enrollmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LCC_ENROLLMENT_SYSTEM.Models.Subject", "subject")
                        .WithMany()
                        .HasForeignKey("subjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("enrollment");

                    b.Navigation("subject");
                });

            modelBuilder.Entity("LCC_ENROLLMENT_SYSTEM.Models.User", b =>
                {
                    b.HasOne("LCC_ENROLLMENT_SYSTEM.Models.UserType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type");
                });

            modelBuilder.Entity("LCC_ENROLLMENT_SYSTEM.Models.Subject", b =>
                {
                    b.Navigation("subjectGroups");
                });
#pragma warning restore 612, 618
        }
    }
}
