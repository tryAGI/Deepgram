
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1ListenPostParametersEncoding
    {
        /// <summary>
        /// 
        /// </summary>
        AmrNb,
        /// <summary>
        /// 
        /// </summary>
        AmrWb,
        /// <summary>
        /// 
        /// </summary>
        Flac,
        /// <summary>
        /// 
        /// </summary>
        G729,
        /// <summary>
        /// 
        /// </summary>
        Linear16,
        /// <summary>
        /// 
        /// </summary>
        Mulaw,
        /// <summary>
        /// 
        /// </summary>
        Opus,
        /// <summary>
        /// 
        /// </summary>
        Speex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1ListenPostParametersEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ListenPostParametersEncoding value)
        {
            return value switch
            {
                V1ListenPostParametersEncoding.AmrNb => "amr-nb",
                V1ListenPostParametersEncoding.AmrWb => "amr-wb",
                V1ListenPostParametersEncoding.Flac => "flac",
                V1ListenPostParametersEncoding.G729 => "g729",
                V1ListenPostParametersEncoding.Linear16 => "linear16",
                V1ListenPostParametersEncoding.Mulaw => "mulaw",
                V1ListenPostParametersEncoding.Opus => "opus",
                V1ListenPostParametersEncoding.Speex => "speex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ListenPostParametersEncoding? ToEnum(string value)
        {
            return value switch
            {
                "amr-nb" => V1ListenPostParametersEncoding.AmrNb,
                "amr-wb" => V1ListenPostParametersEncoding.AmrWb,
                "flac" => V1ListenPostParametersEncoding.Flac,
                "g729" => V1ListenPostParametersEncoding.G729,
                "linear16" => V1ListenPostParametersEncoding.Linear16,
                "mulaw" => V1ListenPostParametersEncoding.Mulaw,
                "opus" => V1ListenPostParametersEncoding.Opus,
                "speex" => V1ListenPostParametersEncoding.Speex,
                _ => null,
            };
        }
    }
}