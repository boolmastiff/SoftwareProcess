using Microsoft.EntityFrameworkCore.Migrations;

namespace SoftwareProcess.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ID_number",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "Institution",
                table: "Students",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Institution",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "ID_number",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
