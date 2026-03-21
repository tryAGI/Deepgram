
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1UpdateThinkMessage
    {
        /// <summary>
        /// Message type identifier for updating the think model
        /// </summary>
        /// <default>"UpdateThink"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "UpdateThink";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("think")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.OneOfJsonConverter<global::Deepgram.Realtime.ThinkSettingsV1, global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.OneOf<global::Deepgram.Realtime.ThinkSettingsV1, global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1>> Think { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1UpdateThinkMessage" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier for updating the think model
        /// </param>
        /// <param name="think"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1UpdateThinkMessage(
            global::Deepgram.Realtime.OneOf<global::Deepgram.Realtime.ThinkSettingsV1, global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1>> think,
            string type = "UpdateThink")
        {
            this.Think = think;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1UpdateThinkMessage" /> class.
        /// </summary>
        public AgentV1UpdateThinkMessage()
        {
        }
    }
}