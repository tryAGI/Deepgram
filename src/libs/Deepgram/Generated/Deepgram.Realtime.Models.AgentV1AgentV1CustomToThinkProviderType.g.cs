
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier for sending a custom payload to the think provider
    /// </summary>
    public enum AgentV1AgentV1CustomToThinkProviderType
    {
        /// <summary>
        ///
        /// </summary>
        CustomToThinkProvider,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1AgentV1CustomToThinkProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1AgentV1CustomToThinkProviderType value)
        {
            return value switch
            {
                AgentV1AgentV1CustomToThinkProviderType.CustomToThinkProvider => "__customToThinkProvider",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1AgentV1CustomToThinkProviderType? ToEnum(string value)
        {
            return value switch
            {
                "__customToThinkProvider" => AgentV1AgentV1CustomToThinkProviderType.CustomToThinkProvider,
                _ => null,
            };
        }
    }
}