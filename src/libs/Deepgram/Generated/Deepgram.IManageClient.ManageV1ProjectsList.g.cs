#nullable enable

namespace Deepgram
{
    public partial interface IManageClient
    {

        /// <summary>
        /// List Projects<br/>
        /// Retrieves basic information about the projects associated with the API key
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.ListProjectsV1Response> ManageV1ProjectsListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}