
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier for function call requests
    /// </summary>
    public enum AgentV1AgentV1FunctionCallRequestType
    {
        /// <summary>
        /// 
        /// </summary>
        FunctionCallRequest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1AgentV1FunctionCallRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1AgentV1FunctionCallRequestType value)
        {
            return value switch
            {
                AgentV1AgentV1FunctionCallRequestType.FunctionCallRequest => "FunctionCallRequest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1AgentV1FunctionCallRequestType? ToEnum(string value)
        {
            return value switch
            {
                "FunctionCallRequest" => AgentV1AgentV1FunctionCallRequestType.FunctionCallRequest,
                _ => null,
            };
        }
    }
}