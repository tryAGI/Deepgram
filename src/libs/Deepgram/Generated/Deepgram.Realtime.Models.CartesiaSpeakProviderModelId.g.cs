
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Cartesia model ID
    /// </summary>
    public enum CartesiaSpeakProviderModelId
    {
        /// <summary>
        /// 
        /// </summary>
        Sonic2,
        /// <summary>
        /// 
        /// </summary>
        SonicMultilingual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CartesiaSpeakProviderModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CartesiaSpeakProviderModelId value)
        {
            return value switch
            {
                CartesiaSpeakProviderModelId.Sonic2 => "sonic-2",
                CartesiaSpeakProviderModelId.SonicMultilingual => "sonic-multilingual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CartesiaSpeakProviderModelId? ToEnum(string value)
        {
            return value switch
            {
                "sonic-2" => CartesiaSpeakProviderModelId.Sonic2,
                "sonic-multilingual" => CartesiaSpeakProviderModelId.SonicMultilingual,
                _ => null,
            };
        }
    }
}