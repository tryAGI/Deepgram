
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Deployment type for the requests
    /// </summary>
    public enum ManageV1ProjectsRequestsListDeployment
    {
        /// <summary>
        /// 
        /// </summary>
        Hosted,
        /// <summary>
        /// 
        /// </summary>
        Beta,
        /// <summary>
        /// 
        /// </summary>
        SelfHosted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ManageV1ProjectsRequestsListDeploymentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManageV1ProjectsRequestsListDeployment value)
        {
            return value switch
            {
                ManageV1ProjectsRequestsListDeployment.Hosted => "hosted",
                ManageV1ProjectsRequestsListDeployment.Beta => "beta",
                ManageV1ProjectsRequestsListDeployment.SelfHosted => "self-hosted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManageV1ProjectsRequestsListDeployment? ToEnum(string value)
        {
            return value switch
            {
                "hosted" => ManageV1ProjectsRequestsListDeployment.Hosted,
                "beta" => ManageV1ProjectsRequestsListDeployment.Beta,
                "self-hosted" => ManageV1ProjectsRequestsListDeployment.SelfHosted,
                _ => null,
            };
        }
    }
}