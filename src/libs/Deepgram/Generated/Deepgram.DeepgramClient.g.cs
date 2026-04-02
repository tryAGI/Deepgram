
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// APIs for speech-to-text transcription, text-to-speech synthesis, language understanding, and account management.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class DeepgramClient : global::Deepgram.IDeepgramClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.deepgram.com";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Deepgram.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::Deepgram.JsonConverters.AgentThinkModelsV1ResponseModelVariant1IdJsonConverter(),
                    new global::Deepgram.JsonConverters.AgentThinkModelsV1ResponseModelVariant1IdNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.AgentThinkModelsV1ResponseModelVariant2IdJsonConverter(),
                    new global::Deepgram.JsonConverters.AgentThinkModelsV1ResponseModelVariant2IdNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.AgentThinkModelsV1ResponseModelVariant3IdJsonConverter(),
                    new global::Deepgram.JsonConverters.AgentThinkModelsV1ResponseModelVariant3IdNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.AgentThinkModelsV1ResponseModelVariant4IdJsonConverter(),
                    new global::Deepgram.JsonConverters.AgentThinkModelsV1ResponseModelVariant4IdNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.ListBillingFieldsV1ResponseDeploymentJsonConverter(),
                    new global::Deepgram.JsonConverters.ListBillingFieldsV1ResponseDeploymentNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.ListenV1MediaTranscribeCallbackMethodJsonConverter(),
                    new global::Deepgram.JsonConverters.ListenV1MediaTranscribeCallbackMethodNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.ListenV1MediaTranscribeSummarize2JsonConverter(),
                    new global::Deepgram.JsonConverters.ListenV1MediaTranscribeSummarize2NullableJsonConverter(),
                    new global::Deepgram.JsonConverters.ListenV1MediaTranscribeCustomTopicModeJsonConverter(),
                    new global::Deepgram.JsonConverters.ListenV1MediaTranscribeCustomTopicModeNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.ListenV1MediaTranscribeCustomIntentModeJsonConverter(),
                    new global::Deepgram.JsonConverters.ListenV1MediaTranscribeCustomIntentModeNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.ListenV1MediaTranscribeEncodingJsonConverter(),
                    new global::Deepgram.JsonConverters.ListenV1MediaTranscribeEncodingNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.ListenV1MediaTranscribeModel2JsonConverter(),
                    new global::Deepgram.JsonConverters.ListenV1MediaTranscribeModel2NullableJsonConverter(),
                    new global::Deepgram.JsonConverters.ListenV1MediaTranscribeRedactVariant2ItemJsonConverter(),
                    new global::Deepgram.JsonConverters.ListenV1MediaTranscribeRedactVariant2ItemNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.ListenV1MediaTranscribeVersion2JsonConverter(),
                    new global::Deepgram.JsonConverters.ListenV1MediaTranscribeVersion2NullableJsonConverter(),
                    new global::Deepgram.JsonConverters.ManageV1ProjectsBillingBreakdownListDeploymentJsonConverter(),
                    new global::Deepgram.JsonConverters.ManageV1ProjectsBillingBreakdownListDeploymentNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.ManageV1ProjectsBillingBreakdownListGroupingItemJsonConverter(),
                    new global::Deepgram.JsonConverters.ManageV1ProjectsBillingBreakdownListGroupingItemNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.ManageV1ProjectsKeysListStatusJsonConverter(),
                    new global::Deepgram.JsonConverters.ManageV1ProjectsKeysListStatusNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.ManageV1ProjectsRequestsListDeploymentJsonConverter(),
                    new global::Deepgram.JsonConverters.ManageV1ProjectsRequestsListDeploymentNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.ManageV1ProjectsRequestsListEndpointJsonConverter(),
                    new global::Deepgram.JsonConverters.ManageV1ProjectsRequestsListEndpointNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.ManageV1ProjectsRequestsListMethodJsonConverter(),
                    new global::Deepgram.JsonConverters.ManageV1ProjectsRequestsListMethodNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.ManageV1ProjectsRequestsListStatusJsonConverter(),
                    new global::Deepgram.JsonConverters.ManageV1ProjectsRequestsListStatusNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.SelfHostedV1DistributionCredentialsCreateScopeJsonConverter(),
                    new global::Deepgram.JsonConverters.SelfHostedV1DistributionCredentialsCreateScopeNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.SelfHostedV1DistributionCredentialsCreateProviderJsonConverter(),
                    new global::Deepgram.JsonConverters.SelfHostedV1DistributionCredentialsCreateProviderNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.ManageV1ProjectsUsageGetDeploymentJsonConverter(),
                    new global::Deepgram.JsonConverters.ManageV1ProjectsUsageGetDeploymentNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.ManageV1ProjectsUsageGetEndpointJsonConverter(),
                    new global::Deepgram.JsonConverters.ManageV1ProjectsUsageGetEndpointNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.ManageV1ProjectsUsageGetMethodJsonConverter(),
                    new global::Deepgram.JsonConverters.ManageV1ProjectsUsageGetMethodNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.ManageV1ProjectsUsageBreakdownGetGroupingJsonConverter(),
                    new global::Deepgram.JsonConverters.ManageV1ProjectsUsageBreakdownGetGroupingNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.ManageV1ProjectsUsageBreakdownGetDeploymentJsonConverter(),
                    new global::Deepgram.JsonConverters.ManageV1ProjectsUsageBreakdownGetDeploymentNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.ManageV1ProjectsUsageBreakdownGetEndpointJsonConverter(),
                    new global::Deepgram.JsonConverters.ManageV1ProjectsUsageBreakdownGetEndpointNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.ManageV1ProjectsUsageBreakdownGetMethodJsonConverter(),
                    new global::Deepgram.JsonConverters.ManageV1ProjectsUsageBreakdownGetMethodNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.ReadV1TextAnalyzeCallbackMethodJsonConverter(),
                    new global::Deepgram.JsonConverters.ReadV1TextAnalyzeCallbackMethodNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.ReadV1TextAnalyzeSummarize2JsonConverter(),
                    new global::Deepgram.JsonConverters.ReadV1TextAnalyzeSummarize2NullableJsonConverter(),
                    new global::Deepgram.JsonConverters.ReadV1TextAnalyzeCustomTopicModeJsonConverter(),
                    new global::Deepgram.JsonConverters.ReadV1TextAnalyzeCustomTopicModeNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.ReadV1TextAnalyzeCustomIntentModeJsonConverter(),
                    new global::Deepgram.JsonConverters.ReadV1TextAnalyzeCustomIntentModeNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.SpeakV1AudioGenerateCallbackMethodJsonConverter(),
                    new global::Deepgram.JsonConverters.SpeakV1AudioGenerateCallbackMethodNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.SpeakV1AudioGenerateContainerNoneJsonConverter(),
                    new global::Deepgram.JsonConverters.SpeakV1AudioGenerateContainerNoneNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.SpeakV1AudioGenerateContainerLinear16JsonConverter(),
                    new global::Deepgram.JsonConverters.SpeakV1AudioGenerateContainerLinear16NullableJsonConverter(),
                    new global::Deepgram.JsonConverters.SpeakV1AudioGenerateContainerMulawJsonConverter(),
                    new global::Deepgram.JsonConverters.SpeakV1AudioGenerateContainerMulawNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.SpeakV1AudioGenerateContainerAlawJsonConverter(),
                    new global::Deepgram.JsonConverters.SpeakV1AudioGenerateContainerAlawNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.SpeakV1AudioGenerateContainerOpusJsonConverter(),
                    new global::Deepgram.JsonConverters.SpeakV1AudioGenerateContainerOpusNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.SpeakV1AudioGenerateEncodingLinear16JsonConverter(),
                    new global::Deepgram.JsonConverters.SpeakV1AudioGenerateEncodingLinear16NullableJsonConverter(),
                    new global::Deepgram.JsonConverters.SpeakV1AudioGenerateEncodingFlacJsonConverter(),
                    new global::Deepgram.JsonConverters.SpeakV1AudioGenerateEncodingFlacNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.SpeakV1AudioGenerateEncodingMulawJsonConverter(),
                    new global::Deepgram.JsonConverters.SpeakV1AudioGenerateEncodingMulawNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.SpeakV1AudioGenerateEncodingAlawJsonConverter(),
                    new global::Deepgram.JsonConverters.SpeakV1AudioGenerateEncodingAlawNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.SpeakV1AudioGenerateEncodingMp3JsonConverter(),
                    new global::Deepgram.JsonConverters.SpeakV1AudioGenerateEncodingMp3NullableJsonConverter(),
                    new global::Deepgram.JsonConverters.SpeakV1AudioGenerateEncodingOpusJsonConverter(),
                    new global::Deepgram.JsonConverters.SpeakV1AudioGenerateEncodingOpusNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.SpeakV1AudioGenerateEncodingAacJsonConverter(),
                    new global::Deepgram.JsonConverters.SpeakV1AudioGenerateEncodingAacNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.SpeakV1AudioGenerateModelJsonConverter(),
                    new global::Deepgram.JsonConverters.SpeakV1AudioGenerateModelNullableJsonConverter(),
                    new global::Deepgram.JsonConverters.ErrorResponseJsonConverter(),
                    new global::Deepgram.JsonConverters.GetModelV1ResponseJsonConverter(),
                    new global::Deepgram.JsonConverters.ReadV1RequestJsonConverter(),
                    new global::Deepgram.JsonConverters.OneOfJsonConverter<global::Deepgram.AgentThinkModelsV1ResponseModelVariant1, global::Deepgram.AgentThinkModelsV1ResponseModelVariant2, global::Deepgram.AgentThinkModelsV1ResponseModelVariant3, global::Deepgram.AgentThinkModelsV1ResponseModelVariant4, global::Deepgram.AgentThinkModelsV1ResponseModelVariant5>(),
                    new global::Deepgram.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Deepgram.JsonConverters.OneOfJsonConverter<global::Deepgram.ListenV1MediaTranscribeSummarize2?, bool?>(),
                    new global::Deepgram.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Deepgram.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Deepgram.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Deepgram.JsonConverters.OneOfJsonConverter<bool?, global::System.Collections.Generic.IList<string>>(),
                    new global::Deepgram.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Deepgram.JsonConverters.OneOfJsonConverter<global::Deepgram.ListenV1MediaTranscribeModel2?, string>(),
                    new global::Deepgram.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Deepgram.ListenV1MediaTranscribeRedactVariant2Item>>(),
                    new global::Deepgram.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Deepgram.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Deepgram.JsonConverters.OneOfJsonConverter<global::Deepgram.ListenV1MediaTranscribeVersion2?, string>(),
                    new global::Deepgram.JsonConverters.OneOfJsonConverter<global::Deepgram.ReadV1TextAnalyzeSummarize2?, bool?>(),
                    new global::Deepgram.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Deepgram.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Deepgram.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Deepgram.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Deepgram.JsonConverters.OneOfJsonConverter<global::Deepgram.SpeakV1AudioGenerateContainerNone?, global::Deepgram.SpeakV1AudioGenerateContainerLinear16?, global::Deepgram.SpeakV1AudioGenerateContainerMulaw?, global::Deepgram.SpeakV1AudioGenerateContainerAlaw?, global::Deepgram.SpeakV1AudioGenerateContainerOpus?>(),
                    new global::Deepgram.JsonConverters.OneOfJsonConverter<global::Deepgram.SpeakV1AudioGenerateEncodingLinear16?, global::Deepgram.SpeakV1AudioGenerateEncodingFlac?, global::Deepgram.SpeakV1AudioGenerateEncodingMulaw?, global::Deepgram.SpeakV1AudioGenerateEncodingAlaw?, global::Deepgram.SpeakV1AudioGenerateEncodingMp3?, global::Deepgram.SpeakV1AudioGenerateEncodingOpus?, global::Deepgram.SpeakV1AudioGenerateEncodingAac?>(),
                    new global::Deepgram.JsonConverters.OneOfJsonConverter<global::Deepgram.ListenV1Response, global::Deepgram.ListenV1AcceptedResponse>(),
                    new global::Deepgram.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// AI agent operations
        /// </summary>
        public AgentClient Agent => new AgentClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Authentication operations
        /// </summary>
        public AuthClient Auth => new AuthClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Speech-to-text transcription
        /// </summary>
        public ListenClient Listen => new ListenClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Project and account management
        /// </summary>
        public ManageClient Manage => new ManageClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Text analysis
        /// </summary>
        public ReadClient Read => new ReadClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// On-premise deployments
        /// </summary>
        public SelfHostedClient SelfHosted => new SelfHostedClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Text-to-speech generation
        /// </summary>
        public SpeakClient Speak => new SpeakClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the DeepgramClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public DeepgramClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Deepgram.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Deepgram.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}