
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListenV2ListenV2TurnInfoType
    {
        /// <summary>
        /// 
        /// </summary>
        TurnInfo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV2ListenV2TurnInfoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV2ListenV2TurnInfoType value)
        {
            return value switch
            {
                ListenV2ListenV2TurnInfoType.TurnInfo => "TurnInfo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV2ListenV2TurnInfoType? ToEnum(string value)
        {
            return value switch
            {
                "TurnInfo" => ListenV2ListenV2TurnInfoType.TurnInfo,
                _ => null,
            };
        }
    }
}