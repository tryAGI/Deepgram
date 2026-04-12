
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier for error responses
    /// </summary>
    public enum ChannelsAgentV1MessagesAgentV1ErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsAgentV1MessagesAgentV1ErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsAgentV1MessagesAgentV1ErrorType value)
        {
            return value switch
            {
                ChannelsAgentV1MessagesAgentV1ErrorType.Error => "Error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsAgentV1MessagesAgentV1ErrorType? ToEnum(string value)
        {
            return value switch
            {
                "Error" => ChannelsAgentV1MessagesAgentV1ErrorType.Error,
                _ => null,
            };
        }
    }
}