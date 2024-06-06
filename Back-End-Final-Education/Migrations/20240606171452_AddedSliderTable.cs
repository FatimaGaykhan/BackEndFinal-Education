using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back_End_Final_Education.Migrations
{
    public partial class AddedSliderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "CreatedDate", "Description", "Image", "SoftDeleted", "Subject", "Title" },
                values: new object[] { 1, new DateTime(2024, 6, 6, 21, 14, 52, 815, DateTimeKind.Local).AddTicks(8800), "Vero elitr justo clita lorem. Ipsum dolor at sed stet sit diam no. Kasd rebum ipsum et diam justo clita et kasd rebum sea sanctus eirmod elitr.", "carousel-1.jpg", false, "Best Online Courses", "The Best Online Learning Platform" });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "CreatedDate", "Description", "Image", "SoftDeleted", "Subject", "Title" },
                values: new object[] { 2, new DateTime(2024, 6, 6, 21, 14, 52, 815, DateTimeKind.Local).AddTicks(8810), "Vero elitr justo clita lorem. Ipsum dolor at sed stet sit diam no. Kasd rebum ipsum et diam justo clita et kasd rebum sea sanctus eirmod elitr.", "carousel-2.jpg", false, "Best Online Courses", "Get Educated Online From Your Home" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sliders");
        }
    }
}
