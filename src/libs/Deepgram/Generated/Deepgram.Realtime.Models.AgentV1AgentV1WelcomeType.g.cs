
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier for welcome message
    /// </summary>
    public enum AgentV1AgentV1WelcomeType
    {
        /// <summary>
        /// 
        /// </summary>
        Welcome,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1AgentV1WelcomeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1AgentV1WelcomeType value)
        {
            return value switch
            {
                AgentV1AgentV1WelcomeType.Welcome => "Welcome",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1AgentV1WelcomeType? ToEnum(string value)
        {
            return value switch
            {
                "Welcome" => AgentV1AgentV1WelcomeType.Welcome,
                _ => null,
            };
        }
    }
}