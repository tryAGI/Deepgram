
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier for frustration detection
    /// </summary>
    public enum AgentV1AgentV1FrustrationDetectedType
    {
        /// <summary>
        ///
        /// </summary>
        FrustrationDetected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1AgentV1FrustrationDetectedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1AgentV1FrustrationDetectedType value)
        {
            return value switch
            {
                AgentV1AgentV1FrustrationDetectedType.FrustrationDetected => "FrustrationDetected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1AgentV1FrustrationDetectedType? ToEnum(string value)
        {
            return value switch
            {
                "FrustrationDetected" => AgentV1AgentV1FrustrationDetectedType.FrustrationDetected,
                _ => null,
            };
        }
    }
}