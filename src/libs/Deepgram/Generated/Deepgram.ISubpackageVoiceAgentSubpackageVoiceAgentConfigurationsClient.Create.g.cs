#nullable enable

namespace Deepgram
{
    public partial interface ISubpackageVoiceAgentSubpackageVoiceAgentConfigurationsClient
    {
        /// <summary>
        /// Create an Agent Configuration<br/>
        /// Creates a new reusable agent configuration. The `config` field must be a valid JSON string representing the `agent` block of a Settings message. The returned `agent_id` can be passed in place of the full `agent` object in future Settings messages.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.CreateAgentConfigurationV1Response> CreateAsync(
            string projectId,

            global::Deepgram.CreateAgentConfigurationV1Request request,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an Agent Configuration<br/>
        /// Creates a new reusable agent configuration. The `config` field must be a valid JSON string representing the `agent` block of a Settings message. The returned `agent_id` can be passed in place of the full `agent` object in future Settings messages.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="config">
        /// A valid JSON string representing the agent block of a Settings message
        /// </param>
        /// <param name="metadata">
        /// A map of arbitrary key-value pairs for labeling or organizing the agent configuration
        /// </param>
        /// <param name="apiVersion">
        /// API version. Defaults to 1<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.CreateAgentConfigurationV1Response> CreateAsync(
            string projectId,
            string config,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            int? apiVersion = default,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}