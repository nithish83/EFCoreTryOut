using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class newentry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Phone",
                columns: new[] { "Id", "CompanyFullName", "PhoneModel", "Price" },
                values: new object[] { 1, "Samsung", "Samsung S24", 3500m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
