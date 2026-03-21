
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Optional if provider is Deepgram. Required for non-Deepgram TTS providers.<br/>
    /// When present, must include url field and headers object. Valid schemes are https and wss with wss only supported for Eleven Labs.
    /// </summary>
    public sealed partial class SpeakSettingsV1Endpoint
    {
        /// <summary>
        /// Custom TTS endpoint URL. Cannot contain `output_format` or `model_id` query parameters when the provider is Eleven Labs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

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
        /// Initializes a new instance of the <see cref="SpeakSettingsV1Endpoint" /> class.
        /// </summary>
        /// <param name="url">
        /// Custom TTS endpoint URL. Cannot contain `output_format` or `model_id` query parameters when the provider is Eleven Labs.
        /// </param>
        /// <param name="headers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakSettingsV1Endpoint(
            string? url,
            global::System.Collections.Generic.Dictionary<string, string>? headers)
        {
            this.Url = url;
            this.Headers = headers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakSettingsV1Endpoint" /> class.
        /// </summary>
        public SpeakSettingsV1Endpoint()
        {
        }
    }
}