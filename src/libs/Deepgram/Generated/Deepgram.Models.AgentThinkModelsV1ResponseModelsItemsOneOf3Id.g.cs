
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// The unique identifier of the Groq model
    /// </summary>
    public enum AgentThinkModelsV1ResponseModelsItemsOneOf3Id
    {
        /// <summary>
        /// 
        /// </summary>
        OpenaiGptOss20b,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentThinkModelsV1ResponseModelsItemsOneOf3IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentThinkModelsV1ResponseModelsItemsOneOf3Id value)
        {
            return value switch
            {
                AgentThinkModelsV1ResponseModelsItemsOneOf3Id.OpenaiGptOss20b => "openai/gpt-oss-20b",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentThinkModelsV1ResponseModelsItemsOneOf3Id? ToEnum(string value)
        {
            return value switch
            {
                "openai/gpt-oss-20b" => AgentThinkModelsV1ResponseModelsItemsOneOf3Id.OpenaiGptOss20b,
                _ => null,
            };
        }
    }
}