using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back_End_Final_Education.Migrations
{
    public partial class CreateStudentsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Profession = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedDate", "Description", "FullName", "Image", "Profession", "SoftDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4720), "Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit diam amet diam et eos. Clita erat ipsum et lorem et sit.", "James Beaufort", "testimonial-1.jpg", "IT", false },
                    { 2, new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4720), "Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit diam amet diam et eos. Clita erat ipsum et lorem et sit.", "Lydia Beaufort", "testimonial-2.jpg", "Designer", false },
                    { 3, new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4720), "Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit diam amet diam et eos. Clita erat ipsum et lorem et sit.", "Max Beaufort", "testimonial-3.jpg", "SMM", false },
                    { 4, new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4720), "Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit diam amet diam et eos. Clita erat ipsum et lorem et sit.", "Ruby Beaufort", "testimonial-4.jpg", "Programmer", false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.InsertData(
                table: "InstructorSocialMedias",
                columns: new[] { "Id", "CreatedDate", "InstructorId", "SocialLink", "SocialMediaId", "SoftDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(580), 1, "https://www.instagram.com/angelinajolie?igsh=MWRtOGVqaHJ0YTM2bg==", 1, false },
                    { 2, new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(580), 1, "https://www.facebook.com", 2, false },
                    { 3, new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(580), 1, "https://x.com", 3, false },
                    { 4, new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(590), 2, "https://www.instagram.com/angelinajolie?igsh=MWRtOGVqaHJ0YTM2bg==", 1, false },
                    { 5, new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(590), 2, "https://www.facebook.com", 2, false },
                    { 6, new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(590), 2, "https://x.com", 3, false },
                    { 7, new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(590), 3, "https://www.instagram.com/angelinajolie?igsh=MWRtOGVqaHJ0YTM2bg==", 1, false },
                    { 8, new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(600), 3, "https://www.facebook.com", 2, false },
                    { 9, new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(600), 3, "https://x.com", 3, false }
                });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(570));
        }
    }
}
