
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// The unique identifier of the Google model
    /// </summary>
    public enum AgentThinkModelsV1ResponseModelVariant3Id
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
    public static class AgentThinkModelsV1ResponseModelVariant3IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentThinkModelsV1ResponseModelVariant3Id value)
        {
            return value switch
            {
                AgentThinkModelsV1ResponseModelVariant3Id.Gemini20Flash => "gemini-2.0-flash",
                AgentThinkModelsV1ResponseModelVariant3Id.Gemini20FlashLite => "gemini-2.0-flash-lite",
                AgentThinkModelsV1ResponseModelVariant3Id.Gemini25Flash => "gemini-2.5-flash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentThinkModelsV1ResponseModelVariant3Id? ToEnum(string value)
        {
            return value switch
            {
                "gemini-2.0-flash" => AgentThinkModelsV1ResponseModelVariant3Id.Gemini20Flash,
                "gemini-2.0-flash-lite" => AgentThinkModelsV1ResponseModelVariant3Id.Gemini20FlashLite,
                "gemini-2.5-flash" => AgentThinkModelsV1ResponseModelVariant3Id.Gemini25Flash,
                _ => null,
            };
        }
    }
}