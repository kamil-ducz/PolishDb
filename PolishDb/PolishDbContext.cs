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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PolishDbContext).Assembly);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_configuration.GetConnectionString("PolishDb"), b => b.MigrationsAssembly("PolishDb"));
    }
}
