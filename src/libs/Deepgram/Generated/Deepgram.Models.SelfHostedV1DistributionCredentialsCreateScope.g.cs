
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public enum SelfHostedV1DistributionCredentialsCreateScope
    {
        /// <summary>
        /// 
        /// </summary>
        SelfHosted_products,
        /// <summary>
        /// 
        /// </summary>
        SelfHosted_product_api,
        /// <summary>
        /// 
        /// </summary>
        SelfHosted_product_engine,
        /// <summary>
        /// 
        /// </summary>
        SelfHosted_product_licenseProxy,
        /// <summary>
        /// 
        /// </summary>
        SelfHosted_product_dgtools,
        /// <summary>
        /// 
        /// </summary>
        SelfHosted_product_billing,
        /// <summary>
        /// 
        /// </summary>
        SelfHosted_product_hotpepper,
        /// <summary>
        /// 
        /// </summary>
        SelfHosted_product_metricsServer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SelfHostedV1DistributionCredentialsCreateScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SelfHostedV1DistributionCredentialsCreateScope value)
        {
            return value switch
            {
                SelfHostedV1DistributionCredentialsCreateScope.SelfHosted_products => "self-hosted:products",
                SelfHostedV1DistributionCredentialsCreateScope.SelfHosted_product_api => "self-hosted:product:api",
                SelfHostedV1DistributionCredentialsCreateScope.SelfHosted_product_engine => "self-hosted:product:engine",
                SelfHostedV1DistributionCredentialsCreateScope.SelfHosted_product_licenseProxy => "self-hosted:product:license-proxy",
                SelfHostedV1DistributionCredentialsCreateScope.SelfHosted_product_dgtools => "self-hosted:product:dgtools",
                SelfHostedV1DistributionCredentialsCreateScope.SelfHosted_product_billing => "self-hosted:product:billing",
                SelfHostedV1DistributionCredentialsCreateScope.SelfHosted_product_hotpepper => "self-hosted:product:hotpepper",
                SelfHostedV1DistributionCredentialsCreateScope.SelfHosted_product_metricsServer => "self-hosted:product:metrics-server",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SelfHostedV1DistributionCredentialsCreateScope? ToEnum(string value)
        {
            return value switch
            {
                "self-hosted:products" => SelfHostedV1DistributionCredentialsCreateScope.SelfHosted_products,
                "self-hosted:product:api" => SelfHostedV1DistributionCredentialsCreateScope.SelfHosted_product_api,
                "self-hosted:product:engine" => SelfHostedV1DistributionCredentialsCreateScope.SelfHosted_product_engine,
                "self-hosted:product:license-proxy" => SelfHostedV1DistributionCredentialsCreateScope.SelfHosted_product_licenseProxy,
                "self-hosted:product:dgtools" => SelfHostedV1DistributionCredentialsCreateScope.SelfHosted_product_dgtools,
                "self-hosted:product:billing" => SelfHostedV1DistributionCredentialsCreateScope.SelfHosted_product_billing,
                "self-hosted:product:hotpepper" => SelfHostedV1DistributionCredentialsCreateScope.SelfHosted_product_hotpepper,
                "self-hosted:product:metrics-server" => SelfHostedV1DistributionCredentialsCreateScope.SelfHosted_product_metricsServer,
                _ => null,
            };
        }
    }
}