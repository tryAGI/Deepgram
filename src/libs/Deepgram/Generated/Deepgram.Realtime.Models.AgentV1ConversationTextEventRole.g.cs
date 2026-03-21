
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Identifies who spoke the statement
    /// </summary>
    public enum AgentV1ConversationTextEventRole
    {
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1ConversationTextEventRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1ConversationTextEventRole value)
        {
            return value switch
            {
                AgentV1ConversationTextEventRole.User => "user",
                AgentV1ConversationTextEventRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1ConversationTextEventRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => AgentV1ConversationTextEventRole.User,
                "assistant" => AgentV1ConversationTextEventRole.Assistant,
                _ => null,
            };
        }
    }
}