using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCC_ENROLLMENT_SYSTEM.Migrations
{
    /// <inheritdoc />
    public partial class updates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_GradeLevels_gradeLevelId",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_gradeLevelId",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "Tracks",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "gradeLevelId",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "grade_level_id",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "year_level",
                table: "Enrollments");

            migrationBuilder.CreateTable(
                name: "SchoolLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolLevels", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SchoolLevels");

            migrationBuilder.AddColumn<string>(
                name: "Tracks",
                table: "Enrollments",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "gradeLevelId",
                table: "Enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "grade_level_id",
                table: "Enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "year_level",
                table: "Enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_gradeLevelId",
                table: "Enrollments",
                column: "gradeLevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_GradeLevels_gradeLevelId",
                table: "Enrollments",
                column: "gradeLevelId",
                principalTable: "GradeLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
