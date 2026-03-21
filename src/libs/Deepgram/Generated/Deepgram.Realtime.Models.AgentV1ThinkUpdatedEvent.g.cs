
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1ThinkUpdatedEvent
    {
        /// <summary>
        /// Message type identifier for think update confirmation
        /// </summary>
        /// <default>"ThinkUpdated"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "ThinkUpdated";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1ThinkUpdatedEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier for think update confirmation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1ThinkUpdatedEvent(
            string type = "ThinkUpdated")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1ThinkUpdatedEvent" /> class.
        /// </summary>
        public AgentV1ThinkUpdatedEvent()
        {
        }
    }
}