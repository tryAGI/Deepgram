#nullable enable

namespace Deepgram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Get a Project Balance<br/>
        /// Retrieves details about the specified balance
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="balanceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.GetProjectBalanceV1Response> Get3Async(
            string projectId,
            string balanceId,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}