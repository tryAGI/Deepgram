
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
    public static class ManageV1ProjectsRequestsListMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManageV1ProjectsRequestsListMethod value)
        {
            return value switch
            {
                ManageV1ProjectsRequestsListMethod.Async => "async",
                ManageV1ProjectsRequestsListMethod.Streaming => "streaming",
                ManageV1ProjectsRequestsListMethod.Sync => "sync",
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
                "async" => ManageV1ProjectsRequestsListMethod.Async,
                "streaming" => ManageV1ProjectsRequestsListMethod.Streaming,
                "sync" => ManageV1ProjectsRequestsListMethod.Sync,
                _ => null,
            };
        }
    }
}