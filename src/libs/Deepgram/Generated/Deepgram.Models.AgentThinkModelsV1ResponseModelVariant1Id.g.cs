
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// The unique identifier of the OpenAI model
    /// </summary>
    public enum AgentThinkModelsV1ResponseModelVariant1Id
    {
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentThinkModelsV1ResponseModelVariant1IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentThinkModelsV1ResponseModelVariant1Id value)
        {
            return value switch
            {
                AgentThinkModelsV1ResponseModelVariant1Id.Gpt5 => "gpt-5",
                AgentThinkModelsV1ResponseModelVariant1Id.Gpt5Mini => "gpt-5-mini",
                AgentThinkModelsV1ResponseModelVariant1Id.Gpt5Nano => "gpt-5-nano",
                AgentThinkModelsV1ResponseModelVariant1Id.Gpt41 => "gpt-4.1",
                AgentThinkModelsV1ResponseModelVariant1Id.Gpt41Mini => "gpt-4.1-mini",
                AgentThinkModelsV1ResponseModelVariant1Id.Gpt41Nano => "gpt-4.1-nano",
                AgentThinkModelsV1ResponseModelVariant1Id.Gpt4o => "gpt-4o",
                AgentThinkModelsV1ResponseModelVariant1Id.Gpt4oMini => "gpt-4o-mini",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentThinkModelsV1ResponseModelVariant1Id? ToEnum(string value)
        {
            return value switch
            {
                "gpt-5" => AgentThinkModelsV1ResponseModelVariant1Id.Gpt5,
                "gpt-5-mini" => AgentThinkModelsV1ResponseModelVariant1Id.Gpt5Mini,
                "gpt-5-nano" => AgentThinkModelsV1ResponseModelVariant1Id.Gpt5Nano,
                "gpt-4.1" => AgentThinkModelsV1ResponseModelVariant1Id.Gpt41,
                "gpt-4.1-mini" => AgentThinkModelsV1ResponseModelVariant1Id.Gpt41Mini,
                "gpt-4.1-nano" => AgentThinkModelsV1ResponseModelVariant1Id.Gpt41Nano,
                "gpt-4o" => AgentThinkModelsV1ResponseModelVariant1Id.Gpt4o,
                "gpt-4o-mini" => AgentThinkModelsV1ResponseModelVariant1Id.Gpt4oMini,
                _ => null,
            };
        }
    }
}