#nullable enable

namespace Deepgram.Realtime;

public sealed partial class ListenV1Language
{
    private string? _value;

    /// <summary>
    /// Creates a <see cref="ListenV1Language"/> from a BCP-47 language tag string
    /// (e.g., "en", "es", "fr").
    /// </summary>
    public static ListenV1Language FromString(string value) => new() { _value = value };

    /// <inheritdoc />
    public override string ToString() => _value ?? string.Empty;
}
