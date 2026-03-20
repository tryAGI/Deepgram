#nullable enable

namespace Deepgram
{
    public partial interface ISelfHostedClient
    {
        /// <summary>
        /// List Project Self-Hosted Distribution Credentials<br/>
        /// Lists sets of distribution credentials for the specified project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.ListProjectDistributionCredentialsV1Response> SelfHostedV1DistributionCredentialsListAsync(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}