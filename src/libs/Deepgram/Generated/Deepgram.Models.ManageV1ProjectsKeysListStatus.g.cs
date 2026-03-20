
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public enum ManageV1ProjectsKeysListStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Expired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ManageV1ProjectsKeysListStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManageV1ProjectsKeysListStatus value)
        {
            return value switch
            {
                ManageV1ProjectsKeysListStatus.Active => "active",
                ManageV1ProjectsKeysListStatus.Expired => "expired",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManageV1ProjectsKeysListStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => ManageV1ProjectsKeysListStatus.Active,
                "expired" => ManageV1ProjectsKeysListStatus.Expired,
                _ => null,
            };
        }
    }
}