#nullable enable

namespace Deepgram
{
    public partial interface ISubpackageManageSubpackageManageV1SubpackageManageV1ProjectsClient
    {
        /// <summary>
        /// Get a Project<br/>
        /// Retrieves information about the specified project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="page"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.GetProjectV1Response> GetAsync(
            string projectId,
            double? limit = default,
            double? page = default,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a Project<br/>
        /// Retrieves information about the specified project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="page"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.AutoSDKHttpResponse<global::Deepgram.GetProjectV1Response>> GetAsResponseAsync(
            string projectId,
            double? limit = default,
            double? page = default,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}