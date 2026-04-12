
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier for function call responses
    /// </summary>
    public enum AgentV1AgentV1SendFunctionCallResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        FunctionCallResponse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1AgentV1SendFunctionCallResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1AgentV1SendFunctionCallResponseType value)
        {
            return value switch
            {
                AgentV1AgentV1SendFunctionCallResponseType.FunctionCallResponse => "FunctionCallResponse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1AgentV1SendFunctionCallResponseType? ToEnum(string value)
        {
            return value switch
            {
                "FunctionCallResponse" => AgentV1AgentV1SendFunctionCallResponseType.FunctionCallResponse,
                _ => null,
            };
        }
    }
}