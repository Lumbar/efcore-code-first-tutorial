using System;
using System.Collections.Generic;
using System.Text;

namespace EF.Tutorial.Domain.ValueObjects;

public sealed record ExternalObjectId
{
    public string Value { get; }

    private ExternalObjectId(string value)
    {
        Value = value;
    }

    public static ExternalObjectId From(string value)
        => string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("External object id required") : new(value);
}