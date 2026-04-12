
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Deployment type for the requests
    /// </summary>
    public enum V1ProjectsProjectIdUsageGetParametersDeployment
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
    public static class V1ProjectsProjectIdUsageGetParametersDeploymentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ProjectsProjectIdUsageGetParametersDeployment value)
        {
            return value switch
            {
                V1ProjectsProjectIdUsageGetParametersDeployment.Beta => "beta",
                V1ProjectsProjectIdUsageGetParametersDeployment.Hosted => "hosted",
                V1ProjectsProjectIdUsageGetParametersDeployment.SelfHosted => "self-hosted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ProjectsProjectIdUsageGetParametersDeployment? ToEnum(string value)
        {
            return value switch
            {
                "beta" => V1ProjectsProjectIdUsageGetParametersDeployment.Beta,
                "hosted" => V1ProjectsProjectIdUsageGetParametersDeployment.Hosted,
                "self-hosted" => V1ProjectsProjectIdUsageGetParametersDeployment.SelfHosted,
                _ => null,
            };
        }
    }
}