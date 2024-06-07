using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back_End_Final_Education.Migrations
{
    public partial class CreateCategoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 20, 42, 39, 154, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Image", "Name", "SoftDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 7, 20, 42, 39, 154, DateTimeKind.Local).AddTicks(5870), "cat-1.jpg", "Web Design", false },
                    { 2, new DateTime(2024, 6, 7, 20, 42, 39, 154, DateTimeKind.Local).AddTicks(5870), "cat-2.jpg", "Graphic Design", false },
                    { 3, new DateTime(2024, 6, 7, 20, 42, 39, 154, DateTimeKind.Local).AddTicks(5880), "cat-3.jpg", "Video Editing", false },
                    { 4, new DateTime(2024, 6, 7, 20, 42, 39, 154, DateTimeKind.Local).AddTicks(5880), "cat-4.jpg", "Online Marketing", false }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 12, 42, 50, 491, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 12, 42, 50, 491, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 12, 42, 50, 491, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 12, 42, 50, 491, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 12, 42, 50, 491, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 12, 42, 50, 491, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 12, 42, 50, 491, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 12, 42, 50, 491, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 12, 42, 50, 491, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 12, 42, 50, 491, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 12, 42, 50, 491, DateTimeKind.Local).AddTicks(8780));
        }
    }
}
