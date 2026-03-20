#nullable enable

namespace Deepgram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// List Project Requests<br/>
        /// Generates a list of requests for a specific project
        /// </summary>
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
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.ListProjectRequestsV1Response> List12Async(
            string projectId,
            global::System.DateTime? start = default,
            global::System.DateTime? end = default,
            double? limit = default,
            double? page = default,
            string? accessor = default,
            string? requestId = default,
            global::Deepgram.ManageV1ProjectsRequestsListDeployment? deployment = default,
            global::Deepgram.ManageV1ProjectsRequestsListEndpoint? endpoint = default,
            global::Deepgram.ManageV1ProjectsRequestsListMethod? method = default,
            global::Deepgram.ManageV1ProjectsRequestsListStatus? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}