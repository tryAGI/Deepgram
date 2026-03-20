
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public enum ManageV1ProjectsRequestsListEndpoint
    {
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
        /// <summary>
        /// 
        /// </summary>
        Agent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ManageV1ProjectsRequestsListEndpointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManageV1ProjectsRequestsListEndpoint value)
        {
            return value switch
            {
                ManageV1ProjectsRequestsListEndpoint.Listen => "listen",
                ManageV1ProjectsRequestsListEndpoint.Read => "read",
                ManageV1ProjectsRequestsListEndpoint.Speak => "speak",
                ManageV1ProjectsRequestsListEndpoint.Agent => "agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManageV1ProjectsRequestsListEndpoint? ToEnum(string value)
        {
            return value switch
            {
                "listen" => ManageV1ProjectsRequestsListEndpoint.Listen,
                "read" => ManageV1ProjectsRequestsListEndpoint.Read,
                "speak" => ManageV1ProjectsRequestsListEndpoint.Speak,
                "agent" => ManageV1ProjectsRequestsListEndpoint.Agent,
                _ => null,
            };
        }
    }
}