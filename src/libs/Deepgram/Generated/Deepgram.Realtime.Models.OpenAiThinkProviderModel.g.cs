
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// OpenAI model to use
    /// </summary>
    public enum OpenAiThinkProviderModel
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
    public static class OpenAiThinkProviderModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiThinkProviderModel value)
        {
            return value switch
            {
                OpenAiThinkProviderModel.Gpt41 => "gpt-4.1",
                OpenAiThinkProviderModel.Gpt41Mini => "gpt-4.1-mini",
                OpenAiThinkProviderModel.Gpt41Nano => "gpt-4.1-nano",
                OpenAiThinkProviderModel.Gpt4o => "gpt-4o",
                OpenAiThinkProviderModel.Gpt4oMini => "gpt-4o-mini",
                OpenAiThinkProviderModel.Gpt5 => "gpt-5",
                OpenAiThinkProviderModel.Gpt5Mini => "gpt-5-mini",
                OpenAiThinkProviderModel.Gpt5Nano => "gpt-5-nano",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiThinkProviderModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4.1" => OpenAiThinkProviderModel.Gpt41,
                "gpt-4.1-mini" => OpenAiThinkProviderModel.Gpt41Mini,
                "gpt-4.1-nano" => OpenAiThinkProviderModel.Gpt41Nano,
                "gpt-4o" => OpenAiThinkProviderModel.Gpt4o,
                "gpt-4o-mini" => OpenAiThinkProviderModel.Gpt4oMini,
                "gpt-5" => OpenAiThinkProviderModel.Gpt5,
                "gpt-5-mini" => OpenAiThinkProviderModel.Gpt5Mini,
                "gpt-5-nano" => OpenAiThinkProviderModel.Gpt5Nano,
                _ => null,
            };
        }
    }
}