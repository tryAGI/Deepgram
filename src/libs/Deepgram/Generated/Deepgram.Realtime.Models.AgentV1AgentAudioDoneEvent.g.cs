
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1AgentAudioDoneEvent
    {
        /// <summary>
        /// Message type identifier indicating the agent has finished sending audio
        /// </summary>
        /// <default>"AgentAudioDone"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "AgentAudioDone";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentAudioDoneEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier indicating the agent has finished sending audio
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1AgentAudioDoneEvent(
            string type = "AgentAudioDone")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentAudioDoneEvent" /> class.
        /// </summary>
        public AgentV1AgentAudioDoneEvent()
        {
        }
    }
}