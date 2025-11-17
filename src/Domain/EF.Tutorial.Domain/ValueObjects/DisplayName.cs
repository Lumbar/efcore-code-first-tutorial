namespace EF.Tutorial.Domain.ValueObjects;

public sealed record DisplayName
{
    public string Value { get; }

    private DisplayName(string value) => Value = value.Trim();

    public static DisplayName Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Display name cannot be empty.");

        return new DisplayName(value.Trim());
    }

    public override string ToString() => Value;
}
