
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListenV2ServerEventDiscriminatorMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        ConfigureFailure,
        /// <summary>
        /// 
        /// </summary>
        ConfigureSuccess,
        /// <summary>
        /// 
        /// </summary>
        TurnInfo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV2ServerEventDiscriminatorMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV2ServerEventDiscriminatorMessageType value)
        {
            return value switch
            {
                ListenV2ServerEventDiscriminatorMessageType.ConfigureFailure => "ConfigureFailure",
                ListenV2ServerEventDiscriminatorMessageType.ConfigureSuccess => "ConfigureSuccess",
                ListenV2ServerEventDiscriminatorMessageType.TurnInfo => "TurnInfo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV2ServerEventDiscriminatorMessageType? ToEnum(string value)
        {
            return value switch
            {
                "ConfigureFailure" => ListenV2ServerEventDiscriminatorMessageType.ConfigureFailure,
                "ConfigureSuccess" => ListenV2ServerEventDiscriminatorMessageType.ConfigureSuccess,
                "TurnInfo" => ListenV2ServerEventDiscriminatorMessageType.TurnInfo,
                _ => null,
            };
        }
    }
}