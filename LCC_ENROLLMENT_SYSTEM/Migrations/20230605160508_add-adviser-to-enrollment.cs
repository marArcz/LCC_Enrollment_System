using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCC_ENROLLMENT_SYSTEM.Migrations
{
    /// <inheritdoc />
    public partial class addadvisertoenrollment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "adviserId",
                table: "Enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_adviserId",
                table: "Enrollments",
                column: "adviserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Advisers_adviserId",
                table: "Enrollments",
                column: "adviserId",
                principalTable: "Advisers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Advisers_adviserId",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_adviserId",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "adviserId",
                table: "Enrollments");
        }
    }
}
