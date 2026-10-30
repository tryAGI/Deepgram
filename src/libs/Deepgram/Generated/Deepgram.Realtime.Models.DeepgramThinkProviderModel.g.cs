
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Deepgram language model to use. Early Access. think-fast requires the Model Improvement Program: a session with mip_opt_out set to true is rejected with INVALID_SETTINGS. Use phonellm-mini-alpha-2-fp8 for sessions that opt out.
    /// </summary>
    public enum DeepgramThinkProviderModel
    {
        /// <summary>
        /// a session with mip_opt_out set to true is rejected with INVALID_SETTINGS. Use phonellm-mini-alpha-2-fp8 for sessions that opt out.
        /// </summary>
        PhonellmMiniAlpha2Fp8,
        /// <summary>
        /// a session with mip_opt_out set to true is rejected with INVALID_SETTINGS. Use phonellm-mini-alpha-2-fp8 for sessions that opt out.
        /// </summary>
        ThinkFast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeepgramThinkProviderModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeepgramThinkProviderModel value)
        {
            return value switch
            {
                DeepgramThinkProviderModel.PhonellmMiniAlpha2Fp8 => "phonellm-mini-alpha-2-fp8",
                DeepgramThinkProviderModel.ThinkFast => "think-fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeepgramThinkProviderModel? ToEnum(string value)
        {
            return value switch
            {
                "phonellm-mini-alpha-2-fp8" => DeepgramThinkProviderModel.PhonellmMiniAlpha2Fp8,
                "think-fast" => DeepgramThinkProviderModel.ThinkFast,
                _ => null,
            };
        }
    }
}