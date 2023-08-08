using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PolishDb.Entities;

namespace PolishDb.Config;
public class EmploymentTypeConfiguration : IEntityTypeConfiguration<EmploymentType>
{
    public void Configure(EntityTypeBuilder<EmploymentType> builder)
    {
        builder.HasData(
            new EmploymentType() { Id = (int)Enums.EmploymentType.MandateContract, Name = Enums.EmploymentType.MandateContract.ToString() },
            new EmploymentType() { Id = (int)Enums.EmploymentType.ContractOfEmployment, Name = Enums.EmploymentType.ContractOfEmployment.ToString() }
            );
    }
}
