using EF.Tutorial.Persistence.Context;
using EF.Tutorial.Persistence.Seeds.SampleData;

namespace EF.Tutorial.Persistence.Seeds.Runtime;

internal class UserSeedRuntime
{
    public static async Task SeedFakeUsersAsync(TutorialDbContext context)
    {
        var fakeIds = FakeUsers.All.Select(u => u.Id).ToHashSet();

        bool alreadySeeded = context.Users.Any(u => fakeIds.Contains(u.Id));
        if (alreadySeeded)
            return;

        await context.AddRangeAsync(FakeUsers.All);
        await context.SaveChangesAsync();
    }
}
