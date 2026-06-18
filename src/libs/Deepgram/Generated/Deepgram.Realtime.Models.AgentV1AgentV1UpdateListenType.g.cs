
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier for updating the listen configuration
    /// </summary>
    public enum AgentV1AgentV1UpdateListenType
    {
        /// <summary>
        /// 
        /// </summary>
        UpdateListen,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1AgentV1UpdateListenTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1AgentV1UpdateListenType value)
        {
            return value switch
            {
                AgentV1AgentV1UpdateListenType.UpdateListen => "UpdateListen",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1AgentV1UpdateListenType? ToEnum(string value)
        {
            return value switch
            {
                "UpdateListen" => AgentV1AgentV1UpdateListenType.UpdateListen,
                _ => null,
            };
        }
    }
}