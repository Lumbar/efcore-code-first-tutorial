using EF.Tutorial.Persistence.Entities;

namespace EF.Tutorial.Persistence.Seeds.SampleData;

internal static class FakeUsers
{
    private static readonly DateTime SeedTimestamp =
        new DateTime(2025, 11, 05, 0, 0, 0, DateTimeKind.Utc);

    public static readonly User[] All =
    {
        new User
        {
            Id = Guid.Parse("b98f0d23-0aa4-46c2-b158-62c63a0a247b"),
            ExternalObjectId = "5f91d8a7-cba8-44ee-9a2e-2d5d39c3c0cf",
            DisplayName = "User 2",
            Email = "user2@tutorial.com",
            CreatedUser = "Admin",
            CreatedAt = SeedTimestamp
        }
    };
}
