
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1Type
    {
        /// <summary>
        /// 
        /// </summary>
        History,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1Type value)
        {
            return value switch
            {
                ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1Type.History => "History",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1Type? ToEnum(string value)
        {
            return value switch
            {
                "History" => ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1Type.History,
                _ => null,
            };
        }
    }
}