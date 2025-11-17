using EF.Tutorial.Persistence.Context;
using EF.Tutorial.Persistence.Seeds.Runtime;

namespace EF.Tutorial.Persistence.Seeds;

public static class TutorialDbContextSeed
{
    public static async Task SeedAsync(TutorialDbContext context)
    {
        await CompanySeedRuntime.SeedFakeCompaniesAsync(context);
        await UserSeedRuntime.SeedFakeUsersAsync(context);
        await UserCompanyAccessSeedRuntime.SeedFakeUserCompanyAccessesAsync(context);
    }
}
