
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint
    {
        /// <summary>
        /// 
        /// </summary>
        Agent,
        /// <summary>
        /// 
        /// </summary>
        Listen,
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Speak,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1ProjectsProjectIdUsageBreakdownGetParametersEndpointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint value)
        {
            return value switch
            {
                V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint.Agent => "agent",
                V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint.Listen => "listen",
                V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint.Read => "read",
                V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint.Speak => "speak",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint? ToEnum(string value)
        {
            return value switch
            {
                "agent" => V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint.Agent,
                "listen" => V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint.Listen,
                "read" => V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint.Read,
                "speak" => V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint.Speak,
                _ => null,
            };
        }
    }
}