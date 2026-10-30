
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Deepgram-hosted language models for the Voice Agent think stage.
    /// </summary>
    public sealed partial class DeepgramThinkProvider
    {
        /// <summary>
        /// Provider type for Deepgram-hosted language models. Must be `deepgram`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.DeepgramThinkProviderTypeJsonConverter))]
        public global::Deepgram.Realtime.DeepgramThinkProviderType Type { get; set; }

        /// <summary>
        /// Deepgram language model to use. Early Access. think-fast requires the Model Improvement Program: a session with mip_opt_out set to true is rejected with INVALID_SETTINGS. Use phonellm-mini-alpha-2-fp8 for sessions that opt out.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.DeepgramThinkProviderModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.DeepgramThinkProviderModel Model { get; set; }

        /// <summary>
        /// API version for the Deepgram think provider. Defaults to `v1`.<br/>
        /// Default Value: v1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.DeepgramThinkProviderVersionJsonConverter))]
        public global::Deepgram.Realtime.DeepgramThinkProviderVersion? Version { get; set; }

        /// <summary>
        /// Deepgram temperature (0-2).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Reasoning effort. For phonellm-mini-alpha-2-fp8, use none or omit it; other values put reasoning text in the reply, which the agent speaks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.DeepgramThinkProviderReasoningModeJsonConverter))]
        public global::Deepgram.Realtime.DeepgramThinkProviderReasoningMode? ReasoningMode { get; set; }

        /// <summary>
        /// With think-fast, Deepgram places spoken-style instructions ahead of your prompt and sends a VOICE_PROMPT_ADDED warning. Set to true to send your prompt unchanged.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_prompt_opt_out")]
        public bool? VoicePromptOptOut { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeepgramThinkProvider" /> class.
        /// </summary>
        /// <param name="model">
        /// Deepgram language model to use. Early Access. think-fast requires the Model Improvement Program: a session with mip_opt_out set to true is rejected with INVALID_SETTINGS. Use phonellm-mini-alpha-2-fp8 for sessions that opt out.
        /// </param>
        /// <param name="type">
        /// Provider type for Deepgram-hosted language models. Must be `deepgram`.
        /// </param>
        /// <param name="version">
        /// API version for the Deepgram think provider. Defaults to `v1`.<br/>
        /// Default Value: v1
        /// </param>
        /// <param name="temperature">
        /// Deepgram temperature (0-2).
        /// </param>
        /// <param name="reasoningMode">
        /// Reasoning effort. For phonellm-mini-alpha-2-fp8, use none or omit it; other values put reasoning text in the reply, which the agent speaks.
        /// </param>
        /// <param name="voicePromptOptOut">
        /// With think-fast, Deepgram places spoken-style instructions ahead of your prompt and sends a VOICE_PROMPT_ADDED warning. Set to true to send your prompt unchanged.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeepgramThinkProvider(
            global::Deepgram.Realtime.DeepgramThinkProviderModel model,
            global::Deepgram.Realtime.DeepgramThinkProviderType type,
            global::Deepgram.Realtime.DeepgramThinkProviderVersion? version,
            double? temperature,
            global::Deepgram.Realtime.DeepgramThinkProviderReasoningMode? reasoningMode,
            bool? voicePromptOptOut)
        {
            this.Type = type;
            this.Model = model;
            this.Version = version;
            this.Temperature = temperature;
            this.ReasoningMode = reasoningMode;
            this.VoicePromptOptOut = voicePromptOptOut;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeepgramThinkProvider" /> class.
        /// </summary>
        public DeepgramThinkProvider()
        {
        }

    }
}