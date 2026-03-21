
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Function call response message used bidirectionally:<br/>
    /// • **Client → Server**: Response after client executes a function<br/>
    ///   marked as client_side: true<br/>
    /// • **Server → Client**: Response after server executes a function<br/>
    ///   marked as client_side: false<br/>
    /// The same message structure serves both directions, enabling a unified<br/>
    /// interface for function call responses regardless of execution location.
    /// </summary>
    public sealed partial class AgentV1FunctionCallResponseMessage
    {
        /// <summary>
        /// Message type identifier for function call responses
        /// </summary>
        /// <default>"FunctionCallResponse"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "FunctionCallResponse";

        /// <summary>
        /// The unique identifier for the function call.<br/>
        /// • **Required for client responses**: Should match the id from<br/>
        ///   the corresponding `FunctionCallRequest`<br/>
        /// • **Optional for server responses**: Server may omit when responding<br/>
        ///   to internal function executions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the function being called
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The content or result of the function call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1FunctionCallResponseMessage" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier for function call responses
        /// </param>
        /// <param name="id">
        /// The unique identifier for the function call.<br/>
        /// • **Required for client responses**: Should match the id from<br/>
        ///   the corresponding `FunctionCallRequest`<br/>
        /// • **Optional for server responses**: Server may omit when responding<br/>
        ///   to internal function executions
        /// </param>
        /// <param name="name">
        /// The name of the function being called
        /// </param>
        /// <param name="content">
        /// The content or result of the function call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1FunctionCallResponseMessage(
            string name,
            string content,
            string? id,
            string type = "FunctionCallResponse")
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Type = type;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1FunctionCallResponseMessage" /> class.
        /// </summary>
        public AgentV1FunctionCallResponseMessage()
        {
        }
    }
}