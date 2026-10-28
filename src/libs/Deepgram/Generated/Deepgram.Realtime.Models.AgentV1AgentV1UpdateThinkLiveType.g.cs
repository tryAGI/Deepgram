
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier for updating the Think Live model configuration
    /// </summary>
    public enum AgentV1AgentV1UpdateThinkLiveType
    {
        /// <summary>
        ///
        /// </summary>
        UpdateThinkLive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1AgentV1UpdateThinkLiveTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1AgentV1UpdateThinkLiveType value)
        {
            return value switch
            {
                AgentV1AgentV1UpdateThinkLiveType.UpdateThinkLive => "UpdateThink_Live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1AgentV1UpdateThinkLiveType? ToEnum(string value)
        {
            return value switch
            {
                "UpdateThink_Live" => AgentV1AgentV1UpdateThinkLiveType.UpdateThinkLive,
                _ => null,
            };
        }
    }
}