
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
        ConfigureFailure,
        /// <summary>
        /// 
        /// </summary>
        ConfigureSuccess,
        /// <summary>
        /// 
        /// </summary>
        Connected,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        TurnInfo,
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
                ListenV2ServerEventDiscriminatorType.ConfigureFailure => "ConfigureFailure",
                ListenV2ServerEventDiscriminatorType.ConfigureSuccess => "ConfigureSuccess",
                ListenV2ServerEventDiscriminatorType.Connected => "Connected",
                ListenV2ServerEventDiscriminatorType.Error => "Error",
                ListenV2ServerEventDiscriminatorType.TurnInfo => "TurnInfo",
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
                "ConfigureFailure" => ListenV2ServerEventDiscriminatorType.ConfigureFailure,
                "ConfigureSuccess" => ListenV2ServerEventDiscriminatorType.ConfigureSuccess,
                "Connected" => ListenV2ServerEventDiscriminatorType.Connected,
                "Error" => ListenV2ServerEventDiscriminatorType.Error,
                "TurnInfo" => ListenV2ServerEventDiscriminatorType.TurnInfo,
                _ => null,
            };
        }
    }
}