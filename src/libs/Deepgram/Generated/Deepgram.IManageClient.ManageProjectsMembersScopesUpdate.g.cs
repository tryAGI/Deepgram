#nullable enable

namespace Deepgram
{
    public partial interface IManageClient
    {

        /// <summary>
        /// Update Project Member Scopes<br/>
        /// Updates the scopes for a specific member
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="memberId"></param>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.UpdateProjectMemberScopesV1Response> ManageProjectsMembersScopesUpdateAsync(
            string projectId,
            string memberId,

            global::Deepgram.UpdateProjectMemberScopesV1Request request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Project Member Scopes<br/>
        /// Updates the scopes for a specific member
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="memberId"></param>
        /// <param name="scope">
        /// A scope to update<br/>
        /// Example: admin
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.UpdateProjectMemberScopesV1Response> ManageProjectsMembersScopesUpdateAsync(
            string projectId,
            string memberId,
            string scope,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}