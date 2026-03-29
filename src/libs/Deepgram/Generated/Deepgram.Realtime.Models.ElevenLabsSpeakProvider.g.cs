
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ElevenLabsSpeakProvider
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"eleven_labs"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "eleven_labs";

        /// <summary>
        /// The REST API version for the ElevenLabs text-to-speech API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ElevenLabsSpeakProviderVersionJsonConverter))]
        public global::Deepgram.Realtime.ElevenLabsSpeakProviderVersion? Version { get; set; }

        /// <summary>
        /// Eleven Labs model ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ElevenLabsSpeakProviderModelIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.ElevenLabsSpeakProviderModelId ModelId { get; set; }

        /// <summary>
        /// Optional language to use, e.g. 'en-US'. Corresponds to the `language_code` parameter in the ElevenLabs API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Use the `language` field instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_code")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenLabsSpeakProvider" /> class.
        /// </summary>
        /// <param name="modelId">
        /// Eleven Labs model ID
        /// </param>
        /// <param name="version">
        /// The REST API version for the ElevenLabs text-to-speech API
        /// </param>
        /// <param name="language">
        /// Optional language to use, e.g. 'en-US'. Corresponds to the `language_code` parameter in the ElevenLabs API
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ElevenLabsSpeakProvider(
            global::Deepgram.Realtime.ElevenLabsSpeakProviderModelId modelId,
            global::Deepgram.Realtime.ElevenLabsSpeakProviderVersion? version,
            string? language,
            string type = "eleven_labs")
        {
            this.Type = type;
            this.Version = version;
            this.ModelId = modelId;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenLabsSpeakProvider" /> class.
        /// </summary>
        public ElevenLabsSpeakProvider()
        {
        }
    }
}