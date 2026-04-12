
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChannelsAgentV1MessagesAgentV1FunctionCallRequestFunctionsItems
    {
        /// <summary>
        /// Unique identifier for the function call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the function to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// JSON string containing the function arguments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arguments { get; set; }

        /// <summary>
        /// Whether the function should be executed client-side
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_side")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ClientSide { get; set; }

        /// <summary>
        /// Some Gemini models require this as an additional function call identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thought_signature")]
        public string? ThoughtSignature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsAgentV1MessagesAgentV1FunctionCallRequestFunctionsItems" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the function call
        /// </param>
        /// <param name="name">
        /// The name of the function to call
        /// </param>
        /// <param name="arguments">
        /// JSON string containing the function arguments
        /// </param>
        /// <param name="clientSide">
        /// Whether the function should be executed client-side
        /// </param>
        /// <param name="thoughtSignature">
        /// Some Gemini models require this as an additional function call identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelsAgentV1MessagesAgentV1FunctionCallRequestFunctionsItems(
            string id,
            string name,
            string arguments,
            bool clientSide,
            string? thoughtSignature)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.ClientSide = clientSide;
            this.ThoughtSignature = thoughtSignature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsAgentV1MessagesAgentV1FunctionCallRequestFunctionsItems" /> class.
        /// </summary>
        public ChannelsAgentV1MessagesAgentV1FunctionCallRequestFunctionsItems()
        {
        }
    }
}