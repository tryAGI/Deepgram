
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Method type for the request
    /// </summary>
    public enum V1ProjectsProjectIdUsageBreakdownGetParametersMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Async,
        /// <summary>
        /// 
        /// </summary>
        Streaming,
        /// <summary>
        /// 
        /// </summary>
        Sync,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1ProjectsProjectIdUsageBreakdownGetParametersMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ProjectsProjectIdUsageBreakdownGetParametersMethod value)
        {
            return value switch
            {
                V1ProjectsProjectIdUsageBreakdownGetParametersMethod.Async => "async",
                V1ProjectsProjectIdUsageBreakdownGetParametersMethod.Streaming => "streaming",
                V1ProjectsProjectIdUsageBreakdownGetParametersMethod.Sync => "sync",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ProjectsProjectIdUsageBreakdownGetParametersMethod? ToEnum(string value)
        {
            return value switch
            {
                "async" => V1ProjectsProjectIdUsageBreakdownGetParametersMethod.Async,
                "streaming" => V1ProjectsProjectIdUsageBreakdownGetParametersMethod.Streaming,
                "sync" => V1ProjectsProjectIdUsageBreakdownGetParametersMethod.Sync,
                _ => null,
            };
        }
    }
}