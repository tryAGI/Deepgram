
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1SettingsAppliedEvent
    {
        /// <summary>
        /// Message type identifier for settings applied confirmation
        /// </summary>
        /// <default>"SettingsApplied"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "SettingsApplied";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1SettingsAppliedEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier for settings applied confirmation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1SettingsAppliedEvent(
            string type = "SettingsApplied")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1SettingsAppliedEvent" /> class.
        /// </summary>
        public AgentV1SettingsAppliedEvent()
        {
        }
    }
}