#nullable enable

namespace Deepgram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// List Project Member Scopes<br/>
        /// Retrieves a list of scopes for a specific member
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="memberId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.ListProjectMemberScopesV1Response> List9Async(
            string projectId,
            string memberId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}