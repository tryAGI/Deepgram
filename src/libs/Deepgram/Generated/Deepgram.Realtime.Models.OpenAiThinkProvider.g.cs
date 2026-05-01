
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAiThinkProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.OpenAiThinkProviderTypeJsonConverter))]
        public global::Deepgram.Realtime.OpenAiThinkProviderType Type { get; set; }

        /// <summary>
        /// The REST API version for the OpenAI chat completions API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.OpenAiThinkProviderVersionJsonConverter))]
        public global::Deepgram.Realtime.OpenAiThinkProviderVersion? Version { get; set; }

        /// <summary>
        /// OpenAI model to use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.OpenAiThinkProviderModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.OpenAiThinkProviderModel Model { get; set; }

        /// <summary>
        /// OpenAI temperature (0-2)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// OpenAI reasoning_effort
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.OpenAiThinkProviderReasoningModeJsonConverter))]
        public global::Deepgram.Realtime.OpenAiThinkProviderReasoningMode? ReasoningMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAiThinkProvider" /> class.
        /// </summary>
        /// <param name="model">
        /// OpenAI model to use
        /// </param>
        /// <param name="type"></param>
        /// <param name="version">
        /// The REST API version for the OpenAI chat completions API
        /// </param>
        /// <param name="temperature">
        /// OpenAI temperature (0-2)
        /// </param>
        /// <param name="reasoningMode">
        /// OpenAI reasoning_effort
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAiThinkProvider(
            global::Deepgram.Realtime.OpenAiThinkProviderModel model,
            global::Deepgram.Realtime.OpenAiThinkProviderType type,
            global::Deepgram.Realtime.OpenAiThinkProviderVersion? version,
            double? temperature,
            global::Deepgram.Realtime.OpenAiThinkProviderReasoningMode? reasoningMode)
        {
            this.Type = type;
            this.Version = version;
            this.Model = model;
            this.Temperature = temperature;
            this.ReasoningMode = reasoningMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAiThinkProvider" /> class.
        /// </summary>
        public OpenAiThinkProvider()
        {
        }
    }
}