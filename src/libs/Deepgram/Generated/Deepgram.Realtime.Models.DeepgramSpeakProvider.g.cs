
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeepgramSpeakProvider
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"deepgram"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "deepgram";

        /// <summary>
        /// The REST API version for the Deepgram text-to-speech API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.DeepgramSpeakProviderVersionJsonConverter))]
        public global::Deepgram.Realtime.DeepgramSpeakProviderVersion? Version { get; set; }

        /// <summary>
        /// Deepgram TTS model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.DeepgramSpeakProviderModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.DeepgramSpeakProviderModel Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeepgramSpeakProvider" /> class.
        /// </summary>
        /// <param name="model">
        /// Deepgram TTS model
        /// </param>
        /// <param name="version">
        /// The REST API version for the Deepgram text-to-speech API
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeepgramSpeakProvider(
            global::Deepgram.Realtime.DeepgramSpeakProviderModel model,
            global::Deepgram.Realtime.DeepgramSpeakProviderVersion? version,
            string type = "deepgram")
        {
            this.Type = type;
            this.Version = version;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeepgramSpeakProvider" /> class.
        /// </summary>
        public DeepgramSpeakProvider()
        {
        }
    }
}