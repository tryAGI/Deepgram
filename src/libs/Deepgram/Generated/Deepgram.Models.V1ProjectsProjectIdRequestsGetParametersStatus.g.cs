
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1ProjectsProjectIdRequestsGetParametersStatus
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
    public static class V1ProjectsProjectIdRequestsGetParametersStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ProjectsProjectIdRequestsGetParametersStatus value)
        {
            return value switch
            {
                V1ProjectsProjectIdRequestsGetParametersStatus.Failed => "failed",
                V1ProjectsProjectIdRequestsGetParametersStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ProjectsProjectIdRequestsGetParametersStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => V1ProjectsProjectIdRequestsGetParametersStatus.Failed,
                "succeeded" => V1ProjectsProjectIdRequestsGetParametersStatus.Succeeded,
                _ => null,
            };
        }
    }
}