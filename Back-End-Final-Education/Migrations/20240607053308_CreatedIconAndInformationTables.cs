using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back_End_Final_Education.Migrations
{
    public partial class CreatedIconAndInformationTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Icons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Icons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Informations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IconId = table.Column<int>(type: "int", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Informations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Informations_Icons_IconId",
                        column: x => x.IconId,
                        principalTable: "Icons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Icons",
                columns: new[] { "Id", "ClassName", "CreatedDate", "SoftDeleted" },
                values: new object[,]
                {
                    { 1, "fa fa-3x fa-graduation-cap", new DateTime(2024, 6, 7, 9, 33, 8, 219, DateTimeKind.Local).AddTicks(4660), false },
                    { 2, "fa fa - 3x fa - globe", new DateTime(2024, 6, 7, 9, 33, 8, 219, DateTimeKind.Local).AddTicks(4660), false },
                    { 3, "fa fa-3x fa-home", new DateTime(2024, 6, 7, 9, 33, 8, 219, DateTimeKind.Local).AddTicks(4660), false },
                    { 4, "fa fa-3x fa-book-open", new DateTime(2024, 6, 7, 9, 33, 8, 219, DateTimeKind.Local).AddTicks(4660), false }
                });

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

            migrationBuilder.InsertData(
                table: "Informations",
                columns: new[] { "Id", "CreatedDate", "Description", "IconId", "SoftDeleted", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 7, 9, 33, 8, 219, DateTimeKind.Local).AddTicks(4670), "Diam elitr kasd sed at elitr sed ipsum justo dolor sed clita amet diam", 1, false, "Skilled Instructors" },
                    { 2, new DateTime(2024, 6, 7, 9, 33, 8, 219, DateTimeKind.Local).AddTicks(4680), "Diam elitr kasd sed at elitr sed ipsum justo dolor sed clita amet diam", 2, false, "Online Classes" },
                    { 3, new DateTime(2024, 6, 7, 9, 33, 8, 219, DateTimeKind.Local).AddTicks(4680), "Diam elitr kasd sed at elitr sed ipsum justo dolor sed clita amet diam", 3, false, "Home Projects" },
                    { 4, new DateTime(2024, 6, 7, 9, 33, 8, 219, DateTimeKind.Local).AddTicks(4680), "Diam elitr kasd sed at elitr sed ipsum justo dolor sed clita amet diam", 4, false, "Book Library" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Informations_IconId",
                table: "Informations",
                column: "IconId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Informations");

            migrationBuilder.DropTable(
                name: "Icons");

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 6, 21, 14, 52, 815, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 6, 21, 14, 52, 815, DateTimeKind.Local).AddTicks(8810));
        }
    }
}
