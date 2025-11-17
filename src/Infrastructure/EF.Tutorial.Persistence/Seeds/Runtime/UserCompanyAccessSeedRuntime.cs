using EF.Tutorial.Persistence.Context;
using EF.Tutorial.Persistence.Seeds.SampleData;

namespace EF.Tutorial.Persistence.Seeds.Runtime;

internal class UserCompanyAccessSeedRuntime
{
    public static async Task SeedFakeUserCompanyAccessesAsync(TutorialDbContext context)
    {
        var fakeIds = FakeUserCompanyAccesses.All.Select(u => u.Id).ToHashSet();

        bool alreadySeeded = context.UserCompanyAccesses.Any(u => fakeIds.Contains(u.Id));
        if (alreadySeeded)
            return;

        await context.AddRangeAsync(FakeUserCompanyAccesses.All);
        await context.SaveChangesAsync();
    }
}
