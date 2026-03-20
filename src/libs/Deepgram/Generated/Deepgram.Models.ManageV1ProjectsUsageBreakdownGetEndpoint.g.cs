
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public enum ManageV1ProjectsUsageBreakdownGetEndpoint
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
    public static class ManageV1ProjectsUsageBreakdownGetEndpointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManageV1ProjectsUsageBreakdownGetEndpoint value)
        {
            return value switch
            {
                ManageV1ProjectsUsageBreakdownGetEndpoint.Listen => "listen",
                ManageV1ProjectsUsageBreakdownGetEndpoint.Read => "read",
                ManageV1ProjectsUsageBreakdownGetEndpoint.Speak => "speak",
                ManageV1ProjectsUsageBreakdownGetEndpoint.Agent => "agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManageV1ProjectsUsageBreakdownGetEndpoint? ToEnum(string value)
        {
            return value switch
            {
                "listen" => ManageV1ProjectsUsageBreakdownGetEndpoint.Listen,
                "read" => ManageV1ProjectsUsageBreakdownGetEndpoint.Read,
                "speak" => ManageV1ProjectsUsageBreakdownGetEndpoint.Speak,
                "agent" => ManageV1ProjectsUsageBreakdownGetEndpoint.Agent,
                _ => null,
            };
        }
    }
}