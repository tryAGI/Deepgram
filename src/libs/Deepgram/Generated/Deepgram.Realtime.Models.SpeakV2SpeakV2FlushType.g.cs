
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum SpeakV2SpeakV2FlushType
    {
        /// <summary>
        /// 
        /// </summary>
        Flush,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV2SpeakV2FlushTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV2SpeakV2FlushType value)
        {
            return value switch
            {
                SpeakV2SpeakV2FlushType.Flush => "Flush",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV2SpeakV2FlushType? ToEnum(string value)
        {
            return value switch
            {
                "Flush" => SpeakV2SpeakV2FlushType.Flush,
                _ => null,
            };
        }
    }
}