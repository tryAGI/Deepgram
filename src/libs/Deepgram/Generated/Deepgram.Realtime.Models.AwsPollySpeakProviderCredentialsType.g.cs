
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
        Sts,
        /// <summary>
        /// 
        /// </summary>
        Iam,
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
                AwsPollySpeakProviderCredentialsType.Sts => "sts",
                AwsPollySpeakProviderCredentialsType.Iam => "iam",
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
                "sts" => AwsPollySpeakProviderCredentialsType.Sts,
                "iam" => AwsPollySpeakProviderCredentialsType.Iam,
                _ => null,
            };
        }
    }
}