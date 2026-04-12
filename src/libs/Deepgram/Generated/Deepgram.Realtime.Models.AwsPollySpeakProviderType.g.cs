
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum AwsPollySpeakProviderType
    {
        /// <summary>
        /// 
        /// </summary>
        AwsPolly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AwsPollySpeakProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AwsPollySpeakProviderType value)
        {
            return value switch
            {
                AwsPollySpeakProviderType.AwsPolly => "aws_polly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AwsPollySpeakProviderType? ToEnum(string value)
        {
            return value switch
            {
                "aws_polly" => AwsPollySpeakProviderType.AwsPolly,
                _ => null,
            };
        }
    }
}