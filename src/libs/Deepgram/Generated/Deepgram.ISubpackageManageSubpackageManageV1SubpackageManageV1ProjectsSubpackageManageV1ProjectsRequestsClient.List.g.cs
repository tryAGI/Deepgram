#nullable enable

namespace Deepgram
{
    public partial interface ISubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsRequestsClient
    {
        /// <summary>
        /// List Project Requests<br/>
        /// Generates a list of requests for a specific project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="page"></param>
        /// <param name="accessor"></param>
        /// <param name="requestId"></param>
        /// <param name="deployment">
        /// Deployment type for the requests
        /// </param>
        /// <param name="endpoint"></param>
        /// <param name="method">
        /// Method type for the request
        /// </param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.ListProjectRequestsV1Response> ListAsync(
            string projectId,
            global::System.DateTime? start = default,
            global::System.DateTime? end = default,
            double? limit = default,
            double? page = default,
            string? accessor = default,
            string? requestId = default,
            global::Deepgram.V1ProjectsProjectIdRequestsGetParametersDeployment? deployment = default,
            global::Deepgram.V1ProjectsProjectIdRequestsGetParametersEndpoint? endpoint = default,
            global::Deepgram.V1ProjectsProjectIdRequestsGetParametersMethod? method = default,
            global::Deepgram.V1ProjectsProjectIdRequestsGetParametersStatus? status = default,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Project Requests<br/>
        /// Generates a list of requests for a specific project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="page"></param>
        /// <param name="accessor"></param>
        /// <param name="requestId"></param>
        /// <param name="deployment">
        /// Deployment type for the requests
        /// </param>
        /// <param name="endpoint"></param>
        /// <param name="method">
        /// Method type for the request
        /// </param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.AutoSDKHttpResponse<global::Deepgram.ListProjectRequestsV1Response>> ListAsResponseAsync(
            string projectId,
            global::System.DateTime? start = default,
            global::System.DateTime? end = default,
            double? limit = default,
            double? page = default,
            string? accessor = default,
            string? requestId = default,
            global::Deepgram.V1ProjectsProjectIdRequestsGetParametersDeployment? deployment = default,
            global::Deepgram.V1ProjectsProjectIdRequestsGetParametersEndpoint? endpoint = default,
            global::Deepgram.V1ProjectsProjectIdRequestsGetParametersMethod? method = default,
            global::Deepgram.V1ProjectsProjectIdRequestsGetParametersStatus? status = default,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}