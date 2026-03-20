#nullable enable

namespace Deepgram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Delete a Project<br/>
        /// Deletes the specified project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.DeleteProjectV1Response> DeleteAsync(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}