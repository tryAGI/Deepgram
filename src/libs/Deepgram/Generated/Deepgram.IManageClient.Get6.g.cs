#nullable enable

namespace Deepgram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Get a Project Request<br/>
        /// Retrieves a specific request for a specific project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.GetProjectRequestV1Response> Get6Async(
            string projectId,
            string requestId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}