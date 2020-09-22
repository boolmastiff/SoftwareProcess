using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SoftwareProcess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LectureAdmins",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    DOB = table.Column<DateTime>(nullable: false),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LectureAdmins", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    First_name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    ID_number = table.Column<int>(nullable: false),
                    Department = table.Column<string>(nullable: true),
                    Email_address = table.Column<string>(nullable: true),
                    LDFTC = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LectureAdmins");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
