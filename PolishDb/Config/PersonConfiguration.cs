using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using PolishDb.Entities;
using System.Collections.Generic;
using System.IO;

namespace PolishDb.Config;
public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        var projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
        var filePath = Path.Combine(projectDirectory, "PolishDb", "Utils", "seed-persons-data.json");

        var json = File.ReadAllText(filePath);
        var persons = JsonConvert.DeserializeObject<List<Person>>(json);
        builder.HasData(
           persons
        );
    }
}
