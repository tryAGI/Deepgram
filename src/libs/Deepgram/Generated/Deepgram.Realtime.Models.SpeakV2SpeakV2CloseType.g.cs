
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum SpeakV2SpeakV2CloseType
    {
        /// <summary>
        /// 
        /// </summary>
        Close,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV2SpeakV2CloseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV2SpeakV2CloseType value)
        {
            return value switch
            {
                SpeakV2SpeakV2CloseType.Close => "Close",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV2SpeakV2CloseType? ToEnum(string value)
        {
            return value switch
            {
                "Close" => SpeakV2SpeakV2CloseType.Close,
                _ => null,
            };
        }
    }
}