#nullable enable

namespace Deepgram
{
    public partial interface IManageClient
    {

        /// <summary>
        /// List Project Keys<br/>
        /// Retrieves all API keys associated with the specified project
        /// </summary>
        /// <param name="status"></param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.ListProjectKeysV1Response> ManageV1ProjectsKeysListAsync(
            string projectId,
            global::Deepgram.ManageV1ProjectsKeysListStatus? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}