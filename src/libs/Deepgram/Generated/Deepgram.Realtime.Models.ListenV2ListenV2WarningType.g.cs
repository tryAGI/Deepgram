
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ListenV2ListenV2WarningType
    {
        /// <summary>
        ///
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV2ListenV2WarningTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV2ListenV2WarningType value)
        {
            return value switch
            {
                ListenV2ListenV2WarningType.Warning => "Warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV2ListenV2WarningType? ToEnum(string value)
        {
            return value switch
            {
                "Warning" => ListenV2ListenV2WarningType.Warning,
                _ => null,
            };
        }
    }
}