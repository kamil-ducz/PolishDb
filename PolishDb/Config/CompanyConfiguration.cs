using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PolishDb.Entities;

namespace PolishDb.Config;
public class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.HasData(
            new Company { Id = 1, CompanyName = "Firma herbata", CompanyCEOName = "Jan Kowalski" },
            new Company { Id = 2, CompanyName = "Firma samochód", CompanyCEOName = "Anna Nowak" },
            new Company { Id = 3, CompanyName = "Firma dom", CompanyCEOName = "Piotr Nowakowski" },
            new Company { Id = 4, CompanyName = "Firma książka", CompanyCEOName = "Alicja Wiśniewska" },
            new Company { Id = 5, CompanyName = "Firma rower", CompanyCEOName = "Marek Kaczmarek" },
            new Company { Id = 6, CompanyName = "Firma stół", CompanyCEOName = "Ewa Wojciechowska" },
            new Company { Id = 7, CompanyName = "Firma lampa", CompanyCEOName = "Tomasz Malinowski" },
            new Company { Id = 8, CompanyName = "Firma komputer", CompanyCEOName = "Katarzyna Duda" },
            new Company { Id = 9, CompanyName = "Firma telefon", CompanyCEOName = "Bartosz Krawczyk" },
            new Company { Id = 10, CompanyName = "Firma telewizor", CompanyCEOName = "Magdalena Pawlak" },
            new Company { Id = 11, CompanyName = "Firma drzwi", CompanyCEOName = "Wojciech Nowak" },
            new Company { Id = 12, CompanyName = "Firma sofa", CompanyCEOName = "Zofia Szymańska" },
            new Company { Id = 13, CompanyName = "Firma kawa", CompanyCEOName = "Krzysztof Woźniak" },
            new Company { Id = 14, CompanyName = "Firma biurko", CompanyCEOName = "Elżbieta Kaczmarek" },
            new Company { Id = 15, CompanyName = "Firma fotel", CompanyCEOName = "Andrzej Kowalczyk" },
            new Company { Id = 16, CompanyName = "Firma telewizja", CompanyCEOName = "Marta Wiśniewska" },
            new Company { Id = 17, CompanyName = "Firma woda", CompanyCEOName = "Paweł Nowak" },
            new Company { Id = 18, CompanyName = "Firma okno", CompanyCEOName = "Krystyna Szymańska" },
            new Company { Id = 19, CompanyName = "Firma komoda", CompanyCEOName = "Michał Krawczyk" },
            new Company { Id = 20, CompanyName = "Firma słonik", CompanyCEOName = "Maria Malinowska" },
            new Company { Id = 21, CompanyName = "Firma strych", CompanyCEOName = "Wojciech Wójcik" },
            new Company { Id = 22, CompanyName = "Firma ogień", CompanyCEOName = "Zofia Zaręba" },
            new Company { Id = 23, CompanyName = "Firma dach", CompanyCEOName = "Krzysztof Król" },
            new Company { Id = 24, CompanyName = "Firma klucz", CompanyCEOName = "Elżbieta Borkowska" },
            new Company { Id = 25, CompanyName = "Firma ręka", CompanyCEOName = "Andrzej Adamczyk" },
            new Company { Id = 26, CompanyName = "Firma serce", CompanyCEOName = "Marta Majewska" },
            new Company { Id = 27, CompanyName = "Firma drzewo", CompanyCEOName = "Paweł Piotrowski" },
            new Company { Id = 28, CompanyName = "Firma piasek", CompanyCEOName = "Krystyna Krawczyk" },
            new Company { Id = 29, CompanyName = "Firma księżyc", CompanyCEOName = "Michał Majewski" },
            new Company { Id = 30, CompanyName = "Firma wiatr", CompanyCEOName = "Maria Nowak" },
            new Company { Id = 31, CompanyName = "Firma słońce", CompanyCEOName = "Wojciech Szymański" },
            new Company { Id = 32, CompanyName = "Firma góra", CompanyCEOName = "Zofia Wojciechowska" },
            new Company { Id = 33, CompanyName = "Firma morze", CompanyCEOName = "Krzysztof Malinowski" },
            new Company { Id = 34, CompanyName = "Firma chmura", CompanyCEOName = "Elżbieta Kowalczyk" },
            new Company { Id = 35, CompanyName = "Firma deszcz", CompanyCEOName = "Andrzej Wojcik" },
            new Company { Id = 36, CompanyName = "Firma ptak", CompanyCEOName = "Marta Malinowska" },
            new Company { Id = 37, CompanyName = "Firma ryba", CompanyCEOName = "Paweł Krawczyk" },
            new Company { Id = 38, CompanyName = "Firma kawa", CompanyCEOName = "Krystyna Nowak" },
            new Company { Id = 39, CompanyName = "Firma herbata", CompanyCEOName = "Michał Szymański" },
            new Company { Id = 40, CompanyName = "Firma samochód", CompanyCEOName = "Maria Wojciechowska" },
            new Company { Id = 41, CompanyName = "Firma chata", CompanyCEOName = "Wojciech Malinowski" },
            new Company { Id = 42, CompanyName = "Firma książka", CompanyCEOName = "Zofia Kowalczyk" },
            new Company { Id = 43, CompanyName = "Firma rower", CompanyCEOName = "Krzysztof Wojcik" },
            new Company { Id = 44, CompanyName = "Firma plazma", CompanyCEOName = "Elżbieta Malinowska" },
            new Company { Id = 45, CompanyName = "Firma lampa", CompanyCEOName = "Andrzej Krawczyk" },
            new Company { Id = 46, CompanyName = "Firma komputer", CompanyCEOName = "Marta Nowak" },
            new Company { Id = 47, CompanyName = "Firma telefon", CompanyCEOName = "Paweł Szymański" },
            new Company { Id = 48, CompanyName = "Firma telewizja", CompanyCEOName = "Krystyna Wojciechowska" },
            new Company { Id = 49, CompanyName = "Firma komoda", CompanyCEOName = "Michał Malinowski" },
            new Company { Id = 50, CompanyName = "Firma porcelana", CompanyCEOName = "Maria Krawczyk" }
        );
    }
}
