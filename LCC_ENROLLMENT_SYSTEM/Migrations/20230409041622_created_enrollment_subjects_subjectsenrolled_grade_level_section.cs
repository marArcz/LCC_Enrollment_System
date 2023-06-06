using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCC_ENROLLMENT_SYSTEM.Migrations
{
    /// <inheritdoc />
    public partial class created_enrollment_subjects_subjectsenrolled_grade_level_section : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GradeLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradeLevels", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<int>(type: "int", nullable: false),
                    GradeLevelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    year_level = table.Column<int>(type: "int", nullable: false),
                    studentId = table.Column<int>(type: "int", nullable: false),
                    grade_level_id = table.Column<int>(type: "int", nullable: false),
                    section_id = table.Column<int>(type: "int", nullable: false),
                    sectionId = table.Column<int>(type: "int", nullable: true),
                    gradeLevelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => x.id);
                    table.ForeignKey(
                        name: "FK_Enrollments_GradeLevels_gradeLevelId",
                        column: x => x.gradeLevelId,
                        principalTable: "GradeLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollments_Sections_sectionId",
                        column: x => x.sectionId,
                        principalTable: "Sections",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Enrollments_Students_studentId",
                        column: x => x.studentId,
                        principalTable: "Students",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SubjectsEnrolled",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    enrollmentId = table.Column<int>(type: "int", nullable: false),
                    subjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectsEnrolled", x => x.id);
                    table.ForeignKey(
                        name: "FK_SubjectsEnrolled_Enrollments_enrollmentId",
                        column: x => x.enrollmentId,
                        principalTable: "Enrollments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubjectsEnrolled_Subjects_subjectId",
                        column: x => x.subjectId,
                        principalTable: "Subjects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_gradeLevelId",
                table: "Enrollments",
                column: "gradeLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_sectionId",
                table: "Enrollments",
                column: "sectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_studentId",
                table: "Enrollments",
                column: "studentId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectsEnrolled_enrollmentId",
                table: "SubjectsEnrolled",
                column: "enrollmentId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectsEnrolled_subjectId",
                table: "SubjectsEnrolled",
                column: "subjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubjectsEnrolled");

            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "GradeLevels");

            migrationBuilder.DropTable(
                name: "Sections");
        }
    }
}
