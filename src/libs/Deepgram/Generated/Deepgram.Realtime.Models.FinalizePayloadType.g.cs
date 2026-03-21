
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum FinalizePayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        Finalize,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FinalizePayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinalizePayloadType value)
        {
            return value switch
            {
                FinalizePayloadType.Finalize => "Finalize",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinalizePayloadType? ToEnum(string value)
        {
            return value switch
            {
                "Finalize" => FinalizePayloadType.Finalize,
                _ => null,
            };
        }
    }
}