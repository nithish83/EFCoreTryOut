using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Phone",
                columns: new[] { "Id", "CompanyFullName", "PhoneModel", "Price" },
                values: new object[] { 2, "MI", "MIPhone2345", 4500m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
