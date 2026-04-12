
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier for settings applied confirmation
    /// </summary>
    public enum AgentV1AgentV1SettingsAppliedType
    {
        /// <summary>
        /// 
        /// </summary>
        SettingsApplied,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1AgentV1SettingsAppliedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1AgentV1SettingsAppliedType value)
        {
            return value switch
            {
                AgentV1AgentV1SettingsAppliedType.SettingsApplied => "SettingsApplied",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1AgentV1SettingsAppliedType? ToEnum(string value)
        {
            return value switch
            {
                "SettingsApplied" => AgentV1AgentV1SettingsAppliedType.SettingsApplied,
                _ => null,
            };
        }
    }
}