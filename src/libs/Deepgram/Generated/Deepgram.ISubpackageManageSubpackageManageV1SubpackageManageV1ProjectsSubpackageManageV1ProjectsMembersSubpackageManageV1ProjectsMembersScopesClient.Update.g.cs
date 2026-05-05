#nullable enable

namespace Deepgram
{
    public partial interface ISubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsMembersSubpackageManageV1ProjectsMembersScopesClient
    {
        /// <summary>
        /// Update Project Member Scopes<br/>
        /// Updates the scopes for a specific member
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="memberId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.UpdateProjectMemberScopesV1Response> UpdateAsync(
            string projectId,
            string memberId,

            global::Deepgram.UpdateProjectMemberScopesV1Request request,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Project Member Scopes<br/>
        /// Updates the scopes for a specific member
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="memberId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.AutoSDKHttpResponse<global::Deepgram.UpdateProjectMemberScopesV1Response>> UpdateAsResponseAsync(
            string projectId,
            string memberId,

            global::Deepgram.UpdateProjectMemberScopesV1Request request,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Project Member Scopes<br/>
        /// Updates the scopes for a specific member
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="memberId"></param>
        /// <param name="scope">
        /// A scope to update
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.UpdateProjectMemberScopesV1Response> UpdateAsync(
            string projectId,
            string memberId,
            string scope,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}