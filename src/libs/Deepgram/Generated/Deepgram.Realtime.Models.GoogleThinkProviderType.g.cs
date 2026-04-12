
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum GoogleThinkProviderType
    {
        /// <summary>
        /// 
        /// </summary>
        Google,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoogleThinkProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleThinkProviderType value)
        {
            return value switch
            {
                GoogleThinkProviderType.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleThinkProviderType? ToEnum(string value)
        {
            return value switch
            {
                "google" => GoogleThinkProviderType.Google,
                _ => null,
            };
        }
    }
}