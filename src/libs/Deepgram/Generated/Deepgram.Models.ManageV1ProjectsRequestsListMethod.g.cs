
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Method type for the request
    /// </summary>
    public enum ManageV1ProjectsRequestsListMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Sync,
        /// <summary>
        /// 
        /// </summary>
        Async,
        /// <summary>
        /// 
        /// </summary>
        Streaming,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ManageV1ProjectsRequestsListMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManageV1ProjectsRequestsListMethod value)
        {
            return value switch
            {
                ManageV1ProjectsRequestsListMethod.Sync => "sync",
                ManageV1ProjectsRequestsListMethod.Async => "async",
                ManageV1ProjectsRequestsListMethod.Streaming => "streaming",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManageV1ProjectsRequestsListMethod? ToEnum(string value)
        {
            return value switch
            {
                "sync" => ManageV1ProjectsRequestsListMethod.Sync,
                "async" => ManageV1ProjectsRequestsListMethod.Async,
                "streaming" => ManageV1ProjectsRequestsListMethod.Streaming,
                _ => null,
            };
        }
    }
}