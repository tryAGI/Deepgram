#nullable enable

namespace Deepgram;

/// <summary>
/// Additional property keys used by the Deepgram MEAI speech-to-text adapter.
/// </summary>
public static class DeepgramSpeechToTextPropertyNames
{
    /// <summary>
    /// Additional property key for the Flux <c>eager_eot_threshold</c> query parameter.
    /// </summary>
    public const string EagerEotThreshold = "eager_eot_threshold";

    /// <summary>
    /// Additional property key for the Flux <c>encoding</c> query parameter.
    /// </summary>
    public const string Encoding = "encoding";

    /// <summary>
    /// Additional property key for the Flux <c>eot_threshold</c> query parameter.
    /// </summary>
    public const string EotThreshold = "eot_threshold";

    /// <summary>
    /// Additional property key for the Flux <c>eot_timeout_ms</c> query parameter.
    /// </summary>
    public const string EotTimeoutMs = "eot_timeout_ms";

    /// <summary>
    /// Additional property key for the repeated Flux <c>keyterm</c> query parameter.
    /// </summary>
    public const string Keyterm = "keyterm";

    /// <summary>
    /// Alias for <see cref="Keyterm"/>.
    /// </summary>
    public const string Keyterms = Keyterm;

    /// <summary>
    /// Additional property key for the repeated Flux <c>language_hint</c> query parameter.
    /// </summary>
    public const string LanguageHint = "language_hint";

    /// <summary>
    /// Alias for <see cref="LanguageHint"/>.
    /// </summary>
    public const string LanguageHints = LanguageHint;

    /// <summary>
    /// Additional property key for the Flux <c>mip_opt_out</c> query parameter.
    /// </summary>
    public const string MipOptOut = "mip_opt_out";

    /// <summary>
    /// Additional property key for the Flux <c>profanity_filter</c> query parameter.
    /// </summary>
    public const string ProfanityFilter = "profanity_filter";

    /// <summary>
    /// Additional property key for the Flux <c>sample_rate</c> query parameter.
    /// </summary>
    public const string SampleRate = "sample_rate";

    /// <summary>
    /// Additional property key for the Flux <c>tag</c> query parameter.
    /// </summary>
    public const string Tag = "tag";
}
