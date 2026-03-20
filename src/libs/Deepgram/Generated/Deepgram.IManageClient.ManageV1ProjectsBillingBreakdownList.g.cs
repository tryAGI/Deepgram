#nullable enable

namespace Deepgram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Get Project Billing Breakdown<br/>
        /// Retrieves the billing summary for a specific project, with various filter options or by grouping options.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="accessor"></param>
        /// <param name="deployment">
        /// Deployment type for the requests
        /// </param>
        /// <param name="tag"></param>
        /// <param name="lineItem"></param>
        /// <param name="grouping"></param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.BillingBreakdownV1Response> ManageV1ProjectsBillingBreakdownListAsync(
            string projectId,
            global::System.DateTime? start = default,
            global::System.DateTime? end = default,
            string? accessor = default,
            global::Deepgram.ManageV1ProjectsBillingBreakdownListDeployment? deployment = default,
            string? tag = default,
            string? lineItem = default,
            global::System.Collections.Generic.IList<global::Deepgram.ManageV1ProjectsBillingBreakdownListGroupingItem>? grouping = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}