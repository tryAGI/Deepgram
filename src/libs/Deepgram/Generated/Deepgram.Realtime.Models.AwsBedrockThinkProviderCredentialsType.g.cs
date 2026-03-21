
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// AWS credentials type (STS short-lived or IAM long-lived)
    /// </summary>
    public enum AwsBedrockThinkProviderCredentialsType
    {
        /// <summary>
        /// 
        /// </summary>
        Sts,
        /// <summary>
        /// 
        /// </summary>
        Iam,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AwsBedrockThinkProviderCredentialsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AwsBedrockThinkProviderCredentialsType value)
        {
            return value switch
            {
                AwsBedrockThinkProviderCredentialsType.Sts => "sts",
                AwsBedrockThinkProviderCredentialsType.Iam => "iam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AwsBedrockThinkProviderCredentialsType? ToEnum(string value)
        {
            return value switch
            {
                "sts" => AwsBedrockThinkProviderCredentialsType.Sts,
                "iam" => AwsBedrockThinkProviderCredentialsType.Iam,
                _ => null,
            };
        }
    }
}