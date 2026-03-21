
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// AWS Bedrock model to use
    /// </summary>
    public enum AwsBedrockThinkProviderModel
    {
        /// <summary>
        /// 
        /// </summary>
        AnthropicClaude35Sonnet20240620V1_0,
        /// <summary>
        /// 
        /// </summary>
        AnthropicClaude35Haiku20240307V1_0,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AwsBedrockThinkProviderModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AwsBedrockThinkProviderModel value)
        {
            return value switch
            {
                AwsBedrockThinkProviderModel.AnthropicClaude35Sonnet20240620V1_0 => "anthropic/claude-3-5-sonnet-20240620-v1:0",
                AwsBedrockThinkProviderModel.AnthropicClaude35Haiku20240307V1_0 => "anthropic/claude-3-5-haiku-20240307-v1:0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AwsBedrockThinkProviderModel? ToEnum(string value)
        {
            return value switch
            {
                "anthropic/claude-3-5-sonnet-20240620-v1:0" => AwsBedrockThinkProviderModel.AnthropicClaude35Sonnet20240620V1_0,
                "anthropic/claude-3-5-haiku-20240307-v1:0" => AwsBedrockThinkProviderModel.AnthropicClaude35Haiku20240307V1_0,
                _ => null,
            };
        }
    }
}