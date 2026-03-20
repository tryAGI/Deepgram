#nullable enable

namespace Deepgram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// List Project Models<br/>
        /// Returns metadata on all the latest models that a specific project has access to, including non-public models
        /// </summary>
        /// <param name="includeOutdated"></param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.ListModelsV1Response> ManageV1ProjectsModelsListAsync(
            string projectId,
            bool? includeOutdated = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}