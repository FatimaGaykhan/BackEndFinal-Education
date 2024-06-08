using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back_End_Final_Education.Migrations
{
    public partial class CreateInstructorAndSocialMediaAndPevotTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InstructorSocialMedias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstructorId = table.Column<int>(type: "int", nullable: false),
                    SocialMediaId = table.Column<int>(type: "int", nullable: false),
                    SocialLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstructorSocialMedias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstructorSocialMedias_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InstructorSocialMedias_SocialMedias_SocialMediaId",
                        column: x => x.SocialMediaId,
                        principalTable: "SocialMedias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                table: "Instructors",
                columns: new[] { "Id", "CreatedDate", "FullName", "Image", "Position", "SoftDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(550), "John Doe", "team-1.jpg", "Web Designer", false },
                    { 2, new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(550), "Angelina Jolie", "team-2.jpg", "Graphic Designer", false },
                    { 3, new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(550), "Jake Oliver", "team-3.jpg", "Video Editor", false },
                    { 4, new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(560), "Emily Prior", "team-4.jpg", "SMM Manager", false }
                });

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

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "Id", "CreatedDate", "Icon", "Name", "SoftDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(570), "fab fa-instagram", "Instagram", false },
                    { 2, new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(570), "fab fa-facebook-f", "Facebook", false },
                    { 3, new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(570), "fab fa-twitter", "Twitter", false }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_InstructorSocialMedias_InstructorId",
                table: "InstructorSocialMedias",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_InstructorSocialMedias_SocialMediaId",
                table: "InstructorSocialMedias",
                column: "SocialMediaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InstructorSocialMedias");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 20, 42, 39, 154, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 20, 42, 39, 154, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 20, 42, 39, 154, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 20, 42, 39, 154, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 20, 42, 39, 154, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 20, 42, 39, 154, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 20, 42, 39, 154, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 20, 42, 39, 154, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 20, 42, 39, 154, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 20, 42, 39, 154, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 20, 42, 39, 154, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 20, 42, 39, 154, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 20, 42, 39, 154, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 20, 42, 39, 154, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 20, 42, 39, 154, DateTimeKind.Local).AddTicks(5770));
        }
    }
}
