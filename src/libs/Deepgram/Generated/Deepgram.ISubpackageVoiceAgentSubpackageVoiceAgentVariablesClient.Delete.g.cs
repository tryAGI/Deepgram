#nullable enable

namespace Deepgram
{
    public partial interface ISubpackageVoiceAgentSubpackageVoiceAgentVariablesClient
    {
        /// <summary>
        /// Delete an Agent Variable<br/>
        /// Deletes the specified template variable
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="variableId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.DeleteAgentVariableV1Response> DeleteAsync(
            string projectId,
            string variableId,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an Agent Variable<br/>
        /// Deletes the specified template variable
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="variableId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.AutoSDKHttpResponse<global::Deepgram.DeleteAgentVariableV1Response>> DeleteAsResponseAsync(
            string projectId,
            string variableId,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}