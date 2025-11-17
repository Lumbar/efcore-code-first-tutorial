using EF.Tutorial.Domain.ValueObjects;

namespace EF.Tutorial.Domain.Aggregates;

public class User
{
    public UserId UserId { get; private set; } = default!;

    public ExternalObjectId ExternalObjectId { get; private set; } = default!;
    public Email Email { get; private set; } = default!;
    public DisplayName DisplayName { get; private set; } = default!;

    private User() { }
    private User(UserId userId,
        ExternalObjectId externalObjectId,
        DisplayName displayName,
        Email email)
    {
        UserId = userId;
        DisplayName = displayName;
        ExternalObjectId = externalObjectId;
        Email = email;
    }

    public static User Create(Guid id,
        string externalObjectId,
        string displayName,
        string email)
        => new(UserId.From(id),
            ExternalObjectId.From(externalObjectId),
            DisplayName.Create(displayName),
            Email.Create(email));
}
