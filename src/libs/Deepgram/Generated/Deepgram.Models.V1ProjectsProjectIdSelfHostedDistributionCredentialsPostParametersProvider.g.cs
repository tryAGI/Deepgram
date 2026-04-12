
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Default Value: quay
    /// </summary>
    public enum V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Quay,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider value)
        {
            return value switch
            {
                V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider.Quay => "quay",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider? ToEnum(string value)
        {
            return value switch
            {
                "quay" => V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider.Quay,
                _ => null,
            };
        }
    }
}