using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCC_ENROLLMENT_SYSTEM.Migrations
{
    /// <inheritdoc />
    public partial class update_enrollment_model : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "gradeLevelId",
                table: "Enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "schoolLevelId",
                table: "Enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "strandId",
                table: "Enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "trackId",
                table: "Enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_gradeLevelId",
                table: "Enrollments",
                column: "gradeLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_schoolLevelId",
                table: "Enrollments",
                column: "schoolLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_strandId",
                table: "Enrollments",
                column: "strandId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_trackId",
                table: "Enrollments",
                column: "trackId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_GradeLevels_gradeLevelId",
                table: "Enrollments",
                column: "gradeLevelId",
                principalTable: "GradeLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_SchoolLevels_schoolLevelId",
                table: "Enrollments",
                column: "schoolLevelId",
                principalTable: "SchoolLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Strands_strandId",
                table: "Enrollments",
                column: "strandId",
                principalTable: "Strands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Tracks_trackId",
                table: "Enrollments",
                column: "trackId",
                principalTable: "Tracks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_GradeLevels_gradeLevelId",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_SchoolLevels_schoolLevelId",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Strands_strandId",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Tracks_trackId",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_gradeLevelId",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_schoolLevelId",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_strandId",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_trackId",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "gradeLevelId",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "schoolLevelId",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "strandId",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "trackId",
                table: "Enrollments");
        }
    }
}
