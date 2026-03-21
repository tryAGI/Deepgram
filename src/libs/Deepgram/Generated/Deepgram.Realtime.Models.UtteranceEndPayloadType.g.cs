
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum UtteranceEndPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        UtteranceEnd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UtteranceEndPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UtteranceEndPayloadType value)
        {
            return value switch
            {
                UtteranceEndPayloadType.UtteranceEnd => "UtteranceEnd",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UtteranceEndPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "UtteranceEnd" => UtteranceEndPayloadType.UtteranceEnd,
                _ => null,
            };
        }
    }
}