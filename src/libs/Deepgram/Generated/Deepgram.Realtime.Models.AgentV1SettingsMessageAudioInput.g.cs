
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Audio input configuration settings. If omitted, defaults to encoding=linear16 and sample_rate=24000. Higher sample rates like 44100 Hz provide better audio quality.
    /// </summary>
    public sealed partial class AgentV1SettingsMessageAudioInput
    {
        /// <summary>
        /// Audio encoding format<br/>
        /// Default Value: linear16
        /// </summary>
        /// <default>global::Deepgram.Realtime.AgentV1SettingsMessageAudioInputEncoding.Linear16</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AgentV1SettingsMessageAudioInputEncodingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.AgentV1SettingsMessageAudioInputEncoding Encoding { get; set; } = global::Deepgram.Realtime.AgentV1SettingsMessageAudioInputEncoding.Linear16;

        /// <summary>
        /// Sample rate in Hz. Common values are 16000, 24000, 44100, 48000<br/>
        /// Default Value: 24000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SampleRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1SettingsMessageAudioInput" /> class.
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
        public AgentV1SettingsMessageAudioInput(
            global::Deepgram.Realtime.AgentV1SettingsMessageAudioInputEncoding encoding,
            double sampleRate)
        {
            this.Encoding = encoding;
            this.SampleRate = sampleRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1SettingsMessageAudioInput" /> class.
        /// </summary>
        public AgentV1SettingsMessageAudioInput()
        {
        }
    }
}