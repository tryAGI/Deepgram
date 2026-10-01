
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentV1AgentV1CustomFromThinkProvider
    {
        /// <summary>
        /// Message type identifier for a custom payload returned by the think provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1CustomFromThinkProviderTypeJsonConverter))]
        public global::Deepgram.Realtime.AgentV1AgentV1CustomFromThinkProviderType Type { get; set; }

        /// <summary>
        /// The think provider's response body, passed through unchanged. If the provider's response is not valid JSON, it arrives as a JSON string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1CustomFromThinkProvider" /> class.
        /// </summary>
        /// <param name="content">
        /// The think provider's response body, passed through unchanged. If the provider's response is not valid JSON, it arrives as a JSON string
        /// </param>
        /// <param name="type">
        /// Message type identifier for a custom payload returned by the think provider
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1AgentV1CustomFromThinkProvider(
            object content,
            global::Deepgram.Realtime.AgentV1AgentV1CustomFromThinkProviderType type)
        {
            this.Type = type;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1CustomFromThinkProvider" /> class.
        /// </summary>
        public AgentV1AgentV1CustomFromThinkProvider()
        {
        }

    }
}