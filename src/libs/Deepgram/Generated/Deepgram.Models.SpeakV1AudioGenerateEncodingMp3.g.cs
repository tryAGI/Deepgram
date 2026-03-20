
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Encoding - mp3. Popular compressed audio format for music and streaming.
    /// </summary>
    public enum SpeakV1AudioGenerateEncodingMp3
    {
        /// <summary>
        /// 
        /// </summary>
        Mp3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV1AudioGenerateEncodingMp3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV1AudioGenerateEncodingMp3 value)
        {
            return value switch
            {
                SpeakV1AudioGenerateEncodingMp3.Mp3 => "mp3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV1AudioGenerateEncodingMp3? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => SpeakV1AudioGenerateEncodingMp3.Mp3,
                _ => null,
            };
        }
    }
}