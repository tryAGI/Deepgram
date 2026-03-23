
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Method type for the request
    /// </summary>
    public enum ManageV1ProjectsUsageBreakdownGetMethod
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
    public static class ManageV1ProjectsUsageBreakdownGetMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManageV1ProjectsUsageBreakdownGetMethod value)
        {
            return value switch
            {
                ManageV1ProjectsUsageBreakdownGetMethod.Async => "async",
                ManageV1ProjectsUsageBreakdownGetMethod.Streaming => "streaming",
                ManageV1ProjectsUsageBreakdownGetMethod.Sync => "sync",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManageV1ProjectsUsageBreakdownGetMethod? ToEnum(string value)
        {
            return value switch
            {
                "async" => ManageV1ProjectsUsageBreakdownGetMethod.Async,
                "streaming" => ManageV1ProjectsUsageBreakdownGetMethod.Streaming,
                "sync" => ManageV1ProjectsUsageBreakdownGetMethod.Sync,
                _ => null,
            };
        }
    }
}