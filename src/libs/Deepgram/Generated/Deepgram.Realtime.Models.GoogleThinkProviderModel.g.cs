
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Google model to use
    /// </summary>
    public enum GoogleThinkProviderModel
    {
        /// <summary>
        /// 
        /// </summary>
        Gemini20Flash,
        /// <summary>
        /// 
        /// </summary>
        Gemini20FlashLite,
        /// <summary>
        /// 
        /// </summary>
        Gemini25Flash,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoogleThinkProviderModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleThinkProviderModel value)
        {
            return value switch
            {
                GoogleThinkProviderModel.Gemini20Flash => "gemini-2.0-flash",
                GoogleThinkProviderModel.Gemini20FlashLite => "gemini-2.0-flash-lite",
                GoogleThinkProviderModel.Gemini25Flash => "gemini-2.5-flash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleThinkProviderModel? ToEnum(string value)
        {
            return value switch
            {
                "gemini-2.0-flash" => GoogleThinkProviderModel.Gemini20Flash,
                "gemini-2.0-flash-lite" => GoogleThinkProviderModel.Gemini20FlashLite,
                "gemini-2.5-flash" => GoogleThinkProviderModel.Gemini25Flash,
                _ => null,
            };
        }
    }
}