
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentV1AgentV1History1Type
    {
        /// <summary>
        /// 
        /// </summary>
        History,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1AgentV1History1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1AgentV1History1Type value)
        {
            return value switch
            {
                AgentV1AgentV1History1Type.History => "History",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1AgentV1History1Type? ToEnum(string value)
        {
            return value switch
            {
                "History" => AgentV1AgentV1History1Type.History,
                _ => null,
            };
        }
    }
}