
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier for a custom payload returned by the think provider
    /// </summary>
    public enum AgentV1AgentV1CustomFromThinkProviderType
    {
        /// <summary>
        ///
        /// </summary>
        CustomFromThinkProvider,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1AgentV1CustomFromThinkProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1AgentV1CustomFromThinkProviderType value)
        {
            return value switch
            {
                AgentV1AgentV1CustomFromThinkProviderType.CustomFromThinkProvider => "__customFromThinkProvider",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1AgentV1CustomFromThinkProviderType? ToEnum(string value)
        {
            return value switch
            {
                "__customFromThinkProvider" => AgentV1AgentV1CustomFromThinkProviderType.CustomFromThinkProvider,
                _ => null,
            };
        }
    }
}