
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1AgentV1AgentAudioDone
    {
        /// <summary>
        /// Message type identifier indicating the agent has finished sending audio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1AgentAudioDoneTypeJsonConverter))]
        public global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDoneType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1AgentAudioDone" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier indicating the agent has finished sending audio
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1AgentV1AgentAudioDone(
            global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDoneType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1AgentAudioDone" /> class.
        /// </summary>
        public AgentV1AgentV1AgentAudioDone()
        {
        }
    }
}