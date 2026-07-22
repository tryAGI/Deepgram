
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Deepgram Flux TTS text-to-speech provider (version v2). Flux TTS is in Early Access — the Flux TTS-specific API surface and voice catalog may change before general availability.
    /// </summary>
    public sealed partial class SpeakSettingsV1Provider1
    {
        /// <summary>
        /// Provider type for text-to-speech
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.SpeakSettingsV1Provider1TypeJsonConverter))]
        public global::Deepgram.Realtime.SpeakSettingsV1Provider1Type Type { get; set; }

        /// <summary>
        /// Selects the Deepgram Flux TTS model family
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.SpeakSettingsV1Provider1VersionJsonConverter))]
        public global::Deepgram.Realtime.SpeakSettingsV1Provider1Version? Version { get; set; }

        /// <summary>
        /// Flux TTS model to use, in the format flux-{voice}-{language} (e.g. flux-alexis-en). See the Flux TTS voice catalog for the full list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.SpeakSettingsV1ProviderOneOf1ModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.SpeakSettingsV1ProviderOneOf1Model Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakSettingsV1Provider1" /> class.
        /// </summary>
        /// <param name="model">
        /// Flux TTS model to use, in the format flux-{voice}-{language} (e.g. flux-alexis-en). See the Flux TTS voice catalog for the full list.
        /// </param>
        /// <param name="type">
        /// Provider type for text-to-speech
        /// </param>
        /// <param name="version">
        /// Selects the Deepgram Flux TTS model family
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakSettingsV1Provider1(
            global::Deepgram.Realtime.SpeakSettingsV1ProviderOneOf1Model model,
            global::Deepgram.Realtime.SpeakSettingsV1Provider1Type type,
            global::Deepgram.Realtime.SpeakSettingsV1Provider1Version? version)
        {
            this.Type = type;
            this.Version = version;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakSettingsV1Provider1" /> class.
        /// </summary>
        public SpeakSettingsV1Provider1()
        {
        }

    }
}