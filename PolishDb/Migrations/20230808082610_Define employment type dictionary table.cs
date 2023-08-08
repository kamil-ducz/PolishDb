using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PolishDb.Migrations
{
    /// <inheritdoc />
    public partial class Defineemploymenttypedictionarytable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "MandateContract" },
                    { 2, "ContractOfEmployment" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employments",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
