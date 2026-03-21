
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Encoding of the audio stream. Required if sending non-containerized/raw audio. If sending containerized audio, this parameter should be omitted.
    /// </summary>
    public enum ListenV2Encoding
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
        Mulaw,
        /// <summary>
        /// 
        /// </summary>
        Alaw,
        /// <summary>
        /// 
        /// </summary>
        Opus,
        /// <summary>
        /// 
        /// </summary>
        OggOpus,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV2EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV2Encoding value)
        {
            return value switch
            {
                ListenV2Encoding.Linear16 => "linear16",
                ListenV2Encoding.Linear32 => "linear32",
                ListenV2Encoding.Mulaw => "mulaw",
                ListenV2Encoding.Alaw => "alaw",
                ListenV2Encoding.Opus => "opus",
                ListenV2Encoding.OggOpus => "ogg-opus",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV2Encoding? ToEnum(string value)
        {
            return value switch
            {
                "linear16" => ListenV2Encoding.Linear16,
                "linear32" => ListenV2Encoding.Linear32,
                "mulaw" => ListenV2Encoding.Mulaw,
                "alaw" => ListenV2Encoding.Alaw,
                "opus" => ListenV2Encoding.Opus,
                "ogg-opus" => ListenV2Encoding.OggOpus,
                _ => null,
            };
        }
    }
}