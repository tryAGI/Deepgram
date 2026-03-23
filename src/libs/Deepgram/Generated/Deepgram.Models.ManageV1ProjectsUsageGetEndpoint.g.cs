
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public enum ManageV1ProjectsUsageGetEndpoint
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
    public static class ManageV1ProjectsUsageGetEndpointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManageV1ProjectsUsageGetEndpoint value)
        {
            return value switch
            {
                ManageV1ProjectsUsageGetEndpoint.Agent => "agent",
                ManageV1ProjectsUsageGetEndpoint.Listen => "listen",
                ManageV1ProjectsUsageGetEndpoint.Read => "read",
                ManageV1ProjectsUsageGetEndpoint.Speak => "speak",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManageV1ProjectsUsageGetEndpoint? ToEnum(string value)
        {
            return value switch
            {
                "agent" => ManageV1ProjectsUsageGetEndpoint.Agent,
                "listen" => ManageV1ProjectsUsageGetEndpoint.Listen,
                "read" => ManageV1ProjectsUsageGetEndpoint.Read,
                "speak" => ManageV1ProjectsUsageGetEndpoint.Speak,
                _ => null,
            };
        }
    }
}