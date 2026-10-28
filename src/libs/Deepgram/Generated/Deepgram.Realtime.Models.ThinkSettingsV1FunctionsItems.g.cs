
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ThinkSettingsV1FunctionsItems
    {
        /// <summary>
        /// Function name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Function description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Function parameters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::Deepgram.Realtime.ThinkSettingsV1FunctionsItemsParameters? Parameters { get; set; }

        /// <summary>
        /// Hold this function call until the user's turn is confirmed instead of dispatching it speculatively. Set it to true for actions that cannot be undone. If the turn resumes, a deferred call is discarded before it runs. Defaults to false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defer_until_eot")]
        public bool? DeferUntilEot { get; set; }

        /// <summary>
        /// Requires `agent.think_live`. Speak one short filler line after the function is dispatched and the user's turn is confirmed, if the function response has not yet arrived. Skipped when the reasoning LLM already announced the call in the same response<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initial_agent_filler")]
        public bool? InitialAgentFiller { get; set; }

        /// <summary>
        /// Requires `agent.think_live`. Number of additional filler lines the agent may speak while this function call is outstanding. Set to 0 to disable additional filler<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_filler_max_count")]
        public int? AgentFillerMaxCount { get; set; }

        /// <summary>
        /// Requires `agent.think_live`. Silence in milliseconds, counted from when the agent last stopped speaking, before each additional filler line. Ignored when `agent_filler_max_count` is 0, which is also the only case in which a value outside the 1000 to 60000 range is accepted. Setting any filler field without `agent.think_live`, or an out-of-range interval while `agent_filler_max_count` is greater than 0, returns an `INVALID_SETTINGS` error and closes the session<br/>
        /// Default Value: 5000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_filler_interval_ms")]
        public int? AgentFillerIntervalMs { get; set; }

        /// <summary>
        /// The Function endpoint to call. if not passed, function is called client-side
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        public global::Deepgram.Realtime.ThinkSettingsV1FunctionsItemsEndpoint? Endpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkSettingsV1FunctionsItems" /> class.
        /// </summary>
        /// <param name="name">
        /// Function name
        /// </param>
        /// <param name="description">
        /// Function description
        /// </param>
        /// <param name="parameters">
        /// Function parameters
        /// </param>
        /// <param name="deferUntilEot">
        /// Hold this function call until the user's turn is confirmed instead of dispatching it speculatively. Set it to true for actions that cannot be undone. If the turn resumes, a deferred call is discarded before it runs. Defaults to false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="initialAgentFiller">
        /// Requires `agent.think_live`. Speak one short filler line after the function is dispatched and the user's turn is confirmed, if the function response has not yet arrived. Skipped when the reasoning LLM already announced the call in the same response<br/>
        /// Default Value: false
        /// </param>
        /// <param name="agentFillerMaxCount">
        /// Requires `agent.think_live`. Number of additional filler lines the agent may speak while this function call is outstanding. Set to 0 to disable additional filler<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="agentFillerIntervalMs">
        /// Requires `agent.think_live`. Silence in milliseconds, counted from when the agent last stopped speaking, before each additional filler line. Ignored when `agent_filler_max_count` is 0, which is also the only case in which a value outside the 1000 to 60000 range is accepted. Setting any filler field without `agent.think_live`, or an out-of-range interval while `agent_filler_max_count` is greater than 0, returns an `INVALID_SETTINGS` error and closes the session<br/>
        /// Default Value: 5000
        /// </param>
        /// <param name="endpoint">
        /// The Function endpoint to call. if not passed, function is called client-side
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThinkSettingsV1FunctionsItems(
            string? name,
            string? description,
            global::Deepgram.Realtime.ThinkSettingsV1FunctionsItemsParameters? parameters,
            bool? deferUntilEot,
            bool? initialAgentFiller,
            int? agentFillerMaxCount,
            int? agentFillerIntervalMs,
            global::Deepgram.Realtime.ThinkSettingsV1FunctionsItemsEndpoint? endpoint)
        {
            this.Name = name;
            this.Description = description;
            this.Parameters = parameters;
            this.DeferUntilEot = deferUntilEot;
            this.InitialAgentFiller = initialAgentFiller;
            this.AgentFillerMaxCount = agentFillerMaxCount;
            this.AgentFillerIntervalMs = agentFillerIntervalMs;
            this.Endpoint = endpoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkSettingsV1FunctionsItems" /> class.
        /// </summary>
        public ThinkSettingsV1FunctionsItems()
        {
        }

    }
}