
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnthropicThinkProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AnthropicThinkProviderTypeJsonConverter))]
        public global::Deepgram.Realtime.AnthropicThinkProviderType Type { get; set; }

        /// <summary>
        /// The REST API version for the Anthropic Messages API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AnthropicThinkProviderVersionJsonConverter))]
        public global::Deepgram.Realtime.AnthropicThinkProviderVersion? Version { get; set; }

        /// <summary>
        /// Anthropic model to use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AnthropicThinkProviderModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.AnthropicThinkProviderModel Model { get; set; }

        /// <summary>
        /// Anthropic temperature (0-1)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicThinkProvider" /> class.
        /// </summary>
        /// <param name="model">
        /// Anthropic model to use
        /// </param>
        /// <param name="type"></param>
        /// <param name="version">
        /// The REST API version for the Anthropic Messages API
        /// </param>
        /// <param name="temperature">
        /// Anthropic temperature (0-1)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicThinkProvider(
            global::Deepgram.Realtime.AnthropicThinkProviderModel model,
            global::Deepgram.Realtime.AnthropicThinkProviderType type,
            global::Deepgram.Realtime.AnthropicThinkProviderVersion? version,
            double? temperature)
        {
            this.Type = type;
            this.Version = version;
            this.Model = model;
            this.Temperature = temperature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicThinkProvider" /> class.
        /// </summary>
        public AnthropicThinkProvider()
        {
        }
    }
}