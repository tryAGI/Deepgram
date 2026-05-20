
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThinkSettingsV1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ThinkSettingsV1ProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.ThinkSettingsV1Provider Provider { get; set; }

        /// <summary>
        /// Optional for non-Deepgram LLM providers. When present, must include url field and headers object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        public global::Deepgram.Realtime.ThinkSettingsV1Endpoint? Endpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functions")]
        public global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1FunctionsItems>? Functions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Specifies the number of characters retained in context between user messages, agent responses, and function calls. This setting is only configurable when a custom think endpoint is used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_length")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ThinkSettingsV1ContextLengthJsonConverter))]
        public global::Deepgram.Realtime.ThinkSettingsV1ContextLength? ContextLength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkSettingsV1" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="endpoint">
        /// Optional for non-Deepgram LLM providers. When present, must include url field and headers object
        /// </param>
        /// <param name="functions"></param>
        /// <param name="prompt"></param>
        /// <param name="contextLength">
        /// Specifies the number of characters retained in context between user messages, agent responses, and function calls. This setting is only configurable when a custom think endpoint is used
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThinkSettingsV1(
            global::Deepgram.Realtime.ThinkSettingsV1Provider provider,
            global::Deepgram.Realtime.ThinkSettingsV1Endpoint? endpoint,
            global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1FunctionsItems>? functions,
            string? prompt,
            global::Deepgram.Realtime.ThinkSettingsV1ContextLength? contextLength)
        {
            this.Provider = provider;
            this.Endpoint = endpoint;
            this.Functions = functions;
            this.Prompt = prompt;
            this.ContextLength = contextLength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkSettingsV1" /> class.
        /// </summary>
        public ThinkSettingsV1()
        {
        }

    }
}