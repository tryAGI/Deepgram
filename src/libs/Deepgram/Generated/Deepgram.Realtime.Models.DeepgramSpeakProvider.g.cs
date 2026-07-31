
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Deepgram text-to-speech provider. Aura models use version v1 (default); Flux TTS uses version v2 and a flux-* model. Flux TTS is in Early Access — the Flux TTS-specific API surface and voice catalog may change before general availability.
    /// </summary>
    public sealed partial class DeepgramSpeakProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.DeepgramSpeakProviderTypeJsonConverter))]
        public global::Deepgram.Realtime.DeepgramSpeakProviderType Type { get; set; }

        /// <summary>
        /// The Deepgram text-to-speech model family. Accepted values: `v1` (Aura, the default) and `v2` (Flux TTS, Early Access). Use `v1` with an aura-* model and `v2` with a flux-* model. Defaults to `v1` when omitted.<br/>
        /// Default Value: v1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Deepgram TTS model. Aura models (version v1) use the aura-* voices; Flux TTS (version v2, Early Access) uses the flux-{voice}-{language} voices (e.g. flux-alexis-en).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.DeepgramSpeakProviderModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.DeepgramSpeakProviderModel Model { get; set; }

        /// <summary>
        /// Speaking rate multiplier that adjusts the pace of generated speech while preserving natural prosody and voice quality. Not yet supported in all languages.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeepgramSpeakProvider" /> class.
        /// </summary>
        /// <param name="model">
        /// Deepgram TTS model. Aura models (version v1) use the aura-* voices; Flux TTS (version v2, Early Access) uses the flux-{voice}-{language} voices (e.g. flux-alexis-en).
        /// </param>
        /// <param name="type"></param>
        /// <param name="version">
        /// The Deepgram text-to-speech model family. Accepted values: `v1` (Aura, the default) and `v2` (Flux TTS, Early Access). Use `v1` with an aura-* model and `v2` with a flux-* model. Defaults to `v1` when omitted.<br/>
        /// Default Value: v1
        /// </param>
        /// <param name="speed">
        /// Speaking rate multiplier that adjusts the pace of generated speech while preserving natural prosody and voice quality. Not yet supported in all languages.<br/>
        /// Default Value: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeepgramSpeakProvider(
            global::Deepgram.Realtime.DeepgramSpeakProviderModel model,
            global::Deepgram.Realtime.DeepgramSpeakProviderType type,
            string? version,
            double? speed)
        {
            this.Type = type;
            this.Version = version;
            this.Model = model;
            this.Speed = speed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeepgramSpeakProvider" /> class.
        /// </summary>
        public DeepgramSpeakProvider()
        {
        }

    }
}