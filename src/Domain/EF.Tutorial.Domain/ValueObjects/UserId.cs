namespace EF.Tutorial.Domain.ValueObjects;

public sealed record UserId
{
    public Guid Value { get; }

    private UserId(Guid value) => Value = value;

    public static UserId New() => new(Guid.NewGuid());
    public static UserId From(Guid value) => new(value);
}