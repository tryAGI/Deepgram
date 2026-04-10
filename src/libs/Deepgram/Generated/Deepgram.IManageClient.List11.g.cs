#nullable enable

namespace Deepgram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// List Project Purchases<br/>
        /// Returns the original purchased amount on an order transaction
        /// </summary>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.ListProjectPurchasesV1Response> List11Async(
            string projectId,
            double? limit = default,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}