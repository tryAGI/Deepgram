#nullable enable

namespace Deepgram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Create a Project Key<br/>
        /// Creates a new API key with specified settings for the project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.CreateKeyV1Response> ManageProjectsKeysCreateAsync(
            string projectId,

            global::Deepgram.CreateKeyV1Request request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Project Key<br/>
        /// Creates a new API key with specified settings for the project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="comment">
        /// Example: A comment
        /// </param>
        /// <param name="scopes">
        /// Example: [admin]
        /// </param>
        /// <param name="tags">
        /// Example: [prod, west-region]
        /// </param>
        /// <param name="expirationDate">
        /// Example: 2026-01-01T00:00:00Z
        /// </param>
        /// <param name="timeToLiveInSeconds">
        /// Example: 3600
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.CreateKeyV1Response> ManageProjectsKeysCreateAsync(
            string projectId,
            string comment,
            global::System.Collections.Generic.IList<string> scopes,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.DateTime? expirationDate = default,
            double? timeToLiveInSeconds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}