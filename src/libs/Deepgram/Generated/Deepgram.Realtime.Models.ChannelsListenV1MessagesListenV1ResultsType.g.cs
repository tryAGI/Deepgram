
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ChannelsListenV1MessagesListenV1ResultsType
    {
        /// <summary>
        /// 
        /// </summary>
        Results,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsListenV1MessagesListenV1ResultsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsListenV1MessagesListenV1ResultsType value)
        {
            return value switch
            {
                ChannelsListenV1MessagesListenV1ResultsType.Results => "Results",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsListenV1MessagesListenV1ResultsType? ToEnum(string value)
        {
            return value switch
            {
                "Results" => ChannelsListenV1MessagesListenV1ResultsType.Results,
                _ => null,
            };
        }
    }
}