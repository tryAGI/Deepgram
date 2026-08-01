
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GoogleThinkProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.GoogleThinkProviderTypeJsonConverter))]
        public global::Deepgram.Realtime.GoogleThinkProviderType Type { get; set; }

        /// <summary>
        /// The Google API used for the request: ai-studio-v1beta for the AI Studio API, or gemini-enterprise-agent-v1 for the Gemini Enterprise Agent (GEA) API. v1beta is accepted as an alias for ai-studio-v1beta. Defaults based on the Deepgram Voice Agent endpoint you connect to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.GoogleThinkProviderVersionJsonConverter))]
        public global::Deepgram.Realtime.GoogleThinkProviderVersion? Version { get; set; }

        /// <summary>
        /// Google model to use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.GoogleThinkProviderModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.GoogleThinkProviderModel Model { get; set; }

        /// <summary>
        /// Google temperature (0-2)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleThinkProvider" /> class.
        /// </summary>
        /// <param name="model">
        /// Google model to use
        /// </param>
        /// <param name="type"></param>
        /// <param name="version">
        /// The Google API used for the request: ai-studio-v1beta for the AI Studio API, or gemini-enterprise-agent-v1 for the Gemini Enterprise Agent (GEA) API. v1beta is accepted as an alias for ai-studio-v1beta. Defaults based on the Deepgram Voice Agent endpoint you connect to.
        /// </param>
        /// <param name="temperature">
        /// Google temperature (0-2)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoogleThinkProvider(
            global::Deepgram.Realtime.GoogleThinkProviderModel model,
            global::Deepgram.Realtime.GoogleThinkProviderType type,
            global::Deepgram.Realtime.GoogleThinkProviderVersion? version,
            double? temperature)
        {
            this.Type = type;
            this.Version = version;
            this.Model = model;
            this.Temperature = temperature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleThinkProvider" /> class.
        /// </summary>
        public GoogleThinkProvider()
        {
        }

    }
}