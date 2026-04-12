
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1ProjectsProjectIdUsageGetParametersEndpoint
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
    public static class V1ProjectsProjectIdUsageGetParametersEndpointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ProjectsProjectIdUsageGetParametersEndpoint value)
        {
            return value switch
            {
                V1ProjectsProjectIdUsageGetParametersEndpoint.Agent => "agent",
                V1ProjectsProjectIdUsageGetParametersEndpoint.Listen => "listen",
                V1ProjectsProjectIdUsageGetParametersEndpoint.Read => "read",
                V1ProjectsProjectIdUsageGetParametersEndpoint.Speak => "speak",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ProjectsProjectIdUsageGetParametersEndpoint? ToEnum(string value)
        {
            return value switch
            {
                "agent" => V1ProjectsProjectIdUsageGetParametersEndpoint.Agent,
                "listen" => V1ProjectsProjectIdUsageGetParametersEndpoint.Listen,
                "read" => V1ProjectsProjectIdUsageGetParametersEndpoint.Read,
                "speak" => V1ProjectsProjectIdUsageGetParametersEndpoint.Speak,
                _ => null,
            };
        }
    }
}