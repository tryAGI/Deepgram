
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1AgentV1LatencyReport
    {
        /// <summary>
        /// Message type identifier for the latency report
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1LatencyReportTypeJsonConverter))]
        public global::Deepgram.Realtime.AgentV1AgentV1LatencyReportType Type { get; set; }

        /// <summary>
        /// Speech-to-text: time from audio received to transcript produced, in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stt_latency")]
        public string? SttLatency { get; set; }

        /// <summary>
        /// Time to first token of any type (text, tool call, or thinking), in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttt_token_latency")]
        public string? TttTokenLatency { get; set; }

        /// <summary>
        /// Time to first text token from the LLM, in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttt_text_latency")]
        public string? TttTextLatency { get; set; }

        /// <summary>
        /// Time to first tool-call token from the LLM, in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttt_tool_latency")]
        public string? TttToolLatency { get; set; }

        /// <summary>
        /// Time to first thinking token from the LLM, in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttt_thinking_latency")]
        public string? TttThinkingLatency { get; set; }

        /// <summary>
        /// Text-to-speech: time from first text token to first audio byte, in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_latency")]
        public string? TtsLatency { get; set; }

        /// <summary>
        /// End-to-end: time from user utterance end to first audio byte, in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_latency")]
        public string? TotalLatency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1LatencyReport" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier for the latency report
        /// </param>
        /// <param name="sttLatency">
        /// Speech-to-text: time from audio received to transcript produced, in seconds
        /// </param>
        /// <param name="tttTokenLatency">
        /// Time to first token of any type (text, tool call, or thinking), in seconds
        /// </param>
        /// <param name="tttTextLatency">
        /// Time to first text token from the LLM, in seconds
        /// </param>
        /// <param name="tttToolLatency">
        /// Time to first tool-call token from the LLM, in seconds
        /// </param>
        /// <param name="tttThinkingLatency">
        /// Time to first thinking token from the LLM, in seconds
        /// </param>
        /// <param name="ttsLatency">
        /// Text-to-speech: time from first text token to first audio byte, in seconds
        /// </param>
        /// <param name="totalLatency">
        /// End-to-end: time from user utterance end to first audio byte, in seconds
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1AgentV1LatencyReport(
            global::Deepgram.Realtime.AgentV1AgentV1LatencyReportType type,
            string? sttLatency,
            string? tttTokenLatency,
            string? tttTextLatency,
            string? tttToolLatency,
            string? tttThinkingLatency,
            string? ttsLatency,
            string? totalLatency)
        {
            this.Type = type;
            this.SttLatency = sttLatency;
            this.TttTokenLatency = tttTokenLatency;
            this.TttTextLatency = tttTextLatency;
            this.TttToolLatency = tttToolLatency;
            this.TttThinkingLatency = tttThinkingLatency;
            this.TtsLatency = ttsLatency;
            this.TotalLatency = totalLatency;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1LatencyReport" /> class.
        /// </summary>
        public AgentV1AgentV1LatencyReport()
        {
        }

    }
}