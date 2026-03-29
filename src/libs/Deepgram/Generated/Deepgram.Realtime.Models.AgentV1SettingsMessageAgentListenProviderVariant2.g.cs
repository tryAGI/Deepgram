
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1SettingsMessageAgentListenProviderVariant2
    {
        /// <summary>
        /// Provider type for speech-to-text
        /// </summary>
        /// <default>"deepgram"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "deepgram";

        /// <summary>
        /// Specifies usage of the V2 Deepgram speech-to-text API (e.g. Flux)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Model to use for speech to text using the V2 API (e.g. flux-general-en)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyterms")]
        public global::System.Collections.Generic.IList<string>? Keyterms { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1SettingsMessageAgentListenProviderVariant2" /> class.
        /// </summary>
        /// <param name="model">
        /// Model to use for speech to text using the V2 API (e.g. flux-general-en)
        /// </param>
        /// <param name="version">
        /// Specifies usage of the V2 Deepgram speech-to-text API (e.g. Flux)
        /// </param>
        /// <param name="keyterms"></param>
        /// <param name="type">
        /// Provider type for speech-to-text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1SettingsMessageAgentListenProviderVariant2(
            string model,
            string? version,
            global::System.Collections.Generic.IList<string>? keyterms,
            string type = "deepgram")
        {
            this.Type = type;
            this.Version = version;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Keyterms = keyterms;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1SettingsMessageAgentListenProviderVariant2" /> class.
        /// </summary>
        public AgentV1SettingsMessageAgentListenProviderVariant2()
        {
        }
    }
}