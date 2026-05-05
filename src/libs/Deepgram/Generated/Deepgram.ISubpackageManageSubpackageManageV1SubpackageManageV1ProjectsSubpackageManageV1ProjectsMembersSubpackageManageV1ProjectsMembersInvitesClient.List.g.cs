#nullable enable

namespace Deepgram
{
    public partial interface ISubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsMembersSubpackageManageV1ProjectsMembersInvitesClient
    {
        /// <summary>
        /// List Project Invites<br/>
        /// Generates a list of invites for a specific project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.ListProjectInvitesV1Response> ListAsync(
            string projectId,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Project Invites<br/>
        /// Generates a list of invites for a specific project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.AutoSDKHttpResponse<global::Deepgram.ListProjectInvitesV1Response>> ListAsResponseAsync(
            string projectId,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}