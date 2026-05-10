
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Client-side or server-side function call request and response as part of the conversation history
    /// </summary>
    public sealed partial class AgentV1AgentV1History1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1History1TypeJsonConverter))]
        public global::Deepgram.Realtime.AgentV1AgentV1History1Type Type { get; set; }

        /// <summary>
        /// List of function call objects
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1HistoryOneOf1FunctionCallsItems> FunctionCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1History1" /> class.
        /// </summary>
        /// <param name="functionCalls">
        /// List of function call objects
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1AgentV1History1(
            global::System.Collections.Generic.IList<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1HistoryOneOf1FunctionCallsItems> functionCalls,
            global::Deepgram.Realtime.AgentV1AgentV1History1Type type)
        {
            this.Type = type;
            this.FunctionCalls = functionCalls ?? throw new global::System.ArgumentNullException(nameof(functionCalls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1History1" /> class.
        /// </summary>
        public AgentV1AgentV1History1()
        {
        }

    }
}