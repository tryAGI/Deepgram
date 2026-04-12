
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// The unique identifier of the OpenAI model
    /// </summary>
    public enum AgentThinkModelsV1ResponseModelsItemsOneOf0Id
    {
        /// <summary>
        /// 
        /// </summary>
        Gpt41,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Mini,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Nano,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMini,
        /// <summary>
        /// 
        /// </summary>
        Gpt5,
        /// <summary>
        /// 
        /// </summary>
        Gpt5Mini,
        /// <summary>
        /// 
        /// </summary>
        Gpt5Nano,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentThinkModelsV1ResponseModelsItemsOneOf0IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentThinkModelsV1ResponseModelsItemsOneOf0Id value)
        {
            return value switch
            {
                AgentThinkModelsV1ResponseModelsItemsOneOf0Id.Gpt41 => "gpt-4.1",
                AgentThinkModelsV1ResponseModelsItemsOneOf0Id.Gpt41Mini => "gpt-4.1-mini",
                AgentThinkModelsV1ResponseModelsItemsOneOf0Id.Gpt41Nano => "gpt-4.1-nano",
                AgentThinkModelsV1ResponseModelsItemsOneOf0Id.Gpt4o => "gpt-4o",
                AgentThinkModelsV1ResponseModelsItemsOneOf0Id.Gpt4oMini => "gpt-4o-mini",
                AgentThinkModelsV1ResponseModelsItemsOneOf0Id.Gpt5 => "gpt-5",
                AgentThinkModelsV1ResponseModelsItemsOneOf0Id.Gpt5Mini => "gpt-5-mini",
                AgentThinkModelsV1ResponseModelsItemsOneOf0Id.Gpt5Nano => "gpt-5-nano",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentThinkModelsV1ResponseModelsItemsOneOf0Id? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4.1" => AgentThinkModelsV1ResponseModelsItemsOneOf0Id.Gpt41,
                "gpt-4.1-mini" => AgentThinkModelsV1ResponseModelsItemsOneOf0Id.Gpt41Mini,
                "gpt-4.1-nano" => AgentThinkModelsV1ResponseModelsItemsOneOf0Id.Gpt41Nano,
                "gpt-4o" => AgentThinkModelsV1ResponseModelsItemsOneOf0Id.Gpt4o,
                "gpt-4o-mini" => AgentThinkModelsV1ResponseModelsItemsOneOf0Id.Gpt4oMini,
                "gpt-5" => AgentThinkModelsV1ResponseModelsItemsOneOf0Id.Gpt5,
                "gpt-5-mini" => AgentThinkModelsV1ResponseModelsItemsOneOf0Id.Gpt5Mini,
                "gpt-5-nano" => AgentThinkModelsV1ResponseModelsItemsOneOf0Id.Gpt5Nano,
                _ => null,
            };
        }
    }
}