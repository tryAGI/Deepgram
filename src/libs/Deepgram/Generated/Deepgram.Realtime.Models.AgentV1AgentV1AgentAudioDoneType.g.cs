
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier indicating the agent has finished sending audio
    /// </summary>
    public enum AgentV1AgentV1AgentAudioDoneType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentAudioDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1AgentV1AgentAudioDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1AgentV1AgentAudioDoneType value)
        {
            return value switch
            {
                AgentV1AgentV1AgentAudioDoneType.AgentAudioDone => "AgentAudioDone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1AgentV1AgentAudioDoneType? ToEnum(string value)
        {
            return value switch
            {
                "AgentAudioDone" => AgentV1AgentV1AgentAudioDoneType.AgentAudioDone,
                _ => null,
            };
        }
    }
}