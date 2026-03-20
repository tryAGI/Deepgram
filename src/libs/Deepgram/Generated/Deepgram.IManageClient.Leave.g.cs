#nullable enable

namespace Deepgram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Leave a Project<br/>
        /// Removes the authenticated account from the specific project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.LeaveProjectV1Response> LeaveAsync(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}