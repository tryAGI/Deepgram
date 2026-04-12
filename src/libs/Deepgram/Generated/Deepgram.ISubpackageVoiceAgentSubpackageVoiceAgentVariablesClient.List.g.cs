#nullable enable

namespace Deepgram
{
    public partial interface ISubpackageVoiceAgentSubpackageVoiceAgentVariablesClient
    {
        /// <summary>
        /// List Agent Variables<br/>
        /// Returns all template variables for the specified project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.ListAgentVariablesV1Response> ListAsync(
            string projectId,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}