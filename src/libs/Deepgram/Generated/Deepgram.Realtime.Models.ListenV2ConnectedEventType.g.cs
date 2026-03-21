
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ListenV2ConnectedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Connected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV2ConnectedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV2ConnectedEventType value)
        {
            return value switch
            {
                ListenV2ConnectedEventType.Connected => "Connected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV2ConnectedEventType? ToEnum(string value)
        {
            return value switch
            {
                "Connected" => ListenV2ConnectedEventType.Connected,
                _ => null,
            };
        }
    }
}