using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class annotations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Phone",
                table: "Phone");

            migrationBuilder.RenameTable(
                name: "Phone",
                newName: "Tbl_Phone");

            migrationBuilder.RenameColumn(
                name: "PhoneModel",
                table: "Tbl_Phone",
                newName: "PhoneName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tbl_Phone",
                newName: "PhoneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tbl_Phone",
                table: "Tbl_Phone",
                column: "PhoneId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tbl_Phone",
                table: "Tbl_Phone");

            migrationBuilder.RenameTable(
                name: "Tbl_Phone",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "PhoneName",
                table: "Phone",
                newName: "PhoneModel");

            migrationBuilder.RenameColumn(
                name: "PhoneId",
                table: "Phone",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Phone",
                table: "Phone",
                column: "Id");
        }
    }
}
