
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1AgentV1AgentStartedSpeaking
    {
        /// <summary>
        /// Message type identifier for agent started speaking
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1AgentStartedSpeakingTypeJsonConverter))]
        public global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeakingType Type { get; set; }

        /// <summary>
        /// Seconds from receiving the user's utterance to producing the agent's reply
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_latency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalLatency { get; set; }

        /// <summary>
        /// The portion of total latency attributable to text-to-speech
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_latency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TtsLatency { get; set; }

        /// <summary>
        /// The portion of total latency attributable to text-to-text (usually an LLM)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttt_latency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TttLatency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1AgentStartedSpeaking" /> class.
        /// </summary>
        /// <param name="totalLatency">
        /// Seconds from receiving the user's utterance to producing the agent's reply
        /// </param>
        /// <param name="ttsLatency">
        /// The portion of total latency attributable to text-to-speech
        /// </param>
        /// <param name="tttLatency">
        /// The portion of total latency attributable to text-to-text (usually an LLM)
        /// </param>
        /// <param name="type">
        /// Message type identifier for agent started speaking
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1AgentV1AgentStartedSpeaking(
            double totalLatency,
            double ttsLatency,
            double tttLatency,
            global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeakingType type)
        {
            this.Type = type;
            this.TotalLatency = totalLatency;
            this.TtsLatency = ttsLatency;
            this.TttLatency = tttLatency;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1AgentStartedSpeaking" /> class.
        /// </summary>
        public AgentV1AgentV1AgentStartedSpeaking()
        {
        }
    }
}