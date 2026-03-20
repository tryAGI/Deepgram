#nullable enable

namespace Deepgram
{
    public partial interface IAgentClient
    {

        /// <summary>
        /// List Agent Think Models<br/>
        /// Retrieves the available think models that can be used for AI agent processing
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.AgentThinkModelsV1Response> AgentV1SettingsThinkModelsListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}