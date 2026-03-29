
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1SettingsMessageAgentListenProviderVariant1
    {
        /// <summary>
        /// Provider type for speech-to-text
        /// </summary>
        /// <default>"deepgram"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "deepgram";

        /// <summary>
        /// Specifies usage of the V1 Deepgram speech-to-text API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

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
        /// 
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
        /// Initializes a new instance of the <see cref="AgentV1SettingsMessageAgentListenProviderVariant1" /> class.
        /// </summary>
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
        /// <param name="keyterms"></param>
        /// <param name="smartFormat">
        /// Applies smart formatting to improve transcript readability<br/>
        /// Default Value: false
        /// </param>
        /// <param name="type">
        /// Provider type for speech-to-text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1SettingsMessageAgentListenProviderVariant1(
            string? version,
            string? model,
            string? language,
            global::System.Collections.Generic.IList<string>? keyterms,
            bool? smartFormat,
            string type = "deepgram")
        {
            this.Type = type;
            this.Version = version;
            this.Model = model;
            this.Language = language;
            this.Keyterms = keyterms;
            this.SmartFormat = smartFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1SettingsMessageAgentListenProviderVariant1" /> class.
        /// </summary>
        public AgentV1SettingsMessageAgentListenProviderVariant1()
        {
        }
    }
}