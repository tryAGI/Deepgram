
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GroqThinkProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.GroqThinkProviderTypeJsonConverter))]
        public global::Deepgram.Realtime.GroqThinkProviderType Type { get; set; }

        /// <summary>
        /// The REST API version for the Groq's chat completions API (mostly OpenAI-compatible)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.GroqThinkProviderVersionJsonConverter))]
        public global::Deepgram.Realtime.GroqThinkProviderVersion? Version { get; set; }

        /// <summary>
        /// Groq model to use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.GroqThinkProviderModelJsonConverter))]
        public global::Deepgram.Realtime.GroqThinkProviderModel Model { get; set; }

        /// <summary>
        /// Groq temperature (0-2)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// OpenAI reasoning_effort
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.GroqThinkProviderReasoningModeJsonConverter))]
        public global::Deepgram.Realtime.GroqThinkProviderReasoningMode? ReasoningMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroqThinkProvider" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="version">
        /// The REST API version for the Groq's chat completions API (mostly OpenAI-compatible)
        /// </param>
        /// <param name="model">
        /// Groq model to use
        /// </param>
        /// <param name="temperature">
        /// Groq temperature (0-2)
        /// </param>
        /// <param name="reasoningMode">
        /// OpenAI reasoning_effort
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroqThinkProvider(
            global::Deepgram.Realtime.GroqThinkProviderType type,
            global::Deepgram.Realtime.GroqThinkProviderVersion? version,
            global::Deepgram.Realtime.GroqThinkProviderModel model,
            double? temperature,
            global::Deepgram.Realtime.GroqThinkProviderReasoningMode? reasoningMode)
        {
            this.Type = type;
            this.Version = version;
            this.Model = model;
            this.Temperature = temperature;
            this.ReasoningMode = reasoningMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroqThinkProvider" /> class.
        /// </summary>
        public GroqThinkProvider()
        {
        }

    }
}