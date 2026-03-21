
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1UserStartedSpeakingEvent
    {
        /// <summary>
        /// Message type identifier indicating that the user has begun speaking
        /// </summary>
        /// <default>"UserStartedSpeaking"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "UserStartedSpeaking";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1UserStartedSpeakingEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier indicating that the user has begun speaking
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1UserStartedSpeakingEvent(
            string type = "UserStartedSpeaking")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1UserStartedSpeakingEvent" /> class.
        /// </summary>
        public AgentV1UserStartedSpeakingEvent()
        {
        }
    }
}