
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier for updating the think model
    /// </summary>
    public enum AgentV1AgentV1UpdateThinkType
    {
        /// <summary>
        /// 
        /// </summary>
        UpdateThink,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1AgentV1UpdateThinkTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1AgentV1UpdateThinkType value)
        {
            return value switch
            {
                AgentV1AgentV1UpdateThinkType.UpdateThink => "UpdateThink",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1AgentV1UpdateThinkType? ToEnum(string value)
        {
            return value switch
            {
                "UpdateThink" => AgentV1AgentV1UpdateThinkType.UpdateThink,
                _ => null,
            };
        }
    }
}