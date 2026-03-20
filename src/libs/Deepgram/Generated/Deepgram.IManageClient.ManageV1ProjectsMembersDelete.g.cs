#nullable enable

namespace Deepgram
{
    public partial interface IManageClient
    {

        /// <summary>
        /// Delete a Project Member<br/>
        /// Removes a member from the project using their unique member ID
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="memberId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.DeleteProjectMemberV1Response> ManageV1ProjectsMembersDeleteAsync(
            string projectId,
            string memberId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}