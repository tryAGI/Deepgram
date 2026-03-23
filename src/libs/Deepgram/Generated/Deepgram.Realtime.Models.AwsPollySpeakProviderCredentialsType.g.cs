
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum AwsPollySpeakProviderCredentialsType
    {
        /// <summary>
        /// 
        /// </summary>
        Iam,
        /// <summary>
        /// 
        /// </summary>
        Sts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AwsPollySpeakProviderCredentialsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AwsPollySpeakProviderCredentialsType value)
        {
            return value switch
            {
                AwsPollySpeakProviderCredentialsType.Iam => "iam",
                AwsPollySpeakProviderCredentialsType.Sts => "sts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AwsPollySpeakProviderCredentialsType? ToEnum(string value)
        {
            return value switch
            {
                "iam" => AwsPollySpeakProviderCredentialsType.Iam,
                "sts" => AwsPollySpeakProviderCredentialsType.Sts,
                _ => null,
            };
        }
    }
}