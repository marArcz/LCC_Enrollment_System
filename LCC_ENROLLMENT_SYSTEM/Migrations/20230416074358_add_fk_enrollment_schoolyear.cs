using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCC_ENROLLMENT_SYSTEM.Migrations
{
    /// <inheritdoc />
    public partial class add_fk_enrollment_schoolyear : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "schoolYearId",
                table: "Enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "shoolYearId",
                table: "Enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_schoolYearId",
                table: "Enrollments",
                column: "schoolYearId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_SchoolYears_schoolYearId",
                table: "Enrollments",
                column: "schoolYearId",
                principalTable: "SchoolYears",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_SchoolYears_schoolYearId",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_schoolYearId",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "schoolYearId",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "shoolYearId",
                table: "Enrollments");
        }
    }
}
