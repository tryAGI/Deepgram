#nullable enable

namespace Deepgram
{
    public partial interface ISubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsKeysClient
    {
        /// <summary>
        /// Get a Project Key<br/>
        /// Retrieves information about a specified API key
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="keyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.GetProjectKeyV1Response> GetAsync(
            string projectId,
            string keyId,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a Project Key<br/>
        /// Retrieves information about a specified API key
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="keyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.AutoSDKHttpResponse<global::Deepgram.GetProjectKeyV1Response>> GetAsResponseAsync(
            string projectId,
            string keyId,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}