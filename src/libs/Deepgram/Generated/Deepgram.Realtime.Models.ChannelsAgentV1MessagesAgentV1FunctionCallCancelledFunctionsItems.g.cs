
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChannelsAgentV1MessagesAgentV1FunctionCallCancelledFunctionsItems
    {
        /// <summary>
        /// The id from the FunctionCallRequest that is now cancelled. Send no FunctionCallResponse for this id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the cancelled function
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsAgentV1MessagesAgentV1FunctionCallCancelledFunctionsItems" /> class.
        /// </summary>
        /// <param name="id">
        /// The id from the FunctionCallRequest that is now cancelled. Send no FunctionCallResponse for this id
        /// </param>
        /// <param name="name">
        /// The name of the cancelled function
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelsAgentV1MessagesAgentV1FunctionCallCancelledFunctionsItems(
            string id,
            string name)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsAgentV1MessagesAgentV1FunctionCallCancelledFunctionsItems" /> class.
        /// </summary>
        public ChannelsAgentV1MessagesAgentV1FunctionCallCancelledFunctionsItems()
        {
        }

    }
}