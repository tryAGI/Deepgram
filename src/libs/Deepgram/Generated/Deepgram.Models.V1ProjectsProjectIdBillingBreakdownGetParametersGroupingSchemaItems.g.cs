
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems
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
    public static class V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems value)
        {
            return value switch
            {
                V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems.Accessor => "accessor",
                V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems.Deployment => "deployment",
                V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems.LineItem => "line_item",
                V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems.Tags => "tags",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems? ToEnum(string value)
        {
            return value switch
            {
                "accessor" => V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems.Accessor,
                "deployment" => V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems.Deployment,
                "line_item" => V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems.LineItem,
                "tags" => V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems.Tags,
                _ => null,
            };
        }
    }
}