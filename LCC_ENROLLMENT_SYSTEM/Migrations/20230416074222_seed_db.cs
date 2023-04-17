using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LCC_ENROLLMENT_SYSTEM.Migrations
{
    /// <inheritdoc />
    public partial class seed_db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SchoolYears",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    From = table.Column<int>(type: "int", nullable: false),
                    To = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolYears", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "id", "email", "fullname", "password", "username" },
                values: new object[] { 1, "admin@gmail.com", "admin", "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "GradeLevels",
                keyColumn: "Id",
                keyValue: 1,
                column: "Level",
                value: 1);

            migrationBuilder.UpdateData(
                table: "GradeLevels",
                keyColumn: "Id",
                keyValue: 2,
                column: "Level",
                value: 2);

            migrationBuilder.UpdateData(
                table: "GradeLevels",
                keyColumn: "Id",
                keyValue: 3,
                column: "Level",
                value: 3);

            migrationBuilder.UpdateData(
                table: "GradeLevels",
                keyColumn: "Id",
                keyValue: 4,
                column: "Level",
                value: 4);

            migrationBuilder.UpdateData(
                table: "GradeLevels",
                keyColumn: "Id",
                keyValue: 5,
                column: "Level",
                value: 5);

            migrationBuilder.UpdateData(
                table: "GradeLevels",
                keyColumn: "Id",
                keyValue: 6,
                column: "Level",
                value: 6);

            migrationBuilder.InsertData(
                table: "GradeLevels",
                columns: new[] { "Id", "Description", "Level" },
                values: new object[,]
                {
                    { 7, "", 7 },
                    { 8, "", 8 },
                    { 9, "", 9 },
                    { 10, "", 10 },
                    { 11, "", 11 },
                    { 12, "", 12 }
                });

            migrationBuilder.InsertData(
                table: "SchoolYears",
                columns: new[] { "Id", "From", "To" },
                values: new object[] { 1, 2022, 2023 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SchoolYears");

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GradeLevels",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "GradeLevels",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "GradeLevels",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "GradeLevels",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "GradeLevels",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "GradeLevels",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "GradeLevels",
                keyColumn: "Id",
                keyValue: 1,
                column: "Level",
                value: 7);

            migrationBuilder.UpdateData(
                table: "GradeLevels",
                keyColumn: "Id",
                keyValue: 2,
                column: "Level",
                value: 8);

            migrationBuilder.UpdateData(
                table: "GradeLevels",
                keyColumn: "Id",
                keyValue: 3,
                column: "Level",
                value: 9);

            migrationBuilder.UpdateData(
                table: "GradeLevels",
                keyColumn: "Id",
                keyValue: 4,
                column: "Level",
                value: 10);

            migrationBuilder.UpdateData(
                table: "GradeLevels",
                keyColumn: "Id",
                keyValue: 5,
                column: "Level",
                value: 11);

            migrationBuilder.UpdateData(
                table: "GradeLevels",
                keyColumn: "Id",
                keyValue: 6,
                column: "Level",
                value: 12);
        }
    }
}
