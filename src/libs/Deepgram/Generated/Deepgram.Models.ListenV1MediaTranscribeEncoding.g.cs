
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListenV1MediaTranscribeEncoding
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
    public static class ListenV1MediaTranscribeEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1MediaTranscribeEncoding value)
        {
            return value switch
            {
                ListenV1MediaTranscribeEncoding.AmrNb => "amr-nb",
                ListenV1MediaTranscribeEncoding.AmrWb => "amr-wb",
                ListenV1MediaTranscribeEncoding.Flac => "flac",
                ListenV1MediaTranscribeEncoding.G729 => "g729",
                ListenV1MediaTranscribeEncoding.Linear16 => "linear16",
                ListenV1MediaTranscribeEncoding.Mulaw => "mulaw",
                ListenV1MediaTranscribeEncoding.Opus => "opus",
                ListenV1MediaTranscribeEncoding.Speex => "speex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1MediaTranscribeEncoding? ToEnum(string value)
        {
            return value switch
            {
                "amr-nb" => ListenV1MediaTranscribeEncoding.AmrNb,
                "amr-wb" => ListenV1MediaTranscribeEncoding.AmrWb,
                "flac" => ListenV1MediaTranscribeEncoding.Flac,
                "g729" => ListenV1MediaTranscribeEncoding.G729,
                "linear16" => ListenV1MediaTranscribeEncoding.Linear16,
                "mulaw" => ListenV1MediaTranscribeEncoding.Mulaw,
                "opus" => ListenV1MediaTranscribeEncoding.Opus,
                "speex" => ListenV1MediaTranscribeEncoding.Speex,
                _ => null,
            };
        }
    }
}