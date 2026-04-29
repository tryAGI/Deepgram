
#nullable enable

namespace Deepgram
{
    public partial class SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsUsageClient
    {

        private static readonly global::Deepgram.AutoSDKServer[] s_GetServers = new global::Deepgram.AutoSDKServer[]
        {            new global::Deepgram.AutoSDKServer(
                id: "https-api-deepgram-com",
                name: "api.deepgram.com",
                url: "https://api.deepgram.com/",
                description: ""),
            new global::Deepgram.AutoSDKServer(
                id: "https-agent-deepgram-com",
                name: "agent.deepgram.com",
                url: "https://agent.deepgram.com/",
                description: ""),
        };


        private static readonly global::Deepgram.EndPointSecurityRequirement s_GetSecurityRequirement0 =
            new global::Deepgram.EndPointSecurityRequirement
            {
                Authorizations = new global::Deepgram.EndPointAuthorizationRequirement[]
                {                    new global::Deepgram.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Deepgram.EndPointSecurityRequirement[] s_GetSecurityRequirements =
            new global::Deepgram.EndPointSecurityRequirement[]
            {                s_GetSecurityRequirement0,
            };
        partial void PrepareGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string projectId,
            ref global::System.DateTime? start,
            ref global::System.DateTime? end,
            ref string? accessor,
            ref bool? alternatives,
            ref bool? callbackMethod,
            ref bool? callback,
            ref bool? channels,
            ref bool? customIntentMode,
            ref bool? customIntent,
            ref bool? customTopicMode,
            ref bool? customTopic,
            ref global::Deepgram.V1ProjectsProjectIdUsageGetParametersDeployment? deployment,
            ref bool? detectEntities,
            ref bool? detectLanguage,
            ref bool? diarize,
            ref bool? dictation,
            ref bool? encoding,
            ref global::Deepgram.V1ProjectsProjectIdUsageGetParametersEndpoint? endpoint,
            ref bool? extra,
            ref bool? fillerWords,
            ref bool? intents,
            ref bool? keyterm,
            ref bool? keywords,
            ref bool? language,
            ref bool? measurements,
            ref global::Deepgram.V1ProjectsProjectIdUsageGetParametersMethod? method,
            ref string? model,
            ref bool? multichannel,
            ref bool? numerals,
            ref bool? paragraphs,
            ref bool? profanityFilter,
            ref bool? punctuate,
            ref bool? redact,
            ref bool? replace,
            ref bool? sampleRate,
            ref bool? search,
            ref bool? sentiment,
            ref bool? smartFormat,
            ref bool? summarize,
            ref string? tag,
            ref bool? topics,
            ref bool? uttSplit,
            ref bool? utterances,
            ref bool? version);
        partial void PrepareGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string projectId,
            global::System.DateTime? start,
            global::System.DateTime? end,
            string? accessor,
            bool? alternatives,
            bool? callbackMethod,
            bool? callback,
            bool? channels,
            bool? customIntentMode,
            bool? customIntent,
            bool? customTopicMode,
            bool? customTopic,
            global::Deepgram.V1ProjectsProjectIdUsageGetParametersDeployment? deployment,
            bool? detectEntities,
            bool? detectLanguage,
            bool? diarize,
            bool? dictation,
            bool? encoding,
            global::Deepgram.V1ProjectsProjectIdUsageGetParametersEndpoint? endpoint,
            bool? extra,
            bool? fillerWords,
            bool? intents,
            bool? keyterm,
            bool? keywords,
            bool? language,
            bool? measurements,
            global::Deepgram.V1ProjectsProjectIdUsageGetParametersMethod? method,
            string? model,
            bool? multichannel,
            bool? numerals,
            bool? paragraphs,
            bool? profanityFilter,
            bool? punctuate,
            bool? redact,
            bool? replace,
            bool? sampleRate,
            bool? search,
            bool? sentiment,
            bool? smartFormat,
            bool? summarize,
            string? tag,
            bool? topics,
            bool? uttSplit,
            bool? utterances,
            bool? version);
        partial void ProcessGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Project Usage<br/>
        /// Retrieves the usage for a specific project. Use Get Project Usage Breakdown for a more comprehensive usage summary.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
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
        public async global::System.Threading.Tasks.Task<global::Deepgram.UsageV1Response> GetAsync(
            string projectId,
            global::System.DateTime? start = default,
            global::System.DateTime? end = default,
            string? accessor = default,
            bool? alternatives = default,
            bool? callbackMethod = default,
            bool? callback = default,
            bool? channels = default,
            bool? customIntentMode = default,
            bool? customIntent = default,
            bool? customTopicMode = default,
            bool? customTopic = default,
            global::Deepgram.V1ProjectsProjectIdUsageGetParametersDeployment? deployment = default,
            bool? detectEntities = default,
            bool? detectLanguage = default,
            bool? diarize = default,
            bool? dictation = default,
            bool? encoding = default,
            global::Deepgram.V1ProjectsProjectIdUsageGetParametersEndpoint? endpoint = default,
            bool? extra = default,
            bool? fillerWords = default,
            bool? intents = default,
            bool? keyterm = default,
            bool? keywords = default,
            bool? language = default,
            bool? measurements = default,
            global::Deepgram.V1ProjectsProjectIdUsageGetParametersMethod? method = default,
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetArguments(
                httpClient: HttpClient,
                projectId: ref projectId,
                start: ref start,
                end: ref end,
                accessor: ref accessor,
                alternatives: ref alternatives,
                callbackMethod: ref callbackMethod,
                callback: ref callback,
                channels: ref channels,
                customIntentMode: ref customIntentMode,
                customIntent: ref customIntent,
                customTopicMode: ref customTopicMode,
                customTopic: ref customTopic,
                deployment: ref deployment,
                detectEntities: ref detectEntities,
                detectLanguage: ref detectLanguage,
                diarize: ref diarize,
                dictation: ref dictation,
                encoding: ref encoding,
                endpoint: ref endpoint,
                extra: ref extra,
                fillerWords: ref fillerWords,
                intents: ref intents,
                keyterm: ref keyterm,
                keywords: ref keywords,
                language: ref language,
                measurements: ref measurements,
                method: ref method,
                model: ref model,
                multichannel: ref multichannel,
                numerals: ref numerals,
                paragraphs: ref paragraphs,
                profanityFilter: ref profanityFilter,
                punctuate: ref punctuate,
                redact: ref redact,
                replace: ref replace,
                sampleRate: ref sampleRate,
                search: ref search,
                sentiment: ref sentiment,
                smartFormat: ref smartFormat,
                summarize: ref summarize,
                tag: ref tag,
                topics: ref topics,
                uttSplit: ref uttSplit,
                utterances: ref utterances,
                version: ref version);


            var __authorizations = global::Deepgram.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetSecurityRequirements,
                operationName: "GetAsync");

            using var __timeoutCancellationTokenSource = global::Deepgram.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Deepgram.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Deepgram.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::Deepgram.PathBuilder(
                                path: $"/v1/projects/{projectId}/usage",
                                baseUri: ResolveBaseUri(
                                servers: s_GetServers,
                                defaultBaseUrl: "https://api.deepgram.com/")); 
                            __pathBuilder
                                .AddOptionalParameter("start", start?.ToString("yyyy-MM-dd"))
                                .AddOptionalParameter("end", end?.ToString("yyyy-MM-dd"))
                                .AddOptionalParameter("accessor", accessor)
                                .AddOptionalParameter("alternatives", alternatives?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("callback_method", callbackMethod?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("callback", callback?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("channels", channels?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("custom_intent_mode", customIntentMode?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("custom_intent", customIntent?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("custom_topic_mode", customTopicMode?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("custom_topic", customTopic?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("deployment", deployment?.ToValueString())
                                .AddOptionalParameter("detect_entities", detectEntities?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("detect_language", detectLanguage?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("diarize", diarize?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("dictation", dictation?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("encoding", encoding?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("endpoint", endpoint?.ToValueString())
                                .AddOptionalParameter("extra", extra?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("filler_words", fillerWords?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("intents", intents?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("keyterm", keyterm?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("keywords", keywords?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("language", language?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("measurements", measurements?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("method", method?.ToValueString())
                                .AddOptionalParameter("model", model)
                                .AddOptionalParameter("multichannel", multichannel?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("numerals", numerals?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("paragraphs", paragraphs?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("profanity_filter", profanityFilter?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("punctuate", punctuate?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("redact", redact?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("replace", replace?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("sample_rate", sampleRate?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("search", search?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("sentiment", sentiment?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("smart_format", smartFormat?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("summarize", summarize?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("tag", tag)
                                .AddOptionalParameter("topics", topics?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("utt_split", uttSplit?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("utterances", utterances?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("version", version?.ToString().ToLowerInvariant()) 
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Deepgram.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }
                global::Deepgram.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareGetRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    projectId: projectId!,
                    start: start,
                    end: end,
                    accessor: accessor,
                    alternatives: alternatives,
                    callbackMethod: callbackMethod,
                    callback: callback,
                    channels: channels,
                    customIntentMode: customIntentMode,
                    customIntent: customIntent,
                    customTopicMode: customTopicMode,
                    customTopic: customTopic,
                    deployment: deployment,
                    detectEntities: detectEntities,
                    detectLanguage: detectLanguage,
                    diarize: diarize,
                    dictation: dictation,
                    encoding: encoding,
                    endpoint: endpoint,
                    extra: extra,
                    fillerWords: fillerWords,
                    intents: intents,
                    keyterm: keyterm,
                    keywords: keywords,
                    language: language,
                    measurements: measurements,
                    method: method,
                    model: model,
                    multichannel: multichannel,
                    numerals: numerals,
                    paragraphs: paragraphs,
                    profanityFilter: profanityFilter,
                    punctuate: punctuate,
                    redact: redact,
                    replace: replace,
                    sampleRate: sampleRate,
                    search: search,
                    sentiment: sentiment,
                    smartFormat: smartFormat,
                    summarize: summarize,
                    tag: tag,
                    topics: topics,
                    uttSplit: uttSplit,
                    utterances: utterances,
                    version: version);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Deepgram.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Deepgram.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Get",
                                methodName: "GetAsync",
                                pathTemplate: "$\"/v1/projects/{projectId}/usage\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Deepgram.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Deepgram.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Get",
                                methodName: "GetAsync",
                                pathTemplate: "$\"/v1/projects/{projectId}/usage\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Deepgram.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Deepgram.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::Deepgram.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Deepgram.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Get",
                                methodName: "GetAsync",
                                pathTemplate: "$\"/v1/projects/{projectId}/usage\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Deepgram.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessGetResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Deepgram.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Deepgram.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Get",
                                methodName: "GetAsync",
                                pathTemplate: "$\"/v1/projects/{projectId}/usage\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Deepgram.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Deepgram.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Get",
                                methodName: "GetAsync",
                                pathTemplate: "$\"/v1/projects/{projectId}/usage\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Invalid Request
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::Deepgram.ErrorResponse? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::Deepgram.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::Deepgram.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }

                                throw new global::Deepgram.ApiException<global::Deepgram.ErrorResponse?>(
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_400,
                                    ResponseObject = __value_400,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessGetResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::Deepgram.UsageV1Response.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::Deepgram.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::Deepgram.UsageV1Response.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw new global::Deepgram.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}