using EF.Tutorial.Persistence.Configuration;
using EF.Tutorial.Persistence.Entities;
using EF.Tutorial.Persistence.Seeds;
using Microsoft.EntityFrameworkCore;

namespace EF.Tutorial.Persistence.Context;

public class TutorialDbContext : DbContext
{
    public TutorialDbContext(DbContextOptions<TutorialDbContext> options) : base(options)
    {
    }

    public DbSet<Company> Companies => Set<Company>();
    public DbSet<User> Users { get; set; } = default!;

    public DbSet<UserCompanyAccess> UserCompanyAccesses { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("tutorial");

        modelBuilder.ApplyConfiguration(new CompanyConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new UserCompanyAccessConfiguration());

        modelBuilder.SeedCore();
    }
}
