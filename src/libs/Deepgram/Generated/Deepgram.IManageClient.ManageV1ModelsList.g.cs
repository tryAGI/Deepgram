#nullable enable

namespace Deepgram
{
    public partial interface IManageClient
    {

        /// <summary>
        /// List Models<br/>
        /// Returns metadata on all the latest public models. To retrieve custom models, use Get Project Models.
        /// </summary>
        /// <param name="includeOutdated"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.ListModelsV1Response> ManageV1ModelsListAsync(
            bool? includeOutdated = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}