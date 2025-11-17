using EF.Tutorial.Domain.Aggregates;
using EF.Tutorial.Domain.ValueObjects;

namespace EF.Tutorial.Domain.Repositories;

public interface IUserRepository
{
    Task<User> GetByExternalIdAsync(ExternalObjectId externalObjectId, CancellationToken ct);
}
