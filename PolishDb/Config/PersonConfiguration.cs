using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PolishDb.Entities;

namespace PolishDb.Config;
public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        //builder.HasData(
        //   new Person() { /* params here*/ }
        //    );
    }
}
