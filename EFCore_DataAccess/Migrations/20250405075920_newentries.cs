using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCore_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class newentries : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Phone",
                columns: new[] { "Id", "CompanyFullName", "PhoneModel", "Price" },
                values: new object[,]
                {
                    { 3, "Apple", "iPhone 14", 1000m },
                    { 4, "Nokia", "Nokia 3310", 500m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
