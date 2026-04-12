
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListBillingFieldsV1ResponseDeploymentsItems
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
    public static class ListBillingFieldsV1ResponseDeploymentsItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListBillingFieldsV1ResponseDeploymentsItems value)
        {
            return value switch
            {
                ListBillingFieldsV1ResponseDeploymentsItems.Beta => "beta",
                ListBillingFieldsV1ResponseDeploymentsItems.Dedicated => "dedicated",
                ListBillingFieldsV1ResponseDeploymentsItems.Hosted => "hosted",
                ListBillingFieldsV1ResponseDeploymentsItems.SelfHosted => "self-hosted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListBillingFieldsV1ResponseDeploymentsItems? ToEnum(string value)
        {
            return value switch
            {
                "beta" => ListBillingFieldsV1ResponseDeploymentsItems.Beta,
                "dedicated" => ListBillingFieldsV1ResponseDeploymentsItems.Dedicated,
                "hosted" => ListBillingFieldsV1ResponseDeploymentsItems.Hosted,
                "self-hosted" => ListBillingFieldsV1ResponseDeploymentsItems.SelfHosted,
                _ => null,
            };
        }
    }
}