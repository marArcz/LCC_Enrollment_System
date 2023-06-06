using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCC_ENROLLMENT_SYSTEM.Migrations
{
    /// <inheritdoc />
    public partial class section_grade_level_relation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Sections_GradeLevelId",
                table: "Sections",
                column: "GradeLevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_GradeLevels_GradeLevelId",
                table: "Sections",
                column: "GradeLevelId",
                principalTable: "GradeLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sections_GradeLevels_GradeLevelId",
                table: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_Sections_GradeLevelId",
                table: "Sections");
        }
    }
}
