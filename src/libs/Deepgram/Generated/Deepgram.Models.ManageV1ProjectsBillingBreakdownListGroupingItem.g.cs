
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public enum ManageV1ProjectsBillingBreakdownListGroupingItem
    {
        /// <summary>
        /// 
        /// </summary>
        Accessor,
        /// <summary>
        /// 
        /// </summary>
        Deployment,
        /// <summary>
        /// 
        /// </summary>
        LineItem,
        /// <summary>
        /// 
        /// </summary>
        Tags,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ManageV1ProjectsBillingBreakdownListGroupingItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManageV1ProjectsBillingBreakdownListGroupingItem value)
        {
            return value switch
            {
                ManageV1ProjectsBillingBreakdownListGroupingItem.Accessor => "accessor",
                ManageV1ProjectsBillingBreakdownListGroupingItem.Deployment => "deployment",
                ManageV1ProjectsBillingBreakdownListGroupingItem.LineItem => "line_item",
                ManageV1ProjectsBillingBreakdownListGroupingItem.Tags => "tags",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManageV1ProjectsBillingBreakdownListGroupingItem? ToEnum(string value)
        {
            return value switch
            {
                "accessor" => ManageV1ProjectsBillingBreakdownListGroupingItem.Accessor,
                "deployment" => ManageV1ProjectsBillingBreakdownListGroupingItem.Deployment,
                "line_item" => ManageV1ProjectsBillingBreakdownListGroupingItem.LineItem,
                "tags" => ManageV1ProjectsBillingBreakdownListGroupingItem.Tags,
                _ => null,
            };
        }
    }
}