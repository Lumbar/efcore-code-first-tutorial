using EF.Tutorial.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF.Tutorial.Persistence.Seeds.CoreData;

internal static class UserCompanyAccessSeed
{
    public static void SeedUserCompanyAccess(this ModelBuilder modelBuilder)
    {
        var seedTimestamp = new DateTime(2025, 11, 17, 00, 00, 00, DateTimeKind.Utc);

        modelBuilder.Entity<UserCompanyAccess>().HasData(
            new UserCompanyAccess
            {
                Id = Guid.Parse("f0c8a3d9-91c4-44bb-af40-6b77c0dd3d8b"),
                CompanyId = Guid.Parse("8f2c8b6e-4b2e-4bb4-9f31-0b7f4e2b9d9d"),
                UserId = Guid.Parse("e3d5b2f4-91a7-4ac6-9c40-2df5f1e7b6a8"),
                CreatedUser = "Admin",
                CreatedAt = seedTimestamp
            }
        );
    }
}
