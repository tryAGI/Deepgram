
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public enum ManageV1ProjectsRequestsListStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ManageV1ProjectsRequestsListStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManageV1ProjectsRequestsListStatus value)
        {
            return value switch
            {
                ManageV1ProjectsRequestsListStatus.Failed => "failed",
                ManageV1ProjectsRequestsListStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManageV1ProjectsRequestsListStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => ManageV1ProjectsRequestsListStatus.Failed,
                "succeeded" => ManageV1ProjectsRequestsListStatus.Succeeded,
                _ => null,
            };
        }
    }
}