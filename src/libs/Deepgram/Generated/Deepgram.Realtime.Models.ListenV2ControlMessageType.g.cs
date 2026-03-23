
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ListenV2ControlMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        CloseStream,
        /// <summary>
        /// 
        /// </summary>
        Finalize,
        /// <summary>
        /// 
        /// </summary>
        KeepAlive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV2ControlMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV2ControlMessageType value)
        {
            return value switch
            {
                ListenV2ControlMessageType.CloseStream => "CloseStream",
                ListenV2ControlMessageType.Finalize => "Finalize",
                ListenV2ControlMessageType.KeepAlive => "KeepAlive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV2ControlMessageType? ToEnum(string value)
        {
            return value switch
            {
                "CloseStream" => ListenV2ControlMessageType.CloseStream,
                "Finalize" => ListenV2ControlMessageType.Finalize,
                "KeepAlive" => ListenV2ControlMessageType.KeepAlive,
                _ => null,
            };
        }
    }
}