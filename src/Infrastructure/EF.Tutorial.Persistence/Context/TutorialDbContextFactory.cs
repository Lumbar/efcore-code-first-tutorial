using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EF.Tutorial.Persistence.Context;

public class TutorialDbContextFactory : IDesignTimeDbContextFactory<TutorialDbContext>
{
    public TutorialDbContext CreateDbContext(string[] args)
    {
        var connectionString = Environment.GetEnvironmentVariable("TUTORIAL_CONNECTION");

        if (string.IsNullOrWhiteSpace(connectionString))
        {
            throw new InvalidOperationException(
                "No connection string available for migrations. " +
                "Set TUTORIAL_CONNECTION via user-secrets or env var.");
        }

        var optionsBuilder = new DbContextOptionsBuilder<TutorialDbContext>();

        optionsBuilder
            .UseNpgsql(connectionString, npgsql =>
            {
                npgsql.MigrationsAssembly(typeof(TutorialDbContext).Assembly.FullName);
            });

        return new TutorialDbContext(optionsBuilder.Options);
    }
}