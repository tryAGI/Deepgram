
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Encoding of the raw output audio. The streaming WebSocket emits raw (non-containerized) audio, so only streaming-compatible encodings are supported. Compressed and containerized encodings (`mp3`, `opus`, `flac`, `aac`) are available on the batch REST transport only.<br/>
    /// Default Value: linear16
    /// </summary>
    public enum SpeakV2Encoding
    {
        /// <summary>
        /// 
        /// </summary>
        Alaw,
        /// <summary>
        /// 
        /// </summary>
        Linear16,
        /// <summary>
        /// 
        /// </summary>
        Mulaw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV2EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV2Encoding value)
        {
            return value switch
            {
                SpeakV2Encoding.Alaw => "alaw",
                SpeakV2Encoding.Linear16 => "linear16",
                SpeakV2Encoding.Mulaw => "mulaw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV2Encoding? ToEnum(string value)
        {
            return value switch
            {
                "alaw" => SpeakV2Encoding.Alaw,
                "linear16" => SpeakV2Encoding.Linear16,
                "mulaw" => SpeakV2Encoding.Mulaw,
                _ => null,
            };
        }
    }
}