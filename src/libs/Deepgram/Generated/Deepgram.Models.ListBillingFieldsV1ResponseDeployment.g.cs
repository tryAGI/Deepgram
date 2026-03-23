
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
        Beta,
        /// <summary>
        /// 
        /// </summary>
        Dedicated,
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
    public static class ListBillingFieldsV1ResponseDeploymentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListBillingFieldsV1ResponseDeployment value)
        {
            return value switch
            {
                ListBillingFieldsV1ResponseDeployment.Beta => "beta",
                ListBillingFieldsV1ResponseDeployment.Dedicated => "dedicated",
                ListBillingFieldsV1ResponseDeployment.Hosted => "hosted",
                ListBillingFieldsV1ResponseDeployment.SelfHosted => "self-hosted",
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
                "beta" => ListBillingFieldsV1ResponseDeployment.Beta,
                "dedicated" => ListBillingFieldsV1ResponseDeployment.Dedicated,
                "hosted" => ListBillingFieldsV1ResponseDeployment.Hosted,
                "self-hosted" => ListBillingFieldsV1ResponseDeployment.SelfHosted,
                _ => null,
            };
        }
    }
}