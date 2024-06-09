using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back_End_Final_Education.Migrations
{
    public partial class CreateCourseImagesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseImage_Courses_CourseId",
                table: "CourseImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseImage",
                table: "CourseImage");

            migrationBuilder.RenameTable(
                name: "CourseImage",
                newName: "CourseImages");

            migrationBuilder.RenameIndex(
                name: "IX_CourseImage_CourseId",
                table: "CourseImages",
                newName: "IX_CourseImages_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseImages",
                table: "CourseImages",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.InsertData(
                table: "CourseImages",
                columns: new[] { "Id", "CourseId", "IsMain", "Name" },
                values: new object[,]
                {
                    { 1, 1, true, "course-1.jpg" },
                    { 2, 1, false, "course-2.jpg" },
                    { 3, 2, false, "course-3.jpg" },
                    { 4, 2, true, "course-1.jpg" },
                    { 5, 3, false, "course-2.jpg" },
                    { 6, 3, true, "course-1.jpg" },
                    { 7, 4, true, "course-1.jpg" },
                    { 8, 4, false, "course-2.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "CourseStudents",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "CourseStudents",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "CourseStudents",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "CourseStudents",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "CourseStudents",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "CourseStudents",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 53, 13, 757, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.AddForeignKey(
                name: "FK_CourseImages_Courses_CourseId",
                table: "CourseImages",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseImages_Courses_CourseId",
                table: "CourseImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseImages",
                table: "CourseImages");

            migrationBuilder.DeleteData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.RenameTable(
                name: "CourseImages",
                newName: "CourseImage");

            migrationBuilder.RenameIndex(
                name: "IX_CourseImages_CourseId",
                table: "CourseImage",
                newName: "IX_CourseImage_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseImage",
                table: "CourseImage",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "CourseStudents",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "CourseStudents",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "CourseStudents",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "CourseStudents",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "CourseStudents",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "CourseStudents",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.AddForeignKey(
                name: "FK_CourseImage_Courses_CourseId",
                table: "CourseImage",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
