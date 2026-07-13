
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier for the latency report
    /// </summary>
    public enum AgentV1AgentV1LatencyReportType
    {
        /// <summary>
        /// 
        /// </summary>
        LatencyReport,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1AgentV1LatencyReportTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1AgentV1LatencyReportType value)
        {
            return value switch
            {
                AgentV1AgentV1LatencyReportType.LatencyReport => "LatencyReport",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1AgentV1LatencyReportType? ToEnum(string value)
        {
            return value switch
            {
                "LatencyReport" => AgentV1AgentV1LatencyReportType.LatencyReport,
                _ => null,
            };
        }
    }
}