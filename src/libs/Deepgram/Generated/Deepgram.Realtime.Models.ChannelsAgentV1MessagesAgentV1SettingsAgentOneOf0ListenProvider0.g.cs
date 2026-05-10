
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0
    {
        /// <summary>
        /// Provider type for speech-to-text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0TypeJsonConverter))]
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0Type Type { get; set; }

        /// <summary>
        /// Specifies usage of the V1 Deepgram speech-to-text API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0VersionJsonConverter))]
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0Version? Version { get; set; }

        /// <summary>
        /// Model to use for speech to text using the V1 API (e.g. Nova-3, Nova-2)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Language code to use for speech-to-text. Can be a BCP-47 language tag (e.g. `en`), or `multi` for code-switching transcription<br/>
        /// Default Value: en-US
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Prompt keyterm recognition to improve Keyword Recall Rate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyterms")]
        public global::System.Collections.Generic.IList<string>? Keyterms { get; set; }

        /// <summary>
        /// Applies smart formatting to improve transcript readability<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smart_format")]
        public bool? SmartFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0" /> class.
        /// </summary>
        /// <param name="type">
        /// Provider type for speech-to-text
        /// </param>
        /// <param name="version">
        /// Specifies usage of the V1 Deepgram speech-to-text API
        /// </param>
        /// <param name="model">
        /// Model to use for speech to text using the V1 API (e.g. Nova-3, Nova-2)
        /// </param>
        /// <param name="language">
        /// Language code to use for speech-to-text. Can be a BCP-47 language tag (e.g. `en`), or `multi` for code-switching transcription<br/>
        /// Default Value: en-US
        /// </param>
        /// <param name="keyterms">
        /// Prompt keyterm recognition to improve Keyword Recall Rate
        /// </param>
        /// <param name="smartFormat">
        /// Applies smart formatting to improve transcript readability<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0(
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0Type type,
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0Version? version,
            string? model,
            string? language,
            global::System.Collections.Generic.IList<string>? keyterms,
            bool? smartFormat)
        {
            this.Type = type;
            this.Version = version;
            this.Model = model;
            this.Language = language;
            this.Keyterms = keyterms;
            this.SmartFormat = smartFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0" /> class.
        /// </summary>
        public ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0()
        {
        }

    }
}