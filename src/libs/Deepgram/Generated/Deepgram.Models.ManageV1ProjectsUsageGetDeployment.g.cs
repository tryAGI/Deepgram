
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Deployment type for the requests
    /// </summary>
    public enum ManageV1ProjectsUsageGetDeployment
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
    public static class ManageV1ProjectsUsageGetDeploymentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManageV1ProjectsUsageGetDeployment value)
        {
            return value switch
            {
                ManageV1ProjectsUsageGetDeployment.Beta => "beta",
                ManageV1ProjectsUsageGetDeployment.Hosted => "hosted",
                ManageV1ProjectsUsageGetDeployment.SelfHosted => "self-hosted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManageV1ProjectsUsageGetDeployment? ToEnum(string value)
        {
            return value switch
            {
                "beta" => ManageV1ProjectsUsageGetDeployment.Beta,
                "hosted" => ManageV1ProjectsUsageGetDeployment.Hosted,
                "self-hosted" => ManageV1ProjectsUsageGetDeployment.SelfHosted,
                _ => null,
            };
        }
    }
}