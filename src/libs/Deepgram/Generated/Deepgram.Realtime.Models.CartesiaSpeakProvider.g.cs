
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CartesiaSpeakProvider
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"cartesia"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "cartesia";

        /// <summary>
        /// The API version header for the Cartesia text-to-speech API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.CartesiaSpeakProviderVersionJsonConverter))]
        public global::Deepgram.Realtime.CartesiaSpeakProviderVersion? Version { get; set; }

        /// <summary>
        /// Cartesia model ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.CartesiaSpeakProviderModelIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.CartesiaSpeakProviderModelId ModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.CartesiaSpeakProviderVoice Voice { get; set; }

        /// <summary>
        /// Cartesia language code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CartesiaSpeakProvider" /> class.
        /// </summary>
        /// <param name="modelId">
        /// Cartesia model ID
        /// </param>
        /// <param name="voice"></param>
        /// <param name="version">
        /// The API version header for the Cartesia text-to-speech API
        /// </param>
        /// <param name="language">
        /// Cartesia language code
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CartesiaSpeakProvider(
            global::Deepgram.Realtime.CartesiaSpeakProviderModelId modelId,
            global::Deepgram.Realtime.CartesiaSpeakProviderVoice voice,
            global::Deepgram.Realtime.CartesiaSpeakProviderVersion? version,
            string? language,
            string type = "cartesia")
        {
            this.Type = type;
            this.Version = version;
            this.ModelId = modelId;
            this.Voice = voice ?? throw new global::System.ArgumentNullException(nameof(voice));
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CartesiaSpeakProvider" /> class.
        /// </summary>
        public CartesiaSpeakProvider()
        {
        }
    }
}