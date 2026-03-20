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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.ListProjectPurchasesV1Response> ManageV1ProjectsBillingPurchasesListAsync(
            string projectId,
            double? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}