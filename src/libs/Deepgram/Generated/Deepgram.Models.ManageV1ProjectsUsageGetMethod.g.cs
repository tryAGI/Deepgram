
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Method type for the request
    /// </summary>
    public enum ManageV1ProjectsUsageGetMethod
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
    public static class ManageV1ProjectsUsageGetMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManageV1ProjectsUsageGetMethod value)
        {
            return value switch
            {
                ManageV1ProjectsUsageGetMethod.Async => "async",
                ManageV1ProjectsUsageGetMethod.Streaming => "streaming",
                ManageV1ProjectsUsageGetMethod.Sync => "sync",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManageV1ProjectsUsageGetMethod? ToEnum(string value)
        {
            return value switch
            {
                "async" => ManageV1ProjectsUsageGetMethod.Async,
                "streaming" => ManageV1ProjectsUsageGetMethod.Streaming,
                "sync" => ManageV1ProjectsUsageGetMethod.Sync,
                _ => null,
            };
        }
    }
}