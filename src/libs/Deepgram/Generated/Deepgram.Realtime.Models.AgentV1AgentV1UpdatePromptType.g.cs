
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier for prompt update request
    /// </summary>
    public enum AgentV1AgentV1UpdatePromptType
    {
        /// <summary>
        /// 
        /// </summary>
        UpdatePrompt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1AgentV1UpdatePromptTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1AgentV1UpdatePromptType value)
        {
            return value switch
            {
                AgentV1AgentV1UpdatePromptType.UpdatePrompt => "UpdatePrompt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1AgentV1UpdatePromptType? ToEnum(string value)
        {
            return value switch
            {
                "UpdatePrompt" => AgentV1AgentV1UpdatePromptType.UpdatePrompt,
                _ => null,
            };
        }
    }
}