
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Deployment type for the requests
    /// </summary>
    public enum ManageV1ProjectsBillingBreakdownListDeployment
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
    public static class ManageV1ProjectsBillingBreakdownListDeploymentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManageV1ProjectsBillingBreakdownListDeployment value)
        {
            return value switch
            {
                ManageV1ProjectsBillingBreakdownListDeployment.Beta => "beta",
                ManageV1ProjectsBillingBreakdownListDeployment.Hosted => "hosted",
                ManageV1ProjectsBillingBreakdownListDeployment.SelfHosted => "self-hosted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManageV1ProjectsBillingBreakdownListDeployment? ToEnum(string value)
        {
            return value switch
            {
                "beta" => ManageV1ProjectsBillingBreakdownListDeployment.Beta,
                "hosted" => ManageV1ProjectsBillingBreakdownListDeployment.Hosted,
                "self-hosted" => ManageV1ProjectsBillingBreakdownListDeployment.SelfHosted,
                _ => null,
            };
        }
    }
}