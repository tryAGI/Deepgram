#nullable enable

namespace Deepgram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Update a Project<br/>
        /// Updates the name or other properties of an existing project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.UpdateProjectV1Response> UpdateAsync(
            string projectId,

            global::Deepgram.UpdateProjectV1Request request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Project<br/>
        /// Updates the name or other properties of an existing project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="name">
        /// The name of the project
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.UpdateProjectV1Response> UpdateAsync(
            string projectId,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}