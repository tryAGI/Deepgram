
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public enum ManageV1ProjectsUsageBreakdownGetGrouping
    {
        /// <summary>
        /// 
        /// </summary>
        Accessor,
        /// <summary>
        /// 
        /// </summary>
        Endpoint,
        /// <summary>
        /// 
        /// </summary>
        FeatureSet,
        /// <summary>
        /// 
        /// </summary>
        Models,
        /// <summary>
        /// 
        /// </summary>
        Method,
        /// <summary>
        /// 
        /// </summary>
        Tags,
        /// <summary>
        /// 
        /// </summary>
        Deployment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ManageV1ProjectsUsageBreakdownGetGroupingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManageV1ProjectsUsageBreakdownGetGrouping value)
        {
            return value switch
            {
                ManageV1ProjectsUsageBreakdownGetGrouping.Accessor => "accessor",
                ManageV1ProjectsUsageBreakdownGetGrouping.Endpoint => "endpoint",
                ManageV1ProjectsUsageBreakdownGetGrouping.FeatureSet => "feature_set",
                ManageV1ProjectsUsageBreakdownGetGrouping.Models => "models",
                ManageV1ProjectsUsageBreakdownGetGrouping.Method => "method",
                ManageV1ProjectsUsageBreakdownGetGrouping.Tags => "tags",
                ManageV1ProjectsUsageBreakdownGetGrouping.Deployment => "deployment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManageV1ProjectsUsageBreakdownGetGrouping? ToEnum(string value)
        {
            return value switch
            {
                "accessor" => ManageV1ProjectsUsageBreakdownGetGrouping.Accessor,
                "endpoint" => ManageV1ProjectsUsageBreakdownGetGrouping.Endpoint,
                "feature_set" => ManageV1ProjectsUsageBreakdownGetGrouping.FeatureSet,
                "models" => ManageV1ProjectsUsageBreakdownGetGrouping.Models,
                "method" => ManageV1ProjectsUsageBreakdownGetGrouping.Method,
                "tags" => ManageV1ProjectsUsageBreakdownGetGrouping.Tags,
                "deployment" => ManageV1ProjectsUsageBreakdownGetGrouping.Deployment,
                _ => null,
            };
        }
    }
}