
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Deployment type for the requests
    /// </summary>
    public enum V1ProjectsProjectIdBillingBreakdownGetParametersDeployment
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
    public static class V1ProjectsProjectIdBillingBreakdownGetParametersDeploymentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ProjectsProjectIdBillingBreakdownGetParametersDeployment value)
        {
            return value switch
            {
                V1ProjectsProjectIdBillingBreakdownGetParametersDeployment.Beta => "beta",
                V1ProjectsProjectIdBillingBreakdownGetParametersDeployment.Hosted => "hosted",
                V1ProjectsProjectIdBillingBreakdownGetParametersDeployment.SelfHosted => "self-hosted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ProjectsProjectIdBillingBreakdownGetParametersDeployment? ToEnum(string value)
        {
            return value switch
            {
                "beta" => V1ProjectsProjectIdBillingBreakdownGetParametersDeployment.Beta,
                "hosted" => V1ProjectsProjectIdBillingBreakdownGetParametersDeployment.Hosted,
                "self-hosted" => V1ProjectsProjectIdBillingBreakdownGetParametersDeployment.SelfHosted,
                _ => null,
            };
        }
    }
}