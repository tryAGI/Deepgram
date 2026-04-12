
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Method type for the request
    /// </summary>
    public enum V1ProjectsProjectIdRequestsGetParametersMethod
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
    public static class V1ProjectsProjectIdRequestsGetParametersMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ProjectsProjectIdRequestsGetParametersMethod value)
        {
            return value switch
            {
                V1ProjectsProjectIdRequestsGetParametersMethod.Async => "async",
                V1ProjectsProjectIdRequestsGetParametersMethod.Streaming => "streaming",
                V1ProjectsProjectIdRequestsGetParametersMethod.Sync => "sync",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ProjectsProjectIdRequestsGetParametersMethod? ToEnum(string value)
        {
            return value switch
            {
                "async" => V1ProjectsProjectIdRequestsGetParametersMethod.Async,
                "streaming" => V1ProjectsProjectIdRequestsGetParametersMethod.Streaming,
                "sync" => V1ProjectsProjectIdRequestsGetParametersMethod.Sync,
                _ => null,
            };
        }
    }
}