using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PolishDb.Migrations
{
    /// <inheritdoc />
    public partial class Fixduplicatesincompaniesseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 20,
                column: "CompanyName",
                value: "Firma słonik");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Wojciech Wójcik", "Firma strych" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Zofia Zaręba", "Firma ogień" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Krzysztof Król", "Firma dach" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Elżbieta Borkowska", "Firma klucz" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Andrzej Adamczyk", "Firma ręka" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Marta Majewska", "Firma serce" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Paweł Piotrowski", "Firma drzewo" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Krystyna Krawczyk", "Firma piasek" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Michał Majewski", "Firma księżyc" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Maria Nowak", "Firma wiatr" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Wojciech Szymański", "Firma słońce" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Zofia Wojciechowska", "Firma góra" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Krzysztof Malinowski", "Firma morze" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Elżbieta Kowalczyk", "Firma chmura" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Andrzej Wojcik", "Firma deszcz" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Marta Malinowska", "Firma ptak" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Paweł Krawczyk", "Firma ryba" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Krystyna Nowak", "Firma kawa" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Michał Szymański", "Firma herbata" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Maria Wojciechowska", "Firma samochód" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Wojciech Malinowski", "Firma chata" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Zofia Kowalczyk", "Firma książka" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 43,
                column: "CompanyCEOName",
                value: "Krzysztof Wojcik");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Elżbieta Malinowska", "Firma plazma" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Andrzej Krawczyk", "Firma lampa" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Marta Nowak", "Firma komputer" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Paweł Szymański", "Firma telefon" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Krystyna Wojciechowska", "Firma telewizja" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Michał Malinowski", "Firma komoda" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Maria Krawczyk", "Firma porcelana" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 20,
                column: "CompanyName",
                value: "Firma herbata");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Wojciech Nowak", "Firma sofa" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Zofia Szymańska", "Firma samochód" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Krzysztof Woźniak", "Firma drzwi" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Elżbieta Kaczmarek", "Firma biurko" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Andrzej Kowalczyk", "Firma komputer" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Marta Wiśniewska", "Firma kawa" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Paweł Nowak", "Firma dom" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Krystyna Szymańska", "Firma telefon" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Michał Krawczyk", "Firma rower" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Maria Malinowska", "Firma telewizor" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Wojciech Nowak", "Firma herbata" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Zofia Szymańska", "Firma stół" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Krzysztof Woźniak", "Firma książka" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Elżbieta Kaczmarek", "Firma lampa" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Andrzej Kowalczyk", "Firma komoda" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Marta Wiśniewska", "Firma telewizja" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Paweł Nowak", "Firma drzwi" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Krystyna Szymańska", "Firma samochód" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Michał Krawczyk", "Firma dom" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Maria Malinowska", "Firma biurko" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Wojciech Nowak", "Firma komputer" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Zofia Szymańska", "Firma telefon" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 43,
                column: "CompanyCEOName",
                value: "Krzysztof Woźniak");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Elżbieta Kaczmarek", "Firma telewizor" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Andrzej Kowalczyk", "Firma stół" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Marta Wiśniewska", "Firma lampa" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Paweł Nowak", "Firma komoda" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Krystyna Szymańska", "Firma herbata" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Michał Krawczyk", "Firma sofa" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CompanyCEOName", "CompanyName" },
                values: new object[] { "Maria Malinowska", "Firma samochód" });
        }
    }
}
