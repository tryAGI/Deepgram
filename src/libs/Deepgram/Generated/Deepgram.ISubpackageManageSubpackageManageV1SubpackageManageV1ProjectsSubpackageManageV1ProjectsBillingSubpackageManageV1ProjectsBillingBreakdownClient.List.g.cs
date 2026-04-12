#nullable enable

namespace Deepgram
{
    public partial interface ISubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsBillingSubpackageManageV1ProjectsBillingBreakdownClient
    {
        /// <summary>
        /// Get Project Billing Breakdown<br/>
        /// Retrieves the billing summary for a specific project, with various filter options or by grouping options.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="accessor"></param>
        /// <param name="deployment">
        /// Deployment type for the requests
        /// </param>
        /// <param name="tag"></param>
        /// <param name="lineItem"></param>
        /// <param name="grouping"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.BillingBreakdownV1Response> ListAsync(
            string projectId,
            global::System.DateTime? start = default,
            global::System.DateTime? end = default,
            string? accessor = default,
            global::Deepgram.V1ProjectsProjectIdBillingBreakdownGetParametersDeployment? deployment = default,
            string? tag = default,
            string? lineItem = default,
            global::System.Collections.Generic.IList<global::Deepgram.V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems>? grouping = default,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}