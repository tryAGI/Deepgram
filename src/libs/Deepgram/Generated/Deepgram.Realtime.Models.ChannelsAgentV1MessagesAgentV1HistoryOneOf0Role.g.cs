
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Identifies who spoke the statement
    /// </summary>
    public enum ChannelsAgentV1MessagesAgentV1HistoryOneOf0Role
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsAgentV1MessagesAgentV1HistoryOneOf0RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsAgentV1MessagesAgentV1HistoryOneOf0Role value)
        {
            return value switch
            {
                ChannelsAgentV1MessagesAgentV1HistoryOneOf0Role.Assistant => "assistant",
                ChannelsAgentV1MessagesAgentV1HistoryOneOf0Role.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsAgentV1MessagesAgentV1HistoryOneOf0Role? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChannelsAgentV1MessagesAgentV1HistoryOneOf0Role.Assistant,
                "user" => ChannelsAgentV1MessagesAgentV1HistoryOneOf0Role.User,
                _ => null,
            };
        }
    }
}