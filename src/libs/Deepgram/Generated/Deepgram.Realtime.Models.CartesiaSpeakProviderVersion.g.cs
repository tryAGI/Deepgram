
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// The API version header for the Cartesia text-to-speech API
    /// </summary>
    public enum CartesiaSpeakProviderVersion
    {
        /// <summary>
        /// 
        /// </summary>
        x20250317,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CartesiaSpeakProviderVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CartesiaSpeakProviderVersion value)
        {
            return value switch
            {
                CartesiaSpeakProviderVersion.x20250317 => "2025-03-17",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CartesiaSpeakProviderVersion? ToEnum(string value)
        {
            return value switch
            {
                "2025-03-17" => CartesiaSpeakProviderVersion.x20250317,
                _ => null,
            };
        }
    }
}