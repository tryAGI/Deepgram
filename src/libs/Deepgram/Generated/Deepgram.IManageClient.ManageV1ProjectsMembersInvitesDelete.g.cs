#nullable enable

namespace Deepgram
{
    public partial interface IManageClient
    {

        /// <summary>
        /// Delete a Project Invite<br/>
        /// Deletes an invite for a specific project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="email"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.DeleteProjectInviteV1Response> ManageV1ProjectsMembersInvitesDeleteAsync(
            string projectId,
            string email,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}