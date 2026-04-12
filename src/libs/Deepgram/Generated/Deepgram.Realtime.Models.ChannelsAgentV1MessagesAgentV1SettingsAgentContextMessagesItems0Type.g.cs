
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier for conversation text
    /// </summary>
    public enum ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0Type
    {
        /// <summary>
        /// 
        /// </summary>
        History,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0Type value)
        {
            return value switch
            {
                ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0Type.History => "History",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0Type? ToEnum(string value)
        {
            return value switch
            {
                "History" => ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0Type.History,
                _ => null,
            };
        }
    }
}