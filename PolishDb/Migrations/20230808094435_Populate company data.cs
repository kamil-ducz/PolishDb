using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PolishDb.Migrations
{
    /// <inheritdoc />
    public partial class Populatecompanydata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CompanyCEOName", "CompanyName" },
                values: new object[,]
                {
                    { 1, "Jan Kowalski", "Firma herbata" },
                    { 2, "Anna Nowak", "Firma samochód" },
                    { 3, "Piotr Nowakowski", "Firma dom" },
                    { 4, "Alicja Wiśniewska", "Firma książka" },
                    { 5, "Marek Kaczmarek", "Firma rower" },
                    { 6, "Ewa Wojciechowska", "Firma stół" },
                    { 7, "Tomasz Malinowski", "Firma lampa" },
                    { 8, "Katarzyna Duda", "Firma komputer" },
                    { 9, "Bartosz Krawczyk", "Firma telefon" },
                    { 10, "Magdalena Pawlak", "Firma telewizor" },
                    { 11, "Wojciech Nowak", "Firma drzwi" },
                    { 12, "Zofia Szymańska", "Firma sofa" },
                    { 13, "Krzysztof Woźniak", "Firma kawa" },
                    { 14, "Elżbieta Kaczmarek", "Firma biurko" },
                    { 15, "Andrzej Kowalczyk", "Firma fotel" },
                    { 16, "Marta Wiśniewska", "Firma telewizja" },
                    { 17, "Paweł Nowak", "Firma woda" },
                    { 18, "Krystyna Szymańska", "Firma okno" },
                    { 19, "Michał Krawczyk", "Firma komoda" },
                    { 20, "Maria Malinowska", "Firma herbata" },
                    { 21, "Wojciech Nowak", "Firma sofa" },
                    { 22, "Zofia Szymańska", "Firma samochód" },
                    { 23, "Krzysztof Woźniak", "Firma drzwi" },
                    { 24, "Elżbieta Kaczmarek", "Firma biurko" },
                    { 25, "Andrzej Kowalczyk", "Firma komputer" },
                    { 26, "Marta Wiśniewska", "Firma kawa" },
                    { 27, "Paweł Nowak", "Firma dom" },
                    { 28, "Krystyna Szymańska", "Firma telefon" },
                    { 29, "Michał Krawczyk", "Firma rower" },
                    { 30, "Maria Malinowska", "Firma telewizor" },
                    { 31, "Wojciech Nowak", "Firma herbata" },
                    { 32, "Zofia Szymańska", "Firma stół" },
                    { 33, "Krzysztof Woźniak", "Firma książka" },
                    { 34, "Elżbieta Kaczmarek", "Firma lampa" },
                    { 35, "Andrzej Kowalczyk", "Firma komoda" },
                    { 36, "Marta Wiśniewska", "Firma telewizja" },
                    { 37, "Paweł Nowak", "Firma drzwi" },
                    { 38, "Krystyna Szymańska", "Firma samochód" },
                    { 39, "Michał Krawczyk", "Firma dom" },
                    { 40, "Maria Malinowska", "Firma biurko" },
                    { 41, "Wojciech Nowak", "Firma komputer" },
                    { 42, "Zofia Szymańska", "Firma telefon" },
                    { 43, "Krzysztof Woźniak", "Firma rower" },
                    { 44, "Elżbieta Kaczmarek", "Firma telewizor" },
                    { 45, "Andrzej Kowalczyk", "Firma stół" },
                    { 46, "Marta Wiśniewska", "Firma lampa" },
                    { 47, "Paweł Nowak", "Firma komoda" },
                    { 48, "Krystyna Szymańska", "Firma herbata" },
                    { 49, "Michał Krawczyk", "Firma sofa" },
                    { 50, "Maria Malinowska", "Firma samochód" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}
