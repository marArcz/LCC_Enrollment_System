using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCC_ENROLLMENT_SYSTEM.Migrations
{
    /// <inheritdoc />
    public partial class remove_section_id_enrollment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Sections_sectionId",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_sectionId",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "sectionId",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "section_id",
                table: "Enrollments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "sectionId",
                table: "Enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "section_id",
                table: "Enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_sectionId",
                table: "Enrollments",
                column: "sectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Sections_sectionId",
                table: "Enrollments",
                column: "sectionId",
                principalTable: "Sections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
