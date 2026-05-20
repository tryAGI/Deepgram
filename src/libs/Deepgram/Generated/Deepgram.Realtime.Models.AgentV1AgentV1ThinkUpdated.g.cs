
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1AgentV1ThinkUpdated
    {
        /// <summary>
        /// Message type identifier for think update confirmation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1ThinkUpdatedTypeJsonConverter))]
        public global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdatedType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1ThinkUpdated" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier for think update confirmation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1AgentV1ThinkUpdated(
            global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdatedType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1ThinkUpdated" /> class.
        /// </summary>
        public AgentV1AgentV1ThinkUpdated()
        {
        }

    }
}