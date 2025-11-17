using EF.Tutorial.Domain.Repositories;
using EF.Tutorial.Persistence.Context;
using EF.Tutorial.Persistence.Repositories;
using EF.Tutorial.Persistence.Seeds;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

builder.Services.AddTransient<IUserRepository, UserRepository>();

#if DEBUG
if (app.Environment.IsDevelopment())
{
    using var scope = app.Services.CreateScope();
    using var context = scope.ServiceProvider.GetRequiredService<TutorialDbContext>();
    await context.Database.MigrateAsync();

    await TutorialDbContextSeed.SeedAsync(context);
}
#endif

await app.RunAsync();

