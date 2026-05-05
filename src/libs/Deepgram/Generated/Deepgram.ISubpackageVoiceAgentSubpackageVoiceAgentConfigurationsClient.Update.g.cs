#nullable enable

namespace Deepgram
{
    public partial interface ISubpackageVoiceAgentSubpackageVoiceAgentConfigurationsClient
    {
        /// <summary>
        /// Update Agent Metadata<br/>
        /// Updates the metadata associated with an agent configuration. The config itself is immutable—to change the configuration, delete the existing agent and create a new one.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.AgentConfigurationV1> UpdateAsync(
            string projectId,
            string agentId,

            global::Deepgram.UpdateAgentMetadataV1Request request,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent Metadata<br/>
        /// Updates the metadata associated with an agent configuration. The config itself is immutable—to change the configuration, delete the existing agent and create a new one.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.AutoSDKHttpResponse<global::Deepgram.AgentConfigurationV1>> UpdateAsResponseAsync(
            string projectId,
            string agentId,

            global::Deepgram.UpdateAgentMetadataV1Request request,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent Metadata<br/>
        /// Updates the metadata associated with an agent configuration. The config itself is immutable—to change the configuration, delete the existing agent and create a new one.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="agentId"></param>
        /// <param name="metadata">
        /// A map of string key-value pairs to associate with this agent configuration
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.AgentConfigurationV1> UpdateAsync(
            string projectId,
            string agentId,
            global::System.Collections.Generic.Dictionary<string, string> metadata,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}