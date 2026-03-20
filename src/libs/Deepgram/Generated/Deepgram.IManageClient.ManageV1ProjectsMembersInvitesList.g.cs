#nullable enable

namespace Deepgram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// List Project Invites<br/>
        /// Generates a list of invites for a specific project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.ListProjectInvitesV1Response> ManageV1ProjectsMembersInvitesListAsync(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}