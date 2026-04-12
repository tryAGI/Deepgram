
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems
    {
        /// <summary>
        /// 
        /// </summary>
        SelfHosted_product_api,
        /// <summary>
        /// 
        /// </summary>
        SelfHosted_product_billing,
        /// <summary>
        /// 
        /// </summary>
        SelfHosted_product_dgtools,
        /// <summary>
        /// 
        /// </summary>
        SelfHosted_product_engine,
        /// <summary>
        /// 
        /// </summary>
        SelfHosted_product_hotpepper,
        /// <summary>
        /// 
        /// </summary>
        SelfHosted_product_licenseProxy,
        /// <summary>
        /// 
        /// </summary>
        SelfHosted_product_metricsServer,
        /// <summary>
        /// 
        /// </summary>
        SelfHosted_products,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems value)
        {
            return value switch
            {
                V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems.SelfHosted_product_api => "self-hosted:product:api",
                V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems.SelfHosted_product_billing => "self-hosted:product:billing",
                V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems.SelfHosted_product_dgtools => "self-hosted:product:dgtools",
                V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems.SelfHosted_product_engine => "self-hosted:product:engine",
                V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems.SelfHosted_product_hotpepper => "self-hosted:product:hotpepper",
                V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems.SelfHosted_product_licenseProxy => "self-hosted:product:license-proxy",
                V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems.SelfHosted_product_metricsServer => "self-hosted:product:metrics-server",
                V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems.SelfHosted_products => "self-hosted:products",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems? ToEnum(string value)
        {
            return value switch
            {
                "self-hosted:product:api" => V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems.SelfHosted_product_api,
                "self-hosted:product:billing" => V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems.SelfHosted_product_billing,
                "self-hosted:product:dgtools" => V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems.SelfHosted_product_dgtools,
                "self-hosted:product:engine" => V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems.SelfHosted_product_engine,
                "self-hosted:product:hotpepper" => V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems.SelfHosted_product_hotpepper,
                "self-hosted:product:license-proxy" => V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems.SelfHosted_product_licenseProxy,
                "self-hosted:product:metrics-server" => V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems.SelfHosted_product_metricsServer,
                "self-hosted:products" => V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems.SelfHosted_products,
                _ => null,
            };
        }
    }
}