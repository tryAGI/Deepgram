#nullable enable

namespace Deepgram
{
    public partial interface IManageClient
    {

        /// <summary>
        /// Get a Project Key<br/>
        /// Retrieves information about a specified API key
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="keyId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.GetProjectKeyV1Response> ManageV1ProjectsKeysGetAsync(
            string projectId,
            string keyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}