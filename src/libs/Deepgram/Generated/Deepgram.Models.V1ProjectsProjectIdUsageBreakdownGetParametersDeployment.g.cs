
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Deployment type for the requests
    /// </summary>
    public enum V1ProjectsProjectIdUsageBreakdownGetParametersDeployment
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
    public static class V1ProjectsProjectIdUsageBreakdownGetParametersDeploymentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ProjectsProjectIdUsageBreakdownGetParametersDeployment value)
        {
            return value switch
            {
                V1ProjectsProjectIdUsageBreakdownGetParametersDeployment.Beta => "beta",
                V1ProjectsProjectIdUsageBreakdownGetParametersDeployment.Hosted => "hosted",
                V1ProjectsProjectIdUsageBreakdownGetParametersDeployment.SelfHosted => "self-hosted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ProjectsProjectIdUsageBreakdownGetParametersDeployment? ToEnum(string value)
        {
            return value switch
            {
                "beta" => V1ProjectsProjectIdUsageBreakdownGetParametersDeployment.Beta,
                "hosted" => V1ProjectsProjectIdUsageBreakdownGetParametersDeployment.Hosted,
                "self-hosted" => V1ProjectsProjectIdUsageBreakdownGetParametersDeployment.SelfHosted,
                _ => null,
            };
        }
    }
}