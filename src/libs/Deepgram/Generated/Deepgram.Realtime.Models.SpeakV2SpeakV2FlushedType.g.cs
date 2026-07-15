
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum SpeakV2SpeakV2FlushedType
    {
        /// <summary>
        /// 
        /// </summary>
        Flushed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV2SpeakV2FlushedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV2SpeakV2FlushedType value)
        {
            return value switch
            {
                SpeakV2SpeakV2FlushedType.Flushed => "Flushed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV2SpeakV2FlushedType? ToEnum(string value)
        {
            return value switch
            {
                "Flushed" => SpeakV2SpeakV2FlushedType.Flushed,
                _ => null,
            };
        }
    }
}