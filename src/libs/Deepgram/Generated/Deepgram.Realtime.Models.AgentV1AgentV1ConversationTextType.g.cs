
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier for conversation text
    /// </summary>
    public enum AgentV1AgentV1ConversationTextType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1AgentV1ConversationTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1AgentV1ConversationTextType value)
        {
            return value switch
            {
                AgentV1AgentV1ConversationTextType.ConversationText => "ConversationText",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1AgentV1ConversationTextType? ToEnum(string value)
        {
            return value switch
            {
                "ConversationText" => AgentV1AgentV1ConversationTextType.ConversationText,
                _ => null,
            };
        }
    }
}