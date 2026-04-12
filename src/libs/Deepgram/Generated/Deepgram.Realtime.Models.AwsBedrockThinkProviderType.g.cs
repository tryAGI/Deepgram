
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum AwsBedrockThinkProviderType
    {
        /// <summary>
        /// 
        /// </summary>
        AwsBedrock,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AwsBedrockThinkProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AwsBedrockThinkProviderType value)
        {
            return value switch
            {
                AwsBedrockThinkProviderType.AwsBedrock => "aws_bedrock",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AwsBedrockThinkProviderType? ToEnum(string value)
        {
            return value switch
            {
                "aws_bedrock" => AwsBedrockThinkProviderType.AwsBedrock,
                _ => null,
            };
        }
    }
}