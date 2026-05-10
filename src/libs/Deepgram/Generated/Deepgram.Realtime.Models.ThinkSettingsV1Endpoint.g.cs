
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Optional for non-Deepgram LLM providers. When present, must include url field and headers object
    /// </summary>
    public sealed partial class ThinkSettingsV1Endpoint
    {
        /// <summary>
        /// Custom LLM endpoint URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Custom headers for the endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkSettingsV1Endpoint" /> class.
        /// </summary>
        /// <param name="url">
        /// Custom LLM endpoint URL
        /// </param>
        /// <param name="headers">
        /// Custom headers for the endpoint
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThinkSettingsV1Endpoint(
            string? url,
            global::System.Collections.Generic.Dictionary<string, string>? headers)
        {
            this.Url = url;
            this.Headers = headers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkSettingsV1Endpoint" /> class.
        /// </summary>
        public ThinkSettingsV1Endpoint()
        {
        }

    }
}