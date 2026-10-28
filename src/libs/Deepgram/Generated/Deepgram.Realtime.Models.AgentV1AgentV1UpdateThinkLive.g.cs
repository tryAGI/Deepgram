
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentV1AgentV1UpdateThinkLive
    {
        /// <summary>
        /// Message type identifier for updating the Think Live model configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1UpdateThinkLiveTypeJsonConverter))]
        public global::Deepgram.Realtime.AgentV1AgentV1UpdateThinkLiveType Type { get; set; }

        /// <summary>
        /// Configures Deepgram's Think Live model. Think Live is off until this object is provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("think_live")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.ThinkLiveSettingsV1 ThinkLive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1UpdateThinkLive" /> class.
        /// </summary>
        /// <param name="thinkLive">
        /// Configures Deepgram's Think Live model. Think Live is off until this object is provided
        /// </param>
        /// <param name="type">
        /// Message type identifier for updating the Think Live model configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1AgentV1UpdateThinkLive(
            global::Deepgram.Realtime.ThinkLiveSettingsV1 thinkLive,
            global::Deepgram.Realtime.AgentV1AgentV1UpdateThinkLiveType type)
        {
            this.Type = type;
            this.ThinkLive = thinkLive ?? throw new global::System.ArgumentNullException(nameof(thinkLive));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1UpdateThinkLive" /> class.
        /// </summary>
        public AgentV1AgentV1UpdateThinkLive()
        {
        }

    }
}