
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// The Function endpoint to call. if not passed, function is called client-side
    /// </summary>
    public sealed partial class ThinkSettingsV1FunctionsItemsEndpoint
    {
        /// <summary>
        /// Endpoint URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// HTTP method
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public string? Method { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkSettingsV1FunctionsItemsEndpoint" /> class.
        /// </summary>
        /// <param name="url">
        /// Endpoint URL
        /// </param>
        /// <param name="method">
        /// HTTP method
        /// </param>
        /// <param name="headers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThinkSettingsV1FunctionsItemsEndpoint(
            string? url,
            string? method,
            global::System.Collections.Generic.Dictionary<string, string>? headers)
        {
            this.Url = url;
            this.Method = method;
            this.Headers = headers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkSettingsV1FunctionsItemsEndpoint" /> class.
        /// </summary>
        public ThinkSettingsV1FunctionsItemsEndpoint()
        {
        }

    }
}