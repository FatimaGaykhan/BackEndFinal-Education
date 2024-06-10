using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back_End_Final_Education.Migrations
{
    public partial class CreateContactTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "CourseStudents",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "CourseStudents",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "CourseStudents",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "CourseStudents",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "CourseStudents",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "CourseStudents",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 1, 43, 33, 207, DateTimeKind.Local).AddTicks(2320));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "CourseStudents",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "CourseStudents",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "CourseStudents",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "CourseStudents",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "CourseStudents",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "CourseStudents",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 10, 0, 29, 26, 635, DateTimeKind.Local).AddTicks(5220));
        }
    }
}
