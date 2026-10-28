
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentV1AgentV1FrustrationDetected
    {
        /// <summary>
        /// Message type identifier for frustration detection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1FrustrationDetectedTypeJsonConverter))]
        public global::Deepgram.Realtime.AgentV1AgentV1FrustrationDetectedType Type { get; set; }

        /// <summary>
        /// Cumulative number of FrustrationDetected events in this session, starting at 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// True once `count` reaches `agent.think_live.provider.frustration_max_count`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("escalated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Escalated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1FrustrationDetected" /> class.
        /// </summary>
        /// <param name="count">
        /// Cumulative number of FrustrationDetected events in this session, starting at 1
        /// </param>
        /// <param name="escalated">
        /// True once `count` reaches `agent.think_live.provider.frustration_max_count`
        /// </param>
        /// <param name="type">
        /// Message type identifier for frustration detection
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1AgentV1FrustrationDetected(
            int count,
            bool escalated,
            global::Deepgram.Realtime.AgentV1AgentV1FrustrationDetectedType type)
        {
            this.Type = type;
            this.Count = count;
            this.Escalated = escalated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1FrustrationDetected" /> class.
        /// </summary>
        public AgentV1AgentV1FrustrationDetected()
        {
        }

    }
}