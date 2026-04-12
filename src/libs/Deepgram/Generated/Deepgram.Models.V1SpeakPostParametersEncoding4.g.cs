
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Encoding - mp3. Popular compressed audio format for music and streaming.
    /// </summary>
    public enum V1SpeakPostParametersEncoding4
    {
        /// <summary>
        /// 
        /// </summary>
        Mp3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1SpeakPostParametersEncoding4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1SpeakPostParametersEncoding4 value)
        {
            return value switch
            {
                V1SpeakPostParametersEncoding4.Mp3 => "mp3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1SpeakPostParametersEncoding4? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => V1SpeakPostParametersEncoding4.Mp3,
                _ => null,
            };
        }
    }
}