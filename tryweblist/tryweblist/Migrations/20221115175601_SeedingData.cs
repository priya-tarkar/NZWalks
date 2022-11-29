using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tryweblist.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "DisplayOrder", "Title" },
                values: new object[] { 1, new DateTime(2022, 11, 15, 23, 26, 1, 283, DateTimeKind.Local).AddTicks(2803), 1, "priya" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "DisplayOrder", "Title" },
                values: new object[] { 2, new DateTime(2022, 11, 15, 23, 26, 1, 283, DateTimeKind.Local).AddTicks(2822), 2, "tarkar" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
