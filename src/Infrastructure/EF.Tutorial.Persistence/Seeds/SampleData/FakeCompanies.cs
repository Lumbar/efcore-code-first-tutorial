using EF.Tutorial.Persistence.Entities;

namespace EF.Tutorial.Persistence.Seeds.SampleData;

internal static class FakeCompanies
{
    public static readonly Company[] All =
    {
        new Company
        {
            Id = Guid.Parse("12c34b56-78df-43a1-b0b1-5f6c4b987a33"),
            Code = "0000003",
            CreatedUser = "Admin",
            CreatedAt = new DateTime(2025, 11, 05, 0, 0, 0, DateTimeKind.Utc)
        }
    };
}
