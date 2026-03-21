
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum CloseStreamPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        CloseStream,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CloseStreamPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CloseStreamPayloadType value)
        {
            return value switch
            {
                CloseStreamPayloadType.CloseStream => "CloseStream",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CloseStreamPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "CloseStream" => CloseStreamPayloadType.CloseStream,
                _ => null,
            };
        }
    }
}