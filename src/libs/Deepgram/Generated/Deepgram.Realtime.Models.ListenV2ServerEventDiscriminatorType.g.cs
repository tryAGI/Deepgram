
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListenV2ServerEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Connected,
        /// <summary>
        /// 
        /// </summary>
        TurnInfo,
        /// <summary>
        /// 
        /// </summary>
        ConfigureSuccess,
        /// <summary>
        /// 
        /// </summary>
        ConfigureFailure,
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV2ServerEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV2ServerEventDiscriminatorType value)
        {
            return value switch
            {
                ListenV2ServerEventDiscriminatorType.Connected => "Connected",
                ListenV2ServerEventDiscriminatorType.TurnInfo => "TurnInfo",
                ListenV2ServerEventDiscriminatorType.ConfigureSuccess => "ConfigureSuccess",
                ListenV2ServerEventDiscriminatorType.ConfigureFailure => "ConfigureFailure",
                ListenV2ServerEventDiscriminatorType.Error => "Error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV2ServerEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "Connected" => ListenV2ServerEventDiscriminatorType.Connected,
                "TurnInfo" => ListenV2ServerEventDiscriminatorType.TurnInfo,
                "ConfigureSuccess" => ListenV2ServerEventDiscriminatorType.ConfigureSuccess,
                "ConfigureFailure" => ListenV2ServerEventDiscriminatorType.ConfigureFailure,
                "Error" => ListenV2ServerEventDiscriminatorType.Error,
                _ => null,
            };
        }
    }
}