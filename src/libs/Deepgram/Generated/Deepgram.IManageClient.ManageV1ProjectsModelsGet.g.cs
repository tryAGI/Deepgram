#nullable enable

namespace Deepgram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Get a Project Model<br/>
        /// Returns metadata for a specific model
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="modelId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.GetModelV1Response> ManageV1ProjectsModelsGetAsync(
            string projectId,
            string modelId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}