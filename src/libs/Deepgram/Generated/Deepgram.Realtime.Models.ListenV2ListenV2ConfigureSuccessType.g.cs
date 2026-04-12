
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ListenV2ListenV2ConfigureSuccessType
    {
        /// <summary>
        /// 
        /// </summary>
        ConfigureSuccess,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV2ListenV2ConfigureSuccessTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV2ListenV2ConfigureSuccessType value)
        {
            return value switch
            {
                ListenV2ListenV2ConfigureSuccessType.ConfigureSuccess => "ConfigureSuccess",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV2ListenV2ConfigureSuccessType? ToEnum(string value)
        {
            return value switch
            {
                "ConfigureSuccess" => ListenV2ListenV2ConfigureSuccessType.ConfigureSuccess,
                _ => null,
            };
        }
    }
}