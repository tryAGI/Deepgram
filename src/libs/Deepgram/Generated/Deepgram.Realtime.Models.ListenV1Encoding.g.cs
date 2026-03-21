
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Specify the expected encoding of your submitted audio
    /// </summary>
    public enum ListenV1Encoding
    {
        /// <summary>
        /// 
        /// </summary>
        Linear16,
        /// <summary>
        /// 
        /// </summary>
        Linear32,
        /// <summary>
        /// 
        /// </summary>
        Flac,
        /// <summary>
        /// 
        /// </summary>
        Alaw,
        /// <summary>
        /// 
        /// </summary>
        Mulaw,
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
        Opus,
        /// <summary>
        /// 
        /// </summary>
        OggOpus,
        /// <summary>
        /// 
        /// </summary>
        Speex,
        /// <summary>
        /// 
        /// </summary>
        G729,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV1EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1Encoding value)
        {
            return value switch
            {
                ListenV1Encoding.Linear16 => "linear16",
                ListenV1Encoding.Linear32 => "linear32",
                ListenV1Encoding.Flac => "flac",
                ListenV1Encoding.Alaw => "alaw",
                ListenV1Encoding.Mulaw => "mulaw",
                ListenV1Encoding.AmrNb => "amr-nb",
                ListenV1Encoding.AmrWb => "amr-wb",
                ListenV1Encoding.Opus => "opus",
                ListenV1Encoding.OggOpus => "ogg-opus",
                ListenV1Encoding.Speex => "speex",
                ListenV1Encoding.G729 => "g729",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1Encoding? ToEnum(string value)
        {
            return value switch
            {
                "linear16" => ListenV1Encoding.Linear16,
                "linear32" => ListenV1Encoding.Linear32,
                "flac" => ListenV1Encoding.Flac,
                "alaw" => ListenV1Encoding.Alaw,
                "mulaw" => ListenV1Encoding.Mulaw,
                "amr-nb" => ListenV1Encoding.AmrNb,
                "amr-wb" => ListenV1Encoding.AmrWb,
                "opus" => ListenV1Encoding.Opus,
                "ogg-opus" => ListenV1Encoding.OggOpus,
                "speex" => ListenV1Encoding.Speex,
                "g729" => ListenV1Encoding.G729,
                _ => null,
            };
        }
    }
}