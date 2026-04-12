
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1ProjectsProjectIdKeysGetParametersStatus
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
    public static class V1ProjectsProjectIdKeysGetParametersStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ProjectsProjectIdKeysGetParametersStatus value)
        {
            return value switch
            {
                V1ProjectsProjectIdKeysGetParametersStatus.Active => "active",
                V1ProjectsProjectIdKeysGetParametersStatus.Expired => "expired",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ProjectsProjectIdKeysGetParametersStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => V1ProjectsProjectIdKeysGetParametersStatus.Active,
                "expired" => V1ProjectsProjectIdKeysGetParametersStatus.Expired,
                _ => null,
            };
        }
    }
}