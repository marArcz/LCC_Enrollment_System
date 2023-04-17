using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCC_ENROLLMENT_SYSTEM.Migrations
{
    /// <inheritdoc />
    public partial class create_specialized_course : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "specializedCourseId",
                table: "Enrollments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SpecializedCourses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecializedCourses", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_specializedCourseId",
                table: "Enrollments",
                column: "specializedCourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_SpecializedCourses_specializedCourseId",
                table: "Enrollments",
                column: "specializedCourseId",
                principalTable: "SpecializedCourses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_SpecializedCourses_specializedCourseId",
                table: "Enrollments");

            migrationBuilder.DropTable(
                name: "SpecializedCourses");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_specializedCourseId",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "specializedCourseId",
                table: "Enrollments");
        }
    }
}
