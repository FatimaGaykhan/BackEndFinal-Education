using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back_End_Final_Education.Migrations
{
    public partial class CreateCourseAndCourseStudentTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InstructorId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseImage_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseStudents_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudents_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "EndDate", "InstructorId", "Name", "Price", "Rating", "SoftDeleted", "StartDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2580), "Hello", new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Ux-Ui", 200m, 10, false, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2580), "Hello", new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Graphic", 300m, 15, false, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 2, new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2580), "Hello", new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Front-End", 100m, 10, false, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2590), "Hello", new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Editor", 400m, 20, false, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

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

            migrationBuilder.InsertData(
                table: "InstructorSocialMedias",
                columns: new[] { "Id", "CreatedDate", "InstructorId", "SocialLink", "SocialMediaId", "SoftDeleted" },
                values: new object[,]
                {
                    { 100, new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2460), 1, "https://www.instagram.com/angelinajolie?igsh=MWRtOGVqaHJ0YTM2bg==", 1, false },
                    { 101, new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2470), 1, "https://www.facebook.com", 2, false },
                    { 102, new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2470), 1, "https://x.com", 3, false },
                    { 103, new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2490), 2, "https://www.instagram.com/angelinajolie?igsh=MWRtOGVqaHJ0YTM2bg==", 1, false },
                    { 104, new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2490), 2, "https://www.facebook.com", 2, false },
                    { 105, new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2500), 2, "https://x.com", 3, false },
                    { 106, new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2500), 3, "https://www.instagram.com/angelinajolie?igsh=MWRtOGVqaHJ0YTM2bg==", 1, false },
                    { 107, new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2500), 3, "https://www.facebook.com", 2, false },
                    { 108, new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2500), 3, "https://x.com", 3, false },
                    { 109, new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2500), 4, "https://www.instagram.com/angelinajolie?igsh=MWRtOGVqaHJ0YTM2bg==", 1, false },
                    { 110, new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2510), 4, "https://www.facebook.com", 2, false },
                    { 111, new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2510), 4, "https://x.com", 3, false }
                });

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

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "Key", "Value" },
                values: new object[,]
                {
                    { 1000, "Address", "123 Street, New York, USA" },
                    { 1001, "Phone Number", "+012 345 67890" },
                    { 1002, "Email", "fatimaeg@code.edu.az" },
                    { 1003, "GetInTouch", "The contact form is currently inactive. Get a functional and working contact form with Ajax & PHP in a few minutes. Just copy and paste the files, add a little code and you're done. " },
                    { 1004, "Twitter", "https://x.com/ " },
                    { 1005, "Facebook", "https://www.facebook.com/?locale=az_AZ" },
                    { 1006, "Youtube", "https://www.youtube.com/ " },
                    { 1007, "Instagram", "https://www.instagram.com/" }
                });

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

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedDate", "Description", "FullName", "Image", "Profession", "SoftDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2530), "Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit diam amet diam et eos. Clita erat ipsum et lorem et sit.", "James Beaufort", "testimonial-1.jpg", "IT", false },
                    { 2, new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2530), "Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit diam amet diam et eos. Clita erat ipsum et lorem et sit.", "Lydia Beaufort", "testimonial-2.jpg", "Designer", false },
                    { 3, new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2530), "Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit diam amet diam et eos. Clita erat ipsum et lorem et sit.", "Max Beaufort", "testimonial-3.jpg", "SMM", false },
                    { 4, new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2530), "Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit diam amet diam et eos. Clita erat ipsum et lorem et sit.", "Ruby Beaufort", "testimonial-4.jpg", "Programmer", false }
                });

            migrationBuilder.InsertData(
                table: "CourseStudents",
                columns: new[] { "Id", "CourseId", "CreatedDate", "SoftDeleted", "StudentId" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2600), false, 1 },
                    { 2, 2, new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2600), false, 2 },
                    { 3, 2, new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2600), false, 3 },
                    { 4, 2, new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2610), false, 4 },
                    { 5, 1, new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2610), false, 1 },
                    { 6, 3, new DateTime(2024, 6, 9, 18, 39, 4, 488, DateTimeKind.Local).AddTicks(2610), false, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseImage_CourseId",
                table: "CourseImage",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CategoryId",
                table: "Courses",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_InstructorId",
                table: "Courses",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudents_CourseId",
                table: "CourseStudents",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudents_StudentId",
                table: "CourseStudents",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseImage");

            migrationBuilder.DropTable(
                name: "CourseStudents");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DeleteData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 13, 25, 48, 197, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 13, 25, 48, 197, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 13, 25, 48, 197, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 13, 25, 48, 197, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 13, 25, 48, 197, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 13, 25, 48, 197, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 13, 25, 48, 197, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 13, 25, 48, 197, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 13, 25, 48, 197, DateTimeKind.Local).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 13, 25, 48, 197, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 13, 25, 48, 197, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 13, 25, 48, 197, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 13, 25, 48, 197, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 13, 25, 48, 197, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 13, 25, 48, 197, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 13, 25, 48, 197, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 13, 25, 48, 197, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "Key", "Value" },
                values: new object[,]
                {
                    { 1, "Address", "123 Street, New York, USA" },
                    { 2, "Phone Number", "+012 345 67890" },
                    { 3, "Email", "fatimaeg@code.edu.az" },
                    { 4, "GetInTouch", "The contact form is currently inactive. Get a functional and working contact form with Ajax & PHP in a few minutes. Just copy and paste the files, add a little code and you're done. " }
                });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 13, 25, 48, 197, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 13, 25, 48, 197, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 13, 25, 48, 197, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 13, 25, 48, 197, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 13, 25, 48, 197, DateTimeKind.Local).AddTicks(1600));
        }
    }
}
