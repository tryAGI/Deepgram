#nullable enable

namespace Deepgram
{
    public partial interface ISubpackageSelfHostedSubpackageSelfHostedV1SubpackageSelfHostedV1DistributionCredentialsClient
    {
        /// <summary>
        /// Delete a Project Self-Hosted Distribution Credential<br/>
        /// Deletes a set of distribution credentials for the specified project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="distributionCredentialsId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.GetProjectDistributionCredentialsV1Response> DeleteAsync(
            string projectId,
            string distributionCredentialsId,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a Project Self-Hosted Distribution Credential<br/>
        /// Deletes a set of distribution credentials for the specified project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="distributionCredentialsId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.AutoSDKHttpResponse<global::Deepgram.GetProjectDistributionCredentialsV1Response>> DeleteAsResponseAsync(
            string projectId,
            string distributionCredentialsId,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}