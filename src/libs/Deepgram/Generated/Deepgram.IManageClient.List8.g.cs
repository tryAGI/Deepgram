#nullable enable

namespace Deepgram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// List Project Members<br/>
        /// Retrieves a list of members for a given project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.ListProjectMembersV1Response> List8Async(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}