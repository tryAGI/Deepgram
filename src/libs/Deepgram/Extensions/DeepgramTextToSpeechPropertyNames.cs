#nullable enable

namespace Deepgram;

/// <summary>
/// Deepgram-specific <see cref="Microsoft.Extensions.AI.TextToSpeechOptions.AdditionalProperties" /> keys.
/// </summary>
public static class DeepgramTextToSpeechPropertyNames
{
    /// <summary>Output audio encoding, such as <c>mp3</c>, <c>linear16</c>, <c>mulaw</c>, <c>alaw</c>, <c>opus</c>, <c>aac</c>, or <c>flac</c>.</summary>
    public const string Encoding = "deepgram:encoding";

    /// <summary>Output container, such as <c>wav</c> or <c>none</c>.</summary>
    public const string Container = "deepgram:container";

    /// <summary>Output sample rate in Hz.</summary>
    public const string SampleRate = "deepgram:sample_rate";

    /// <summary>Output bit rate in bits per second when supported by the selected encoding.</summary>
    public const string BitRate = "deepgram:bit_rate";

    /// <summary>Opt out of Deepgram model improvement for the request.</summary>
    public const string MipOptOut = "deepgram:mip_opt_out";

    /// <summary>Usage/reporting tag. The value can be a string or a string collection.</summary>
    public const string Tag = "deepgram:tag";

    /// <summary>Callback URL for asynchronous processing.</summary>
    public const string Callback = "deepgram:callback";

    /// <summary>HTTP method for callback delivery.</summary>
    public const string CallbackMethod = "deepgram:callback_method";
}
