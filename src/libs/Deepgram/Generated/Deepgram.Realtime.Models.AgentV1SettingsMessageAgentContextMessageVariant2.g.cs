
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Client-side or server-side function call request and response as part of the conversation history
    /// </summary>
    public sealed partial class AgentV1SettingsMessageAgentContextMessageVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"History"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "History";

        /// <summary>
        /// List of function call objects
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Deepgram.Realtime.AgentV1SettingsMessageAgentContextMessageVariant2FunctionCall> FunctionCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1SettingsMessageAgentContextMessageVariant2" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="functionCalls">
        /// List of function call objects
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1SettingsMessageAgentContextMessageVariant2(
            global::System.Collections.Generic.IList<global::Deepgram.Realtime.AgentV1SettingsMessageAgentContextMessageVariant2FunctionCall> functionCalls,
            string type = "History")
        {
            this.FunctionCalls = functionCalls ?? throw new global::System.ArgumentNullException(nameof(functionCalls));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1SettingsMessageAgentContextMessageVariant2" /> class.
        /// </summary>
        public AgentV1SettingsMessageAgentContextMessageVariant2()
        {
        }
    }
}