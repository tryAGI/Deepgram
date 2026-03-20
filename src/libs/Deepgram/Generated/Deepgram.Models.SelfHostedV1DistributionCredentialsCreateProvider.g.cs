
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Default Value: quay
    /// </summary>
    public enum SelfHostedV1DistributionCredentialsCreateProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Quay,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SelfHostedV1DistributionCredentialsCreateProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SelfHostedV1DistributionCredentialsCreateProvider value)
        {
            return value switch
            {
                SelfHostedV1DistributionCredentialsCreateProvider.Quay => "quay",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SelfHostedV1DistributionCredentialsCreateProvider? ToEnum(string value)
        {
            return value switch
            {
                "quay" => SelfHostedV1DistributionCredentialsCreateProvider.Quay,
                _ => null,
            };
        }
    }
}