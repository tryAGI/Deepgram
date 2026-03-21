
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// The REST API version for the Google generative language API
    /// </summary>
    public enum GoogleThinkProviderVersion
    {
        /// <summary>
        /// 
        /// </summary>
        V1beta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoogleThinkProviderVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleThinkProviderVersion value)
        {
            return value switch
            {
                GoogleThinkProviderVersion.V1beta => "v1beta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleThinkProviderVersion? ToEnum(string value)
        {
            return value switch
            {
                "v1beta" => GoogleThinkProviderVersion.V1beta,
                _ => null,
            };
        }
    }
}