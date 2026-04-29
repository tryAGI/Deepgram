
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier for conversation text
    /// </summary>
    public enum AgentV1AgentV1History0Type
    {
        /// <summary>
        /// 
        /// </summary>
        History,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1AgentV1History0TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1AgentV1History0Type value)
        {
            return value switch
            {
                AgentV1AgentV1History0Type.History => "History",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1AgentV1History0Type? ToEnum(string value)
        {
            return value switch
            {
                "History" => AgentV1AgentV1History0Type.History,
                _ => null,
            };
        }
    }
}