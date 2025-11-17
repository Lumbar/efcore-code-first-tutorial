using EF.Tutorial.Persistence.Seeds.CoreData;
using Microsoft.EntityFrameworkCore;

namespace EF.Tutorial.Persistence.Seeds;

public static class ModelBuilderSeedExtensions
{
    public static void SeedCore(this ModelBuilder modelBuilder)
    {
        modelBuilder.SeedCompany();
        modelBuilder.SeedUser();
        modelBuilder.SeedUserCompanyAccess();
    }
}
