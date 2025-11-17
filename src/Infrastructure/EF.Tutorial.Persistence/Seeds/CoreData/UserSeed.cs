using EF.Tutorial.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF.Tutorial.Persistence.Seeds.CoreData;

internal static class UserSeed
{
    public static void SeedUser(this ModelBuilder modelBuilder)
    {
        var seedTimestamp = new DateTime(2025, 11, 17, 00, 00, 00, DateTimeKind.Utc);

        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = Guid.Parse("e3d5b2f4-91a7-4ac6-9c40-2df5f1e7b6a8"),
                ExternalObjectId = "c624b0ea-1a43-47e4-8c51-d1b64091ef0a",
                DisplayName = "User",
                Email = "tutorial@test.com",
                CreatedUser = "Admin",
                CreatedAt = seedTimestamp
            }
        );
    }
}
