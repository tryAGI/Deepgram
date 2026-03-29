
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1FunctionCallRequestEvent
    {
        /// <summary>
        /// Message type identifier for function call requests
        /// </summary>
        /// <default>"FunctionCallRequest"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "FunctionCallRequest";

        /// <summary>
        /// Array of functions to be called
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Deepgram.Realtime.AgentV1FunctionCallRequestEventFunctions> Functions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1FunctionCallRequestEvent" /> class.
        /// </summary>
        /// <param name="functions">
        /// Array of functions to be called
        /// </param>
        /// <param name="type">
        /// Message type identifier for function call requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1FunctionCallRequestEvent(
            global::System.Collections.Generic.IList<global::Deepgram.Realtime.AgentV1FunctionCallRequestEventFunctions> functions,
            string type = "FunctionCallRequest")
        {
            this.Type = type;
            this.Functions = functions ?? throw new global::System.ArgumentNullException(nameof(functions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1FunctionCallRequestEvent" /> class.
        /// </summary>
        public AgentV1FunctionCallRequestEvent()
        {
        }
    }
}