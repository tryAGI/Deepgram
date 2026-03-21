
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ListenV2FatalErrorEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV2FatalErrorEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV2FatalErrorEventType value)
        {
            return value switch
            {
                ListenV2FatalErrorEventType.Error => "Error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV2FatalErrorEventType? ToEnum(string value)
        {
            return value switch
            {
                "Error" => ListenV2FatalErrorEventType.Error,
                _ => null,
            };
        }
    }
}