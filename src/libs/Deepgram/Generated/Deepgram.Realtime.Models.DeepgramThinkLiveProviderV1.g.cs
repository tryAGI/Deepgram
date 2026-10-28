
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Deepgram's Think Live model, which runs alongside your reasoning LLM to handle backchanneling, presence checks, and frustration detection. Only the Deepgram provider is supported.
    /// </summary>
    public sealed partial class DeepgramThinkLiveProviderV1
    {
        /// <summary>
        /// Provider type for the Think Live model. Must be `deepgram`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.DeepgramThinkLiveProviderV1TypeJsonConverter))]
        public global::Deepgram.Realtime.DeepgramThinkLiveProviderV1Type Type { get; set; }

        /// <summary>
        /// Version of the Deepgram Think Live model. Must be `v1`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.DeepgramThinkLiveProviderV1VersionJsonConverter))]
        public global::Deepgram.Realtime.DeepgramThinkLiveProviderV1Version Version { get; set; }

        /// <summary>
        /// Probability of the agent producing backchannel responses (such as "mhmm") while the user is speaking. Higher values produce more backchanneling. Set to 0 to disable agent backchannels<br/>
        /// Default Value: 0.73F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_backchannel_sensitivity")]
        public double? AgentBackchannelSensitivity { get; set; }

        /// <summary>
        /// Maximum number of times the agent prompts the user after extended silence. Once reached, the agent stays silent. Set to 0 to disable presence checks<br/>
        /// Default Value: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_check_max_count")]
        public int? PresenceCheckMaxCount { get; set; }

        /// <summary>
        /// Time in milliseconds the agent waits between presence-check prompts. The first prompt is floored at 3000, so values below that behave as 3000. Ignored when `presence_check_max_count` is 0<br/>
        /// Default Value: 4500
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_check_interval_ms")]
        public int? PresenceCheckIntervalMs { get; set; }

        /// <summary>
        /// Number of `FrustrationDetected` events sent before `escalated` becomes true. Set to 0 to stop `FrustrationDetected` events from being sent. Omit it to use the server default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frustration_max_count")]
        public int? FrustrationMaxCount { get; set; }

        /// <summary>
        /// Terms the Think Live model will not say. Pass a multi-word phrase as a single array element. Applies to the Think Live model only, not to your reasoning LLM<br/>
        /// Default Value: [human, transfer]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restricted_terms")]
        public global::System.Collections.Generic.IList<string>? RestrictedTerms { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeepgramThinkLiveProviderV1" /> class.
        /// </summary>
        /// <param name="type">
        /// Provider type for the Think Live model. Must be `deepgram`
        /// </param>
        /// <param name="version">
        /// Version of the Deepgram Think Live model. Must be `v1`
        /// </param>
        /// <param name="agentBackchannelSensitivity">
        /// Probability of the agent producing backchannel responses (such as "mhmm") while the user is speaking. Higher values produce more backchanneling. Set to 0 to disable agent backchannels<br/>
        /// Default Value: 0.73F
        /// </param>
        /// <param name="presenceCheckMaxCount">
        /// Maximum number of times the agent prompts the user after extended silence. Once reached, the agent stays silent. Set to 0 to disable presence checks<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="presenceCheckIntervalMs">
        /// Time in milliseconds the agent waits between presence-check prompts. The first prompt is floored at 3000, so values below that behave as 3000. Ignored when `presence_check_max_count` is 0<br/>
        /// Default Value: 4500
        /// </param>
        /// <param name="frustrationMaxCount">
        /// Number of `FrustrationDetected` events sent before `escalated` becomes true. Set to 0 to stop `FrustrationDetected` events from being sent. Omit it to use the server default
        /// </param>
        /// <param name="restrictedTerms">
        /// Terms the Think Live model will not say. Pass a multi-word phrase as a single array element. Applies to the Think Live model only, not to your reasoning LLM<br/>
        /// Default Value: [human, transfer]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeepgramThinkLiveProviderV1(
            global::Deepgram.Realtime.DeepgramThinkLiveProviderV1Type type,
            global::Deepgram.Realtime.DeepgramThinkLiveProviderV1Version version,
            double? agentBackchannelSensitivity,
            int? presenceCheckMaxCount,
            int? presenceCheckIntervalMs,
            int? frustrationMaxCount,
            global::System.Collections.Generic.IList<string>? restrictedTerms)
        {
            this.Type = type;
            this.Version = version;
            this.AgentBackchannelSensitivity = agentBackchannelSensitivity;
            this.PresenceCheckMaxCount = presenceCheckMaxCount;
            this.PresenceCheckIntervalMs = presenceCheckIntervalMs;
            this.FrustrationMaxCount = frustrationMaxCount;
            this.RestrictedTerms = restrictedTerms;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeepgramThinkLiveProviderV1" /> class.
        /// </summary>
        public DeepgramThinkLiveProviderV1()
        {
        }

    }
}