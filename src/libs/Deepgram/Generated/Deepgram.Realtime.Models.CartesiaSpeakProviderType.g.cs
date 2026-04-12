
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum CartesiaSpeakProviderType
    {
        /// <summary>
        /// 
        /// </summary>
        Cartesia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CartesiaSpeakProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CartesiaSpeakProviderType value)
        {
            return value switch
            {
                CartesiaSpeakProviderType.Cartesia => "cartesia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CartesiaSpeakProviderType? ToEnum(string value)
        {
            return value switch
            {
                "cartesia" => CartesiaSpeakProviderType.Cartesia,
                _ => null,
            };
        }
    }
}