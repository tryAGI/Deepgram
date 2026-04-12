
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier for injection refused
    /// </summary>
    public enum AgentV1AgentV1InjectionRefusedType
    {
        /// <summary>
        /// 
        /// </summary>
        InjectionRefused,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1AgentV1InjectionRefusedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1AgentV1InjectionRefusedType value)
        {
            return value switch
            {
                AgentV1AgentV1InjectionRefusedType.InjectionRefused => "InjectionRefused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1AgentV1InjectionRefusedType? ToEnum(string value)
        {
            return value switch
            {
                "InjectionRefused" => AgentV1AgentV1InjectionRefusedType.InjectionRefused,
                _ => null,
            };
        }
    }
}