#nullable enable

namespace Deepgram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Get a Project<br/>
        /// Retrieves information about the specified project
        /// </summary>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="page"></param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.GetProjectV1Response> ManageV1ProjectsGetAsync(
            string projectId,
            double? limit = default,
            double? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}