
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentV1AgentV1CustomToThinkProvider
    {
        /// <summary>
        /// Message type identifier for sending a custom payload to the think provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1CustomToThinkProviderTypeJsonConverter))]
        public global::Deepgram.Realtime.AgentV1AgentV1CustomToThinkProviderType Type { get; set; }

        /// <summary>
        /// Any valid JSON value (object, array, string, number, boolean, or null). Deepgram forwards it to the think provider without validation
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
        /// Initializes a new instance of the <see cref="AgentV1AgentV1CustomToThinkProvider" /> class.
        /// </summary>
        /// <param name="content">
        /// Any valid JSON value (object, array, string, number, boolean, or null). Deepgram forwards it to the think provider without validation
        /// </param>
        /// <param name="type">
        /// Message type identifier for sending a custom payload to the think provider
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1AgentV1CustomToThinkProvider(
            object content,
            global::Deepgram.Realtime.AgentV1AgentV1CustomToThinkProviderType type)
        {
            this.Type = type;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1CustomToThinkProvider" /> class.
        /// </summary>
        public AgentV1AgentV1CustomToThinkProvider()
        {
        }

    }
}