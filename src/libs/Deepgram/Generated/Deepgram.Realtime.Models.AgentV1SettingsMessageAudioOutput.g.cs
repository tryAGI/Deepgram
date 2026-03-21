
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Audio output configuration settings
    /// </summary>
    public sealed partial class AgentV1SettingsMessageAudioOutput
    {
        /// <summary>
        /// Audio encoding format for streaming TTS output<br/>
        /// Default Value: linear16
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AgentV1SettingsMessageAudioOutputEncodingJsonConverter))]
        public global::Deepgram.Realtime.AgentV1SettingsMessageAudioOutputEncoding? Encoding { get; set; }

        /// <summary>
        /// Sample rate in Hz
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        public double? SampleRate { get; set; }

        /// <summary>
        /// Audio bitrate in bits per second
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitrate")]
        public double? Bitrate { get; set; }

        /// <summary>
        /// Audio container format. If omitted, defaults to 'none'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container")]
        public string? Container { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1SettingsMessageAudioOutput" /> class.
        /// </summary>
        /// <param name="encoding">
        /// Audio encoding format for streaming TTS output<br/>
        /// Default Value: linear16
        /// </param>
        /// <param name="sampleRate">
        /// Sample rate in Hz
        /// </param>
        /// <param name="bitrate">
        /// Audio bitrate in bits per second
        /// </param>
        /// <param name="container">
        /// Audio container format. If omitted, defaults to 'none'
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1SettingsMessageAudioOutput(
            global::Deepgram.Realtime.AgentV1SettingsMessageAudioOutputEncoding? encoding,
            double? sampleRate,
            double? bitrate,
            string? container)
        {
            this.Encoding = encoding;
            this.SampleRate = sampleRate;
            this.Bitrate = bitrate;
            this.Container = container;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1SettingsMessageAudioOutput" /> class.
        /// </summary>
        public AgentV1SettingsMessageAudioOutput()
        {
        }
    }
}