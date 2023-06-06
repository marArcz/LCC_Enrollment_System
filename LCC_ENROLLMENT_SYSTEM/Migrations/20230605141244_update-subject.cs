using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCC_ENROLLMENT_SYSTEM.Migrations
{
    /// <inheritdoc />
    public partial class updatesubject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Subjects"
                );

            migrationBuilder.AddColumn<string>(
                name: "Days",
                table: "Subjects",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
               name: "To",
               table: "Subjects",
               type: "longtext",
               nullable: false)
               .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "From",
                table: "Subjects",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Days",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "From",
                table: "Subjects");

            migrationBuilder.RenameColumn(
                name: "To",
                table: "Subjects",
                newName: "Description");
        }
    }
}
