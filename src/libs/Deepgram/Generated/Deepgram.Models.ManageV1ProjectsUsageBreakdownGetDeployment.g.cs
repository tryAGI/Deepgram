
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Deployment type for the requests
    /// </summary>
    public enum ManageV1ProjectsUsageBreakdownGetDeployment
    {
        /// <summary>
        /// 
        /// </summary>
        Beta,
        /// <summary>
        /// 
        /// </summary>
        Hosted,
        /// <summary>
        /// 
        /// </summary>
        SelfHosted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ManageV1ProjectsUsageBreakdownGetDeploymentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManageV1ProjectsUsageBreakdownGetDeployment value)
        {
            return value switch
            {
                ManageV1ProjectsUsageBreakdownGetDeployment.Beta => "beta",
                ManageV1ProjectsUsageBreakdownGetDeployment.Hosted => "hosted",
                ManageV1ProjectsUsageBreakdownGetDeployment.SelfHosted => "self-hosted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManageV1ProjectsUsageBreakdownGetDeployment? ToEnum(string value)
        {
            return value switch
            {
                "beta" => ManageV1ProjectsUsageBreakdownGetDeployment.Beta,
                "hosted" => ManageV1ProjectsUsageBreakdownGetDeployment.Hosted,
                "self-hosted" => ManageV1ProjectsUsageBreakdownGetDeployment.SelfHosted,
                _ => null,
            };
        }
    }
}