
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Identifies who spoke the statement
    /// </summary>
    public enum AgentV1SettingsMessageAgentContextMessageVariant1Role
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
    public static class AgentV1SettingsMessageAgentContextMessageVariant1RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1SettingsMessageAgentContextMessageVariant1Role value)
        {
            return value switch
            {
                AgentV1SettingsMessageAgentContextMessageVariant1Role.Assistant => "assistant",
                AgentV1SettingsMessageAgentContextMessageVariant1Role.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1SettingsMessageAgentContextMessageVariant1Role? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AgentV1SettingsMessageAgentContextMessageVariant1Role.Assistant,
                "user" => AgentV1SettingsMessageAgentContextMessageVariant1Role.User,
                _ => null,
            };
        }
    }
}