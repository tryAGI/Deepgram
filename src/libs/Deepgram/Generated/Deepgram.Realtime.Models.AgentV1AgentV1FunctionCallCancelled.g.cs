
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentV1AgentV1FunctionCallCancelled
    {
        /// <summary>
        /// Message type identifier for cancelled function calls
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1FunctionCallCancelledTypeJsonConverter))]
        public global::Deepgram.Realtime.AgentV1AgentV1FunctionCallCancelledType Type { get; set; }

        /// <summary>
        /// The function calls that are no longer valid
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1FunctionCallCancelledFunctionsItems> Functions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1FunctionCallCancelled" /> class.
        /// </summary>
        /// <param name="functions">
        /// The function calls that are no longer valid
        /// </param>
        /// <param name="type">
        /// Message type identifier for cancelled function calls
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1AgentV1FunctionCallCancelled(
            global::System.Collections.Generic.IList<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1FunctionCallCancelledFunctionsItems> functions,
            global::Deepgram.Realtime.AgentV1AgentV1FunctionCallCancelledType type)
        {
            this.Type = type;
            this.Functions = functions ?? throw new global::System.ArgumentNullException(nameof(functions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1FunctionCallCancelled" /> class.
        /// </summary>
        public AgentV1AgentV1FunctionCallCancelled()
        {
        }

    }
}