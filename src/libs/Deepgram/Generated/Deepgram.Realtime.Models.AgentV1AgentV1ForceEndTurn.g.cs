
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentV1AgentV1ForceEndTurn
    {
        /// <summary>
        /// Message type identifier for forcing the end of the current turn
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1ForceEndTurnTypeJsonConverter))]
        public global::Deepgram.Realtime.AgentV1AgentV1ForceEndTurnType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1ForceEndTurn" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier for forcing the end of the current turn
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1AgentV1ForceEndTurn(
            global::Deepgram.Realtime.AgentV1AgentV1ForceEndTurnType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1ForceEndTurn" /> class.
        /// </summary>
        public AgentV1AgentV1ForceEndTurn()
        {
        }

    }
}