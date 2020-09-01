using Microsoft.EntityFrameworkCore.Migrations;

namespace SoftwareProcess.Migrations
{
    public partial class Passwords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Students",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Students");
        }
    }
}
