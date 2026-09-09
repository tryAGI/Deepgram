
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier for cancelled function calls
    /// </summary>
    public enum AgentV1AgentV1FunctionCallCancelledType
    {
        /// <summary>
        ///
        /// </summary>
        FunctionCallCancelled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1AgentV1FunctionCallCancelledTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1AgentV1FunctionCallCancelledType value)
        {
            return value switch
            {
                AgentV1AgentV1FunctionCallCancelledType.FunctionCallCancelled => "FunctionCallCancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1AgentV1FunctionCallCancelledType? ToEnum(string value)
        {
            return value switch
            {
                "FunctionCallCancelled" => AgentV1AgentV1FunctionCallCancelledType.FunctionCallCancelled,
                _ => null,
            };
        }
    }
}