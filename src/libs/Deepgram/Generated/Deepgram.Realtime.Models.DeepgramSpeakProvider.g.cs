
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Deepgram text-to-speech provider. Aura models use version v1 (default); Flux TTS uses version v2 and a flux-* model. Flux TTS is the default when agent.speak is omitted, using the flux-kit-en voice.
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
        /// The Deepgram text-to-speech model family. Accepted values: `v1` (Aura, the default) and `v2` (Flux TTS). Use `v1` with an aura-* model and `v2` with a flux-* model. Defaults to `v1` when omitted.<br/>
        /// Default Value: v1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Deepgram TTS model. Aura models (version v1) use the aura-* voices; Flux TTS (version v2) uses the flux-{voice}-{language} voices (e.g. flux-alexis-en). Defaults to flux-kit-en when agent.speak is omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.DeepgramSpeakProviderModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.DeepgramSpeakProviderModel Model { get; set; }

        /// <summary>
        /// Speaking rate multiplier that adjusts the pace of generated speech while preserving natural prosody and voice quality. Aura (version v1) accepts any value from 0.7 to 1.5. Flux TTS (version v2) accepts only 0.85, 0.9, 0.95, 1.0, 1.05, 1.1 and 1.15; another value ends the session with FAILED_TO_SPEAK. Not yet supported in all languages.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Delivery register of the generated speech, on a calm-to-animated axis. Flux TTS (version v2) only, on every Flux voice. Accepts the whole numbers -2 to 2, where 0 (the default) is the voice's tuned delivery and the only value validated for production, -2 the calm end of the range and 2 the animated end. Fixed for the session. Beta: behavior may change in future model versions, and non-default values increase the risk of hallucinations and pronunciation errors. See [Expressivity](/docs/tts-expressivity).<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expressivity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.DeepgramSpeakProviderExpressivityJsonConverter))]
        public global::Deepgram.Realtime.DeepgramSpeakProviderExpressivity? Expressivity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeepgramSpeakProvider" /> class.
        /// </summary>
        /// <param name="model">
        /// Deepgram TTS model. Aura models (version v1) use the aura-* voices; Flux TTS (version v2) uses the flux-{voice}-{language} voices (e.g. flux-alexis-en). Defaults to flux-kit-en when agent.speak is omitted.
        /// </param>
        /// <param name="type"></param>
        /// <param name="version">
        /// The Deepgram text-to-speech model family. Accepted values: `v1` (Aura, the default) and `v2` (Flux TTS). Use `v1` with an aura-* model and `v2` with a flux-* model. Defaults to `v1` when omitted.<br/>
        /// Default Value: v1
        /// </param>
        /// <param name="speed">
        /// Speaking rate multiplier that adjusts the pace of generated speech while preserving natural prosody and voice quality. Aura (version v1) accepts any value from 0.7 to 1.5. Flux TTS (version v2) accepts only 0.85, 0.9, 0.95, 1.0, 1.05, 1.1 and 1.15; another value ends the session with FAILED_TO_SPEAK. Not yet supported in all languages.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="expressivity">
        /// Delivery register of the generated speech, on a calm-to-animated axis. Flux TTS (version v2) only, on every Flux voice. Accepts the whole numbers -2 to 2, where 0 (the default) is the voice's tuned delivery and the only value validated for production, -2 the calm end of the range and 2 the animated end. Fixed for the session. Beta: behavior may change in future model versions, and non-default values increase the risk of hallucinations and pronunciation errors. See [Expressivity](/docs/tts-expressivity).<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeepgramSpeakProvider(
            global::Deepgram.Realtime.DeepgramSpeakProviderModel model,
            global::Deepgram.Realtime.DeepgramSpeakProviderType type,
            string? version,
            double? speed,
            global::Deepgram.Realtime.DeepgramSpeakProviderExpressivity? expressivity)
        {
            this.Type = type;
            this.Version = version;
            this.Model = model;
            this.Speed = speed;
            this.Expressivity = expressivity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeepgramSpeakProvider" /> class.
        /// </summary>
        public DeepgramSpeakProvider()
        {
        }

    }
}