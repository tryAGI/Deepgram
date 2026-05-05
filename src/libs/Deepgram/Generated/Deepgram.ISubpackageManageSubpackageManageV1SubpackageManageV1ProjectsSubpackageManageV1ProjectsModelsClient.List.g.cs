#nullable enable

namespace Deepgram
{
    public partial interface ISubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsModelsClient
    {
        /// <summary>
        /// List Project Models<br/>
        /// Returns metadata on all the latest models that a specific project has access to, including non-public models
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="includeOutdated"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.ListModelsV1Response> ListAsync(
            string projectId,
            bool? includeOutdated = default,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Project Models<br/>
        /// Returns metadata on all the latest models that a specific project has access to, including non-public models
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="includeOutdated"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.AutoSDKHttpResponse<global::Deepgram.ListModelsV1Response>> ListAsResponseAsync(
            string projectId,
            bool? includeOutdated = default,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}