
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1ProjectsProjectIdRequestsGetParametersEndpoint
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
    public static class V1ProjectsProjectIdRequestsGetParametersEndpointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ProjectsProjectIdRequestsGetParametersEndpoint value)
        {
            return value switch
            {
                V1ProjectsProjectIdRequestsGetParametersEndpoint.Agent => "agent",
                V1ProjectsProjectIdRequestsGetParametersEndpoint.Listen => "listen",
                V1ProjectsProjectIdRequestsGetParametersEndpoint.Read => "read",
                V1ProjectsProjectIdRequestsGetParametersEndpoint.Speak => "speak",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ProjectsProjectIdRequestsGetParametersEndpoint? ToEnum(string value)
        {
            return value switch
            {
                "agent" => V1ProjectsProjectIdRequestsGetParametersEndpoint.Agent,
                "listen" => V1ProjectsProjectIdRequestsGetParametersEndpoint.Listen,
                "read" => V1ProjectsProjectIdRequestsGetParametersEndpoint.Read,
                "speak" => V1ProjectsProjectIdRequestsGetParametersEndpoint.Speak,
                _ => null,
            };
        }
    }
}