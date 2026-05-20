
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeakSettingsV1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.SpeakSettingsV1ProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.SpeakSettingsV1Provider Provider { get; set; }

        /// <summary>
        /// Optional if provider is Deepgram. Required for non-Deepgram TTS providers.<br/>
        /// When present, must include url field and headers object. Valid schemes are https and wss with wss only supported for Eleven Labs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        public global::Deepgram.Realtime.SpeakSettingsV1Endpoint? Endpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakSettingsV1" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="endpoint">
        /// Optional if provider is Deepgram. Required for non-Deepgram TTS providers.<br/>
        /// When present, must include url field and headers object. Valid schemes are https and wss with wss only supported for Eleven Labs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakSettingsV1(
            global::Deepgram.Realtime.SpeakSettingsV1Provider provider,
            global::Deepgram.Realtime.SpeakSettingsV1Endpoint? endpoint)
        {
            this.Provider = provider;
            this.Endpoint = endpoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakSettingsV1" /> class.
        /// </summary>
        public SpeakSettingsV1()
        {
        }

    }
}