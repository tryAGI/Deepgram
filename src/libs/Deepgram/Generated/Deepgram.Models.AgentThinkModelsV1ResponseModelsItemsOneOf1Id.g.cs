
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// The unique identifier of the Anthropic model
    /// </summary>
    public enum AgentThinkModelsV1ResponseModelsItemsOneOf1Id
    {
        /// <summary>
        /// 
        /// </summary>
        Claude35HaikuLatest,
        /// <summary>
        /// 
        /// </summary>
        ClaudeSonnet420250514,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentThinkModelsV1ResponseModelsItemsOneOf1IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentThinkModelsV1ResponseModelsItemsOneOf1Id value)
        {
            return value switch
            {
                AgentThinkModelsV1ResponseModelsItemsOneOf1Id.Claude35HaikuLatest => "claude-3-5-haiku-latest",
                AgentThinkModelsV1ResponseModelsItemsOneOf1Id.ClaudeSonnet420250514 => "claude-sonnet-4-20250514",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentThinkModelsV1ResponseModelsItemsOneOf1Id? ToEnum(string value)
        {
            return value switch
            {
                "claude-3-5-haiku-latest" => AgentThinkModelsV1ResponseModelsItemsOneOf1Id.Claude35HaikuLatest,
                "claude-sonnet-4-20250514" => AgentThinkModelsV1ResponseModelsItemsOneOf1Id.ClaudeSonnet420250514,
                _ => null,
            };
        }
    }
}