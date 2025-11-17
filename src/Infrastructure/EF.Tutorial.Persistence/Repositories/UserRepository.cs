using EF.Tutorial.Domain.Aggregates;
using EF.Tutorial.Domain.Repositories;
using EF.Tutorial.Domain.ValueObjects;

namespace EF.Tutorial.Persistence.Repositories;

public class UserRepository : IUserRepository
{
    public Task<User> GetByExternalIdAsync(ExternalObjectId externalObjectId, CancellationToken ct)
    {
        throw new NotImplementedException();
    }
}
