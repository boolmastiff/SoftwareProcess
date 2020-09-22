using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SoftwareProcess.Migrations
{
    public partial class CoursesAndClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "First_Name",
                table: "LectureAdmins",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "LectureAdmins",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseID = table.Column<int>(nullable: true),
                    Start_DateTime = table.Column<DateTime>(nullable: false),
                    Duration = table.Column<float>(nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(nullable: false),
                    Programme_Code = table.Column<string>(nullable: true),
                    Programme_Version_Description = table.Column<string>(nullable: true),
                    Intake_Code = table.Column<string>(nullable: true),
                    Ministry_Code = table.Column<string>(nullable: true),
                    ProgPoints = table.Column<int>(nullable: false),
                    Owner_Faculty = table.Column<string>(nullable: true),
                    ProgLevel = table.Column<string>(nullable: true),
                    Programme_EFTS = table.Column<int>(nullable: false),
                    Module_Code = table.Column<string>(nullable: true),
                    Module_Description = table.Column<string>(nullable: true),
                    Level = table.Column<string>(nullable: true),
                    Module_Credits = table.Column<int>(nullable: false),
                    Module_EFTS = table.Column<float>(nullable: false),
                    TSC_Category = table.Column<string>(nullable: true),
                    Funding_Classification = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropColumn(
                name: "First_Name",
                table: "LectureAdmins");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "LectureAdmins");
        }
    }
}
