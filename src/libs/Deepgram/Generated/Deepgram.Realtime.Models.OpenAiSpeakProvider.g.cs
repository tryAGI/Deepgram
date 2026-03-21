
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAiSpeakProvider
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"open_ai"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "open_ai";

        /// <summary>
        /// The REST API version for the OpenAI text-to-speech API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.OpenAiSpeakProviderVersionJsonConverter))]
        public global::Deepgram.Realtime.OpenAiSpeakProviderVersion? Version { get; set; }

        /// <summary>
        /// OpenAI TTS model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.OpenAiSpeakProviderModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.OpenAiSpeakProviderModel Model { get; set; }

        /// <summary>
        /// OpenAI voice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.OpenAiSpeakProviderVoiceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.OpenAiSpeakProviderVoice Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAiSpeakProvider" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="version">
        /// The REST API version for the OpenAI text-to-speech API
        /// </param>
        /// <param name="model">
        /// OpenAI TTS model
        /// </param>
        /// <param name="voice">
        /// OpenAI voice
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAiSpeakProvider(
            global::Deepgram.Realtime.OpenAiSpeakProviderModel model,
            global::Deepgram.Realtime.OpenAiSpeakProviderVoice voice,
            global::Deepgram.Realtime.OpenAiSpeakProviderVersion? version,
            string type = "open_ai")
        {
            this.Model = model;
            this.Voice = voice;
            this.Type = type;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAiSpeakProvider" /> class.
        /// </summary>
        public OpenAiSpeakProvider()
        {
        }
    }
}