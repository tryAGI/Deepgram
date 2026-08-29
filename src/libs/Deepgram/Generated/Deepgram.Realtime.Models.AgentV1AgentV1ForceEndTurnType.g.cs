
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier for forcing the end of the current turn
    /// </summary>
    public enum AgentV1AgentV1ForceEndTurnType
    {
        /// <summary>
        ///
        /// </summary>
        ForceEndTurn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1AgentV1ForceEndTurnTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1AgentV1ForceEndTurnType value)
        {
            return value switch
            {
                AgentV1AgentV1ForceEndTurnType.ForceEndTurn => "ForceEndTurn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1AgentV1ForceEndTurnType? ToEnum(string value)
        {
            return value switch
            {
                "ForceEndTurn" => AgentV1AgentV1ForceEndTurnType.ForceEndTurn,
                _ => null,
            };
        }
    }
}