
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
    public static class ManageV1ProjectsUsageBreakdownGetEndpointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManageV1ProjectsUsageBreakdownGetEndpoint value)
        {
            return value switch
            {
                ManageV1ProjectsUsageBreakdownGetEndpoint.Agent => "agent",
                ManageV1ProjectsUsageBreakdownGetEndpoint.Listen => "listen",
                ManageV1ProjectsUsageBreakdownGetEndpoint.Read => "read",
                ManageV1ProjectsUsageBreakdownGetEndpoint.Speak => "speak",
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
                "agent" => ManageV1ProjectsUsageBreakdownGetEndpoint.Agent,
                "listen" => ManageV1ProjectsUsageBreakdownGetEndpoint.Listen,
                "read" => ManageV1ProjectsUsageBreakdownGetEndpoint.Read,
                "speak" => ManageV1ProjectsUsageBreakdownGetEndpoint.Speak,
                _ => null,
            };
        }
    }
}