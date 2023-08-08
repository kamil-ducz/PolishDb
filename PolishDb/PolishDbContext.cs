using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PolishDb.Entities;

namespace PolishDb;
public class PolishDbContext : DbContext
{
    private readonly IConfiguration _configuration;

    public PolishDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public DbSet<Person> Persons { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<CompanyPerson> CompanyPersons { get; set; }
    public DbSet<EmploymentType> Employments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CompanyPerson>().HasNoKey();
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PolishDbContext).Assembly);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_configuration.GetConnectionString("PolishDb"), b => b.MigrationsAssembly("PolishDb"));
    }
}
