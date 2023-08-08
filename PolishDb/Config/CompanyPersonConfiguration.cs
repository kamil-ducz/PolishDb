using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

public class CompanyPersonConfiguration : IEntityTypeConfiguration<CompanyPerson>
{
    public void Configure(EntityTypeBuilder<CompanyPerson> builder)
    {
        var projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
        var filePath = Path.Combine(projectDirectory, "PolishDb", "Utils", "company-persons-data.json");

        var json = File.ReadAllText(filePath);
        var companyPersons = JsonConvert.DeserializeObject<List<CompanyPerson>>(json);

        builder.HasData(companyPersons);
    }
}
