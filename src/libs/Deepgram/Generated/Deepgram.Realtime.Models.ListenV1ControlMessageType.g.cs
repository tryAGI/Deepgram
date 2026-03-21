
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ListenV1ControlMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        Finalize,
        /// <summary>
        /// 
        /// </summary>
        CloseStream,
        /// <summary>
        /// 
        /// </summary>
        KeepAlive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV1ControlMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1ControlMessageType value)
        {
            return value switch
            {
                ListenV1ControlMessageType.Finalize => "Finalize",
                ListenV1ControlMessageType.CloseStream => "CloseStream",
                ListenV1ControlMessageType.KeepAlive => "KeepAlive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1ControlMessageType? ToEnum(string value)
        {
            return value switch
            {
                "Finalize" => ListenV1ControlMessageType.Finalize,
                "CloseStream" => ListenV1ControlMessageType.CloseStream,
                "KeepAlive" => ListenV1ControlMessageType.KeepAlive,
                _ => null,
            };
        }
    }
}