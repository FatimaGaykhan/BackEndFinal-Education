using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back_End_Final_Education.Migrations
{
    public partial class CreateAboutTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Abouts",
                columns: new[] { "Id", "CreatedDate", "Description", "Image", "SoftDeleted", "Title" },
                values: new object[] { 1, new DateTime(2024, 6, 7, 12, 42, 50, 491, DateTimeKind.Local).AddTicks(8890), "Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit. Aliqu diam amet diam et eos. Clita erat ipsum et lorem et sit.Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit. Aliqu diam amet diam et eos. Clita erat ipsum et lorem et sit, sed stet lorem sit clita duo justo magna dolore erat amet", "about.jpg", false, "Welcome to eLEARNING" });

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
                columns: new[] { "ClassName", "CreatedDate" },
                values: new object[] { "fa fa-3x fa-globe", new DateTime(2024, 6, 7, 12, 42, 50, 491, DateTimeKind.Local).AddTicks(8850) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 9, 33, 8, 219, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClassName", "CreatedDate" },
                values: new object[] { "fa fa - 3x fa - globe", new DateTime(2024, 6, 7, 9, 33, 8, 219, DateTimeKind.Local).AddTicks(4660) });

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 9, 33, 8, 219, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 9, 33, 8, 219, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 9, 33, 8, 219, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 9, 33, 8, 219, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 9, 33, 8, 219, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 9, 33, 8, 219, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 9, 33, 8, 219, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 9, 33, 8, 219, DateTimeKind.Local).AddTicks(4600));
        }
    }
}
