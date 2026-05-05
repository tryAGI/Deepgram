#nullable enable

namespace Deepgram
{
    public partial interface ISubpackageVoiceAgentSubpackageVoiceAgentConfigurationsClient
    {
        /// <summary>
        /// Delete an Agent Configuration<br/>
        /// Deletes the specified agent configuration. Deleting an agent configuration can cause a production outage if your service references this agent UUID. Migrate all active sessions to a new configuration before deleting.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="agentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.DeleteAgentConfigurationV1Response> DeleteAsync(
            string projectId,
            string agentId,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an Agent Configuration<br/>
        /// Deletes the specified agent configuration. Deleting an agent configuration can cause a production outage if your service references this agent UUID. Migrate all active sessions to a new configuration before deleting.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="agentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.AutoSDKHttpResponse<global::Deepgram.DeleteAgentConfigurationV1Response>> DeleteAsResponseAsync(
            string projectId,
            string agentId,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}