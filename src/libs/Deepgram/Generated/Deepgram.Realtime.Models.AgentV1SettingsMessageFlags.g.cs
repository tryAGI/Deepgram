
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1SettingsMessageFlags
    {
        /// <summary>
        /// Enable or disable history message reporting<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history")]
        public bool? History { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1SettingsMessageFlags" /> class.
        /// </summary>
        /// <param name="history">
        /// Enable or disable history message reporting<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1SettingsMessageFlags(
            bool? history)
        {
            this.History = history;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1SettingsMessageFlags" /> class.
        /// </summary>
        public AgentV1SettingsMessageFlags()
        {
        }
    }
}