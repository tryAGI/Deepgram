#nullable enable

namespace Deepgram
{
    public partial interface ISubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsUsageSubpackageManageV1ProjectsUsageBreakdownClient
    {
        /// <summary>
        /// Get Project Usage Breakdown<br/>
        /// Retrieves the usage breakdown for a specific project, with various filter options by API feature or by groupings. Setting a feature (e.g. diarize) to true includes requests that used that feature, while false excludes requests that used it. Multiple true filters are combined with OR logic, while false filters use AND logic.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="grouping"></param>
        /// <param name="accessor"></param>
        /// <param name="alternatives"></param>
        /// <param name="callbackMethod"></param>
        /// <param name="callback"></param>
        /// <param name="channels"></param>
        /// <param name="customIntentMode"></param>
        /// <param name="customIntent"></param>
        /// <param name="customTopicMode"></param>
        /// <param name="customTopic"></param>
        /// <param name="deployment">
        /// Deployment type for the requests
        /// </param>
        /// <param name="detectEntities"></param>
        /// <param name="detectLanguage"></param>
        /// <param name="diarize"></param>
        /// <param name="dictation"></param>
        /// <param name="encoding"></param>
        /// <param name="endpoint"></param>
        /// <param name="extra"></param>
        /// <param name="fillerWords"></param>
        /// <param name="intents"></param>
        /// <param name="keyterm"></param>
        /// <param name="keywords"></param>
        /// <param name="language"></param>
        /// <param name="measurements"></param>
        /// <param name="method">
        /// Method type for the request
        /// </param>
        /// <param name="model"></param>
        /// <param name="multichannel"></param>
        /// <param name="numerals"></param>
        /// <param name="paragraphs"></param>
        /// <param name="profanityFilter"></param>
        /// <param name="punctuate"></param>
        /// <param name="redact"></param>
        /// <param name="replace"></param>
        /// <param name="sampleRate"></param>
        /// <param name="search"></param>
        /// <param name="sentiment"></param>
        /// <param name="smartFormat"></param>
        /// <param name="summarize"></param>
        /// <param name="tag"></param>
        /// <param name="topics"></param>
        /// <param name="uttSplit"></param>
        /// <param name="utterances"></param>
        /// <param name="version"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.UsageBreakdownV1Response> GetAsync(
            string projectId,
            global::System.DateTime? start = default,
            global::System.DateTime? end = default,
            global::Deepgram.V1ProjectsProjectIdUsageBreakdownGetParametersGrouping? grouping = default,
            string? accessor = default,
            bool? alternatives = default,
            bool? callbackMethod = default,
            bool? callback = default,
            bool? channels = default,
            bool? customIntentMode = default,
            bool? customIntent = default,
            bool? customTopicMode = default,
            bool? customTopic = default,
            global::Deepgram.V1ProjectsProjectIdUsageBreakdownGetParametersDeployment? deployment = default,
            bool? detectEntities = default,
            bool? detectLanguage = default,
            bool? diarize = default,
            bool? dictation = default,
            bool? encoding = default,
            global::Deepgram.V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint? endpoint = default,
            bool? extra = default,
            bool? fillerWords = default,
            bool? intents = default,
            bool? keyterm = default,
            bool? keywords = default,
            bool? language = default,
            bool? measurements = default,
            global::Deepgram.V1ProjectsProjectIdUsageBreakdownGetParametersMethod? method = default,
            string? model = default,
            bool? multichannel = default,
            bool? numerals = default,
            bool? paragraphs = default,
            bool? profanityFilter = default,
            bool? punctuate = default,
            bool? redact = default,
            bool? replace = default,
            bool? sampleRate = default,
            bool? search = default,
            bool? sentiment = default,
            bool? smartFormat = default,
            bool? summarize = default,
            string? tag = default,
            bool? topics = default,
            bool? uttSplit = default,
            bool? utterances = default,
            bool? version = default,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}