
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChannelsAgentV1MessagesAgentV1SettingsAudio
    {
        /// <summary>
        /// Audio input configuration settings. If omitted, defaults to encoding=linear16 and sample_rate=24000. Higher sample rates like 44100 Hz provide better audio quality.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAudioInput? Input { get; set; }

        /// <summary>
        /// Audio output configuration settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAudioOutput? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsAgentV1MessagesAgentV1SettingsAudio" /> class.
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
        public ChannelsAgentV1MessagesAgentV1SettingsAudio(
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAudioInput? input,
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAudioOutput? output)
        {
            this.Input = input;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsAgentV1MessagesAgentV1SettingsAudio" /> class.
        /// </summary>
        public ChannelsAgentV1MessagesAgentV1SettingsAudio()
        {
        }

    }
}