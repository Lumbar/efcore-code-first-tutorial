using System.Text.RegularExpressions;

namespace EF.Tutorial.Domain.ValueObjects;

public sealed record Email
{
    private static readonly Regex Pattern =
        new(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled);

    public string Value { get; }

    private Email(string value) => Value = value.ToLowerInvariant();

    public static Email Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Email cannot be empty.", nameof(value));

        if (!Pattern.IsMatch(value))
            throw new ArgumentException("Invalid email format.", nameof(value));

        return new Email(value);
    }

    public override string ToString() => Value;
}