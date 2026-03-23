
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
        Alaw,
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
        Linear32,
        /// <summary>
        /// 
        /// </summary>
        Mulaw,
        /// <summary>
        /// 
        /// </summary>
        OggOpus,
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
    public static class ListenV1EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1Encoding value)
        {
            return value switch
            {
                ListenV1Encoding.Alaw => "alaw",
                ListenV1Encoding.AmrNb => "amr-nb",
                ListenV1Encoding.AmrWb => "amr-wb",
                ListenV1Encoding.Flac => "flac",
                ListenV1Encoding.G729 => "g729",
                ListenV1Encoding.Linear16 => "linear16",
                ListenV1Encoding.Linear32 => "linear32",
                ListenV1Encoding.Mulaw => "mulaw",
                ListenV1Encoding.OggOpus => "ogg-opus",
                ListenV1Encoding.Opus => "opus",
                ListenV1Encoding.Speex => "speex",
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
                "alaw" => ListenV1Encoding.Alaw,
                "amr-nb" => ListenV1Encoding.AmrNb,
                "amr-wb" => ListenV1Encoding.AmrWb,
                "flac" => ListenV1Encoding.Flac,
                "g729" => ListenV1Encoding.G729,
                "linear16" => ListenV1Encoding.Linear16,
                "linear32" => ListenV1Encoding.Linear32,
                "mulaw" => ListenV1Encoding.Mulaw,
                "ogg-opus" => ListenV1Encoding.OggOpus,
                "opus" => ListenV1Encoding.Opus,
                "speex" => ListenV1Encoding.Speex,
                _ => null,
            };
        }
    }
}