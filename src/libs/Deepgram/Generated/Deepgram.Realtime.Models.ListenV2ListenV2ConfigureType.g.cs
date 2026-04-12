
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ListenV2ListenV2ConfigureType
    {
        /// <summary>
        /// 
        /// </summary>
        Configure,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV2ListenV2ConfigureTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV2ListenV2ConfigureType value)
        {
            return value switch
            {
                ListenV2ListenV2ConfigureType.Configure => "Configure",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV2ListenV2ConfigureType? ToEnum(string value)
        {
            return value switch
            {
                "Configure" => ListenV2ListenV2ConfigureType.Configure,
                _ => null,
            };
        }
    }
}