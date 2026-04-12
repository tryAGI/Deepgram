
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItemsOneOf1FunctionCallsItems
    {
        /// <summary>
        /// Unique identifier for the function call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the function called
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Indicates if the call was client-side or server-side
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_side")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ClientSide { get; set; }

        /// <summary>
        /// Arguments passed to the function
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arguments { get; set; }

        /// <summary>
        /// Response from the function call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Response { get; set; }

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
        /// Initializes a new instance of the <see cref="ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItemsOneOf1FunctionCallsItems" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the function call
        /// </param>
        /// <param name="name">
        /// Name of the function called
        /// </param>
        /// <param name="clientSide">
        /// Indicates if the call was client-side or server-side
        /// </param>
        /// <param name="arguments">
        /// Arguments passed to the function
        /// </param>
        /// <param name="response">
        /// Response from the function call
        /// </param>
        /// <param name="thoughtSignature">
        /// Some Gemini models require this as an additional function call identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItemsOneOf1FunctionCallsItems(
            string id,
            string name,
            bool clientSide,
            string arguments,
            string response,
            string? thoughtSignature)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ClientSide = clientSide;
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Response = response ?? throw new global::System.ArgumentNullException(nameof(response));
            this.ThoughtSignature = thoughtSignature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItemsOneOf1FunctionCallsItems" /> class.
        /// </summary>
        public ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItemsOneOf1FunctionCallsItems()
        {
        }
    }
}