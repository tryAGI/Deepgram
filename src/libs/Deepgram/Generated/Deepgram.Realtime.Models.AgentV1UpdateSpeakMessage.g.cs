
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1UpdateSpeakMessage
    {
        /// <summary>
        /// Message type identifier for updating the speak model
        /// </summary>
        /// <default>"UpdateSpeak"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "UpdateSpeak";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speak")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.OneOfJsonConverter<global::Deepgram.Realtime.SpeakSettingsV1, global::System.Collections.Generic.IList<global::Deepgram.Realtime.SpeakSettingsV1>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.OneOf<global::Deepgram.Realtime.SpeakSettingsV1, global::System.Collections.Generic.IList<global::Deepgram.Realtime.SpeakSettingsV1>> Speak { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1UpdateSpeakMessage" /> class.
        /// </summary>
        /// <param name="speak"></param>
        /// <param name="type">
        /// Message type identifier for updating the speak model
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1UpdateSpeakMessage(
            global::Deepgram.Realtime.OneOf<global::Deepgram.Realtime.SpeakSettingsV1, global::System.Collections.Generic.IList<global::Deepgram.Realtime.SpeakSettingsV1>> speak,
            string type = "UpdateSpeak")
        {
            this.Type = type;
            this.Speak = speak;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1UpdateSpeakMessage" /> class.
        /// </summary>
        public AgentV1UpdateSpeakMessage()
        {
        }
    }
}