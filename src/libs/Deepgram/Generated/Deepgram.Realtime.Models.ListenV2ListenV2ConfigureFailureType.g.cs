
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ListenV2ListenV2ConfigureFailureType
    {
        /// <summary>
        /// 
        /// </summary>
        ConfigureFailure,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV2ListenV2ConfigureFailureTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV2ListenV2ConfigureFailureType value)
        {
            return value switch
            {
                ListenV2ListenV2ConfigureFailureType.ConfigureFailure => "ConfigureFailure",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV2ListenV2ConfigureFailureType? ToEnum(string value)
        {
            return value switch
            {
                "ConfigureFailure" => ListenV2ListenV2ConfigureFailureType.ConfigureFailure,
                _ => null,
            };
        }
    }
}