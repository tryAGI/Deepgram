
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1SettingsMessageAudio
    {
        /// <summary>
        /// Audio input configuration settings. If omitted, defaults to encoding=linear16 and sample_rate=24000. Higher sample rates like 44100 Hz provide better audio quality.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::Deepgram.Realtime.AgentV1SettingsMessageAudioInput? Input { get; set; }

        /// <summary>
        /// Audio output configuration settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::Deepgram.Realtime.AgentV1SettingsMessageAudioOutput? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1SettingsMessageAudio" /> class.
        /// </summary>
        /// <param name="input">
        /// Audio input configuration settings. If omitted, defaults to encoding=linear16 and sample_rate=24000. Higher sample rates like 44100 Hz provide better audio quality.
        /// </param>
        /// <param name="output">
        /// Audio output configuration settings
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1SettingsMessageAudio(
            global::Deepgram.Realtime.AgentV1SettingsMessageAudioInput? input,
            global::Deepgram.Realtime.AgentV1SettingsMessageAudioOutput? output)
        {
            this.Input = input;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1SettingsMessageAudio" /> class.
        /// </summary>
        public AgentV1SettingsMessageAudio()
        {
        }
    }
}