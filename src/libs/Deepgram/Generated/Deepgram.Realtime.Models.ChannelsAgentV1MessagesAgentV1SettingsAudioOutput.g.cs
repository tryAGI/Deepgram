
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Audio output configuration settings
    /// </summary>
    public sealed partial class ChannelsAgentV1MessagesAgentV1SettingsAudioOutput
    {
        /// <summary>
        /// Audio encoding format for streaming TTS output<br/>
        /// Default Value: linear16
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAudioOutputEncodingJsonConverter))]
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAudioOutputEncoding? Encoding { get; set; }

        /// <summary>
        /// Sample rate in Hz
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        public int? SampleRate { get; set; }

        /// <summary>
        /// Audio bitrate in bits per second
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitrate")]
        public int? Bitrate { get; set; }

        /// <summary>
        /// Audio container format.<br/>
        /// Default Value: none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAudioOutputContainerJsonConverter))]
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAudioOutputContainer? Container { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsAgentV1MessagesAgentV1SettingsAudioOutput" /> class.
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
        /// Audio container format.<br/>
        /// Default Value: none
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelsAgentV1MessagesAgentV1SettingsAudioOutput(
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAudioOutputEncoding? encoding,
            int? sampleRate,
            int? bitrate,
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAudioOutputContainer? container)
        {
            this.Encoding = encoding;
            this.SampleRate = sampleRate;
            this.Bitrate = bitrate;
            this.Container = container;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsAgentV1MessagesAgentV1SettingsAudioOutput" /> class.
        /// </summary>
        public ChannelsAgentV1MessagesAgentV1SettingsAudioOutput()
        {
        }
    }
}