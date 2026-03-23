
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Encoding allows you to specify the expected encoding of your audio output for streaming TTS. Only streaming-compatible encodings are supported.<br/>
    /// Default Value: linear16
    /// </summary>
    public enum SpeakV1Encoding
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
    public static class SpeakV1EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV1Encoding value)
        {
            return value switch
            {
                SpeakV1Encoding.Alaw => "alaw",
                SpeakV1Encoding.Linear16 => "linear16",
                SpeakV1Encoding.Mulaw => "mulaw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV1Encoding? ToEnum(string value)
        {
            return value switch
            {
                "alaw" => SpeakV1Encoding.Alaw,
                "linear16" => SpeakV1Encoding.Linear16,
                "mulaw" => SpeakV1Encoding.Mulaw,
                _ => null,
            };
        }
    }
}