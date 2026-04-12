
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Deployment type for the requests
    /// </summary>
    public enum V1ProjectsProjectIdRequestsGetParametersDeployment
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
    public static class V1ProjectsProjectIdRequestsGetParametersDeploymentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ProjectsProjectIdRequestsGetParametersDeployment value)
        {
            return value switch
            {
                V1ProjectsProjectIdRequestsGetParametersDeployment.Beta => "beta",
                V1ProjectsProjectIdRequestsGetParametersDeployment.Hosted => "hosted",
                V1ProjectsProjectIdRequestsGetParametersDeployment.SelfHosted => "self-hosted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ProjectsProjectIdRequestsGetParametersDeployment? ToEnum(string value)
        {
            return value switch
            {
                "beta" => V1ProjectsProjectIdRequestsGetParametersDeployment.Beta,
                "hosted" => V1ProjectsProjectIdRequestsGetParametersDeployment.Hosted,
                "self-hosted" => V1ProjectsProjectIdRequestsGetParametersDeployment.SelfHosted,
                _ => null,
            };
        }
    }
}