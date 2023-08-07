using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PolishDb.Entities;

namespace PolishDb.Config;
public class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        //builder.HasData(
        //    new Company() { /* params here */ }
        //    );
    }
}
