#nullable enable

namespace Deepgram
{
    public partial interface ISubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsModelsClient
    {
        /// <summary>
        /// Get a Project Model<br/>
        /// Returns metadata for a specific model
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="modelId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.GetModelV1Response> GetAsync(
            string projectId,
            string modelId,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a Project Model<br/>
        /// Returns metadata for a specific model
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="modelId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.AutoSDKHttpResponse<global::Deepgram.GetModelV1Response>> GetAsResponseAsync(
            string projectId,
            string modelId,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}