
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1ProjectsProjectIdUsageBreakdownGetParametersGrouping
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
        Endpoint,
        /// <summary>
        /// 
        /// </summary>
        FeatureSet,
        /// <summary>
        /// 
        /// </summary>
        Method,
        /// <summary>
        /// 
        /// </summary>
        Models,
        /// <summary>
        /// 
        /// </summary>
        Tags,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1ProjectsProjectIdUsageBreakdownGetParametersGroupingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ProjectsProjectIdUsageBreakdownGetParametersGrouping value)
        {
            return value switch
            {
                V1ProjectsProjectIdUsageBreakdownGetParametersGrouping.Accessor => "accessor",
                V1ProjectsProjectIdUsageBreakdownGetParametersGrouping.Deployment => "deployment",
                V1ProjectsProjectIdUsageBreakdownGetParametersGrouping.Endpoint => "endpoint",
                V1ProjectsProjectIdUsageBreakdownGetParametersGrouping.FeatureSet => "feature_set",
                V1ProjectsProjectIdUsageBreakdownGetParametersGrouping.Method => "method",
                V1ProjectsProjectIdUsageBreakdownGetParametersGrouping.Models => "models",
                V1ProjectsProjectIdUsageBreakdownGetParametersGrouping.Tags => "tags",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ProjectsProjectIdUsageBreakdownGetParametersGrouping? ToEnum(string value)
        {
            return value switch
            {
                "accessor" => V1ProjectsProjectIdUsageBreakdownGetParametersGrouping.Accessor,
                "deployment" => V1ProjectsProjectIdUsageBreakdownGetParametersGrouping.Deployment,
                "endpoint" => V1ProjectsProjectIdUsageBreakdownGetParametersGrouping.Endpoint,
                "feature_set" => V1ProjectsProjectIdUsageBreakdownGetParametersGrouping.FeatureSet,
                "method" => V1ProjectsProjectIdUsageBreakdownGetParametersGrouping.Method,
                "models" => V1ProjectsProjectIdUsageBreakdownGetParametersGrouping.Models,
                "tags" => V1ProjectsProjectIdUsageBreakdownGetParametersGrouping.Tags,
                _ => null,
            };
        }
    }
}