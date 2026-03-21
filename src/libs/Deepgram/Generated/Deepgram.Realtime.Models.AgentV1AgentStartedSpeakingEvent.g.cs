
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1AgentStartedSpeakingEvent
    {
        /// <summary>
        /// Message type identifier for agent started speaking
        /// </summary>
        /// <default>"AgentStartedSpeaking"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "AgentStartedSpeaking";

        /// <summary>
        /// Seconds from receiving the user's utterance to producing the agent's reply
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_latency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float TotalLatency { get; set; }

        /// <summary>
        /// The portion of total latency attributable to text-to-speech
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_latency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float TtsLatency { get; set; }

        /// <summary>
        /// The portion of total latency attributable to text-to-text (usually an LLM)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttt_latency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float TttLatency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentStartedSpeakingEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier for agent started speaking
        /// </param>
        /// <param name="totalLatency">
        /// Seconds from receiving the user's utterance to producing the agent's reply
        /// </param>
        /// <param name="ttsLatency">
        /// The portion of total latency attributable to text-to-speech
        /// </param>
        /// <param name="tttLatency">
        /// The portion of total latency attributable to text-to-text (usually an LLM)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1AgentStartedSpeakingEvent(
            float totalLatency,
            float ttsLatency,
            float tttLatency,
            string type = "AgentStartedSpeaking")
        {
            this.TotalLatency = totalLatency;
            this.TtsLatency = ttsLatency;
            this.TttLatency = tttLatency;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentStartedSpeakingEvent" /> class.
        /// </summary>
        public AgentV1AgentStartedSpeakingEvent()
        {
        }
    }
}