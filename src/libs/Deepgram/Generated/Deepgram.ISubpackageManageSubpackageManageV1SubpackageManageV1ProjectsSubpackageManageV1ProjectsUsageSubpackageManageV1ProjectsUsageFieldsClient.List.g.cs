#nullable enable

namespace Deepgram
{
    public partial interface ISubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsUsageSubpackageManageV1ProjectsUsageFieldsClient
    {
        /// <summary>
        /// List Project Usage Fields<br/>
        /// Lists the features, models, tags, languages, and processing method used for requests in the specified project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.UsageFieldsV1Response> ListAsync(
            string projectId,
            global::System.DateTime? start = default,
            global::System.DateTime? end = default,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}