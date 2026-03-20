
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListBillingFieldsV1ResponseDeployment
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
        /// <summary>
        /// 
        /// </summary>
        Dedicated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListBillingFieldsV1ResponseDeploymentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListBillingFieldsV1ResponseDeployment value)
        {
            return value switch
            {
                ListBillingFieldsV1ResponseDeployment.Hosted => "hosted",
                ListBillingFieldsV1ResponseDeployment.Beta => "beta",
                ListBillingFieldsV1ResponseDeployment.SelfHosted => "self-hosted",
                ListBillingFieldsV1ResponseDeployment.Dedicated => "dedicated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListBillingFieldsV1ResponseDeployment? ToEnum(string value)
        {
            return value switch
            {
                "hosted" => ListBillingFieldsV1ResponseDeployment.Hosted,
                "beta" => ListBillingFieldsV1ResponseDeployment.Beta,
                "self-hosted" => ListBillingFieldsV1ResponseDeployment.SelfHosted,
                "dedicated" => ListBillingFieldsV1ResponseDeployment.Dedicated,
                _ => null,
            };
        }
    }
}