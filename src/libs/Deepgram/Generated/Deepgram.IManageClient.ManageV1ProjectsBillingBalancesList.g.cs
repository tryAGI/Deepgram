#nullable enable

namespace Deepgram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Get Project Balances<br/>
        /// Generates a list of outstanding balances for the specified project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.ListProjectBalancesV1Response> ManageV1ProjectsBillingBalancesListAsync(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}