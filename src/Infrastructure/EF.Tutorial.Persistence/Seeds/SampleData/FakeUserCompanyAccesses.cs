using EF.Tutorial.Persistence.Entities;

namespace EF.Tutorial.Persistence.Seeds.SampleData;

internal static class FakeUserCompanyAccesses
{
    private static readonly DateTime SeedTimestamp =
        new DateTime(2025, 11, 05, 0, 0, 0, DateTimeKind.Utc);

    public static readonly UserCompanyAccess[] All =
    {
        new UserCompanyAccess
        {
            Id = Guid.Parse("3e21f4ab-9135-47f0-8cd7-6b1e4bb2fae7"),
            CompanyId = Guid.Parse("12c34b56-78df-43a1-b0b1-5f6c4b987a33"),
            UserId = Guid.Parse("b98f0d23-0aa4-46c2-b158-62c63a0a247b"),
            CreatedUser = "Admin",
            CreatedAt = SeedTimestamp
        }
    };
}
