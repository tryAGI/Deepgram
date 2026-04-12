
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier for updating the speak model
    /// </summary>
    public enum AgentV1AgentV1UpdateSpeakType
    {
        /// <summary>
        /// 
        /// </summary>
        UpdateSpeak,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1AgentV1UpdateSpeakTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1AgentV1UpdateSpeakType value)
        {
            return value switch
            {
                AgentV1AgentV1UpdateSpeakType.UpdateSpeak => "UpdateSpeak",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1AgentV1UpdateSpeakType? ToEnum(string value)
        {
            return value switch
            {
                "UpdateSpeak" => AgentV1AgentV1UpdateSpeakType.UpdateSpeak,
                _ => null,
            };
        }
    }
}