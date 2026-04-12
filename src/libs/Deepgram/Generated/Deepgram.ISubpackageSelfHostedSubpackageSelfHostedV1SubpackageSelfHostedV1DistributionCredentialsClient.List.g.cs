#nullable enable

namespace Deepgram
{
    public partial interface ISubpackageSelfHostedSubpackageSelfHostedV1SubpackageSelfHostedV1DistributionCredentialsClient
    {
        /// <summary>
        /// List Project Self-Hosted Distribution Credentials<br/>
        /// Lists sets of distribution credentials for the specified project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.ListProjectDistributionCredentialsV1Response> ListAsync(
            string projectId,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}