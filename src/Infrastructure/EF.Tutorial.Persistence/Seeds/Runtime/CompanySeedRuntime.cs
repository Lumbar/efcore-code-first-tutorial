using EF.Tutorial.Persistence.Context;
using EF.Tutorial.Persistence.Seeds.SampleData;

namespace EF.Tutorial.Persistence.Seeds.Runtime;

internal class CompanySeedRuntime
{
    public static async Task SeedFakeCompaniesAsync(TutorialDbContext context)
    {
        var existingIds = FakeCompanies.All.Select(x => x.Id).ToHashSet();

        var alreadySeeded = context.Companies.Any(b => existingIds.Contains(b.Id));
        if (alreadySeeded)
            return;

        await context.AddRangeAsync(FakeCompanies.All);
        await context.SaveChangesAsync();
    }
}
