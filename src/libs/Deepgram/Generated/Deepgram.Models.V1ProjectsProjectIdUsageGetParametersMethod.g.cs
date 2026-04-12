
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Method type for the request
    /// </summary>
    public enum V1ProjectsProjectIdUsageGetParametersMethod
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
    public static class V1ProjectsProjectIdUsageGetParametersMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ProjectsProjectIdUsageGetParametersMethod value)
        {
            return value switch
            {
                V1ProjectsProjectIdUsageGetParametersMethod.Async => "async",
                V1ProjectsProjectIdUsageGetParametersMethod.Streaming => "streaming",
                V1ProjectsProjectIdUsageGetParametersMethod.Sync => "sync",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ProjectsProjectIdUsageGetParametersMethod? ToEnum(string value)
        {
            return value switch
            {
                "async" => V1ProjectsProjectIdUsageGetParametersMethod.Async,
                "streaming" => V1ProjectsProjectIdUsageGetParametersMethod.Streaming,
                "sync" => V1ProjectsProjectIdUsageGetParametersMethod.Sync,
                _ => null,
            };
        }
    }
}