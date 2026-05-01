
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1
    {
        /// <summary>
        /// Provider type for speech-to-text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1TypeJsonConverter))]
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1Type Type { get; set; }

        /// <summary>
        /// Specifies usage of the V2 Deepgram speech-to-text API (e.g. Flux)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1VersionJsonConverter))]
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1Version? Version { get; set; }

        /// <summary>
        /// Model to use for speech to text using the V2 API (e.g. flux-general-en, flux-general-multi)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// One or more BCP-47 language codes to bias the model toward specific languages. Only supported when model is flux-general-multi. Without hints, the model auto-detects the spoken language. See the Language Prompting guide for details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_hint")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintJsonConverter))]
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHint? LanguageHint { get; set; }

        /// <summary>
        /// Prompt keyterm recognition to improve Keyword Recall Rate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyterms")]
        public global::System.Collections.Generic.IList<string>? Keyterms { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1" /> class.
        /// </summary>
        /// <param name="model">
        /// Model to use for speech to text using the V2 API (e.g. flux-general-en, flux-general-multi)
        /// </param>
        /// <param name="type">
        /// Provider type for speech-to-text
        /// </param>
        /// <param name="version">
        /// Specifies usage of the V2 Deepgram speech-to-text API (e.g. Flux)
        /// </param>
        /// <param name="languageHint">
        /// One or more BCP-47 language codes to bias the model toward specific languages. Only supported when model is flux-general-multi. Without hints, the model auto-detects the spoken language. See the Language Prompting guide for details.
        /// </param>
        /// <param name="keyterms">
        /// Prompt keyterm recognition to improve Keyword Recall Rate
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1(
            string model,
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1Type type,
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1Version? version,
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHint? languageHint,
            global::System.Collections.Generic.IList<string>? keyterms)
        {
            this.Type = type;
            this.Version = version;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.LanguageHint = languageHint;
            this.Keyterms = keyterms;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1" /> class.
        /// </summary>
        public ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1()
        {
        }
    }
}