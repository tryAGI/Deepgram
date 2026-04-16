
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Audio input configuration settings. If omitted, defaults to encoding=linear16 and sample_rate=24000. Higher sample rates like 44100 Hz provide better audio quality.
    /// </summary>
    public sealed partial class ChannelsAgentV1MessagesAgentV1SettingsAudioInput
    {
        /// <summary>
        /// Audio encoding format<br/>
        /// Default Value: linear16
        /// </summary>
        /// <default>global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncoding.Linear16</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncodingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncoding Encoding { get; set; } = global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncoding.Linear16;

        /// <summary>
        /// Sample rate in Hz. Common values are 16000, 24000, 44100, 48000<br/>
        /// Default Value: 24000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SampleRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsAgentV1MessagesAgentV1SettingsAudioInput" /> class.
        /// </summary>
        /// <param name="encoding">
        /// Audio encoding format<br/>
        /// Default Value: linear16
        /// </param>
        /// <param name="sampleRate">
        /// Sample rate in Hz. Common values are 16000, 24000, 44100, 48000<br/>
        /// Default Value: 24000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelsAgentV1MessagesAgentV1SettingsAudioInput(
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncoding encoding,
            int sampleRate)
        {
            this.Encoding = encoding;
            this.SampleRate = sampleRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsAgentV1MessagesAgentV1SettingsAudioInput" /> class.
        /// </summary>
        public ChannelsAgentV1MessagesAgentV1SettingsAudioInput()
        {
        }
    }
}