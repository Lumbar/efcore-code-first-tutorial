using EF.Tutorial.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF.Tutorial.Persistence.Seeds.CoreData;

internal static class CompanySeed
{
    public static void SeedCompany(this ModelBuilder modelBuilder)
    {
        var seedTimestamp = new DateTime(2025, 11, 17, 00, 00, 00, DateTimeKind.Utc);

        modelBuilder.Entity<Company>().HasData(
            new Company
            {
                Id = Guid.Parse("8f2c8b6e-4b2e-4bb4-9f31-0b7f4e2b9d9d"),
                Code = "0000001",
                LegalName = "Company 1",
                CreatedUser = "Admin",
                CreatedAt = seedTimestamp
            },
            new Company
            {
                Id = Guid.Parse("a1d4cbe2-0d18-4c57-8d8a-7a2de9131df6"),
                Code = "0000002",
                LegalName = "Company 2",
                CreatedUser = "Admin",
                CreatedAt = seedTimestamp
            }
        );
    }
}
