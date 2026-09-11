using System.Globalization;

namespace Deepgram;

/// <summary>One built-in Deepgram text-to-speech voice exposed by the OpenAPI model enum.</summary>
public sealed record DeepgramTextToSpeechVoice(
    V1SpeakPostParametersModel Model,
    string Id,
    string Name,
    string Language,
    string ModelFamily);

/// <summary>
/// A strongly typed, allocation-once catalog of every text-to-speech voice in the
/// generated Deepgram specification. Deepgram has no voice-list endpoint, so this is
/// the discoverable SDK surface for applications that need to build a voice picker.
/// </summary>
public static class DeepgramTextToSpeechVoices
{
    /// <summary>All voices in the current generated specification.</summary>
    public static IReadOnlyList<DeepgramTextToSpeechVoice> All { get; } =
        Enum.GetValues<V1SpeakPostParametersModel>()
            .Select(Create)
            .ToArray();

    private static DeepgramTextToSpeechVoice Create(V1SpeakPostParametersModel model)
    {
        var id = global::Deepgram.V1SpeakPostParametersModelExtensions.ToValueString(model);
        var parts = id.Split('-', StringSplitOptions.RemoveEmptyEntries);
        var modelFamily = parts.Length >= 4 && parts[1] == "2" ? "aura-2" : "aura";
        var nameIndex = modelFamily == "aura-2" ? 2 : 1;
        var name = parts.Length > nameIndex
            ? CultureInfo.InvariantCulture.TextInfo.ToTitleCase(parts[nameIndex])
            : id;
        var language = parts.Length > 0 ? parts[^1] : string.Empty;
        return new DeepgramTextToSpeechVoice(model, id, name, language, modelFamily);
    }
}
