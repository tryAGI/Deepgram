
#nullable enable

namespace Deepgram
{
    public partial class ManageClient
    {
        partial void PrepareGet8Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.DateTime? start,
            ref global::System.DateTime? end,
            ref global::Deepgram.ManageV1ProjectsUsageBreakdownGetGrouping? grouping,
            ref string? accessor,
            ref bool? alternatives,
            ref bool? callbackMethod,
            ref bool? callback,
            ref bool? channels,
            ref bool? customIntentMode,
            ref bool? customIntent,
            ref bool? customTopicMode,
            ref bool? customTopic,
            ref global::Deepgram.ManageV1ProjectsUsageBreakdownGetDeployment? deployment,
            ref bool? detectEntities,
            ref bool? detectLanguage,
            ref bool? diarize,
            ref bool? dictation,
            ref bool? encoding,
            ref global::Deepgram.ManageV1ProjectsUsageBreakdownGetEndpoint? endpoint,
            ref bool? extra,
            ref bool? fillerWords,
            ref bool? intents,
            ref bool? keyterm,
            ref bool? keywords,
            ref bool? language,
            ref bool? measurements,
            ref global::Deepgram.ManageV1ProjectsUsageBreakdownGetMethod? method,
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
            ref bool? version,
            ref string projectId);
        partial void PrepareGet8Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.DateTime? start,
            global::System.DateTime? end,
            global::Deepgram.ManageV1ProjectsUsageBreakdownGetGrouping? grouping,
            string? accessor,
            bool? alternatives,
            bool? callbackMethod,
            bool? callback,
            bool? channels,
            bool? customIntentMode,
            bool? customIntent,
            bool? customTopicMode,
            bool? customTopic,
            global::Deepgram.ManageV1ProjectsUsageBreakdownGetDeployment? deployment,
            bool? detectEntities,
            bool? detectLanguage,
            bool? diarize,
            bool? dictation,
            bool? encoding,
            global::Deepgram.ManageV1ProjectsUsageBreakdownGetEndpoint? endpoint,
            bool? extra,
            bool? fillerWords,
            bool? intents,
            bool? keyterm,
            bool? keywords,
            bool? language,
            bool? measurements,
            global::Deepgram.ManageV1ProjectsUsageBreakdownGetMethod? method,
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
            bool? version,
            string projectId);
        partial void ProcessGet8Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGet8ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Project Usage Breakdown<br/>
        /// Retrieves the usage breakdown for a specific project, with various filter options by API feature or by groupings. Setting a feature (e.g. diarize) to true includes requests that used that feature, while false excludes requests that used it. Multiple true filters are combined with OR logic, while false filters use AND logic.
        /// </summary>
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
        /// <param name="sampleRate">
        /// Example: true
        /// </param>
        /// <param name="search"></param>
        /// <param name="sentiment"></param>
        /// <param name="smartFormat"></param>
        /// <param name="summarize"></param>
        /// <param name="tag"></param>
        /// <param name="topics"></param>
        /// <param name="uttSplit"></param>
        /// <param name="utterances"></param>
        /// <param name="version"></param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Deepgram.UsageBreakdownV1Response> Get8Async(
            string projectId,
            global::System.DateTime? start = default,
            global::System.DateTime? end = default,
            global::Deepgram.ManageV1ProjectsUsageBreakdownGetGrouping? grouping = default,
            string? accessor = default,
            bool? alternatives = default,
            bool? callbackMethod = default,
            bool? callback = default,
            bool? channels = default,
            bool? customIntentMode = default,
            bool? customIntent = default,
            bool? customTopicMode = default,
            bool? customTopic = default,
            global::Deepgram.ManageV1ProjectsUsageBreakdownGetDeployment? deployment = default,
            bool? detectEntities = default,
            bool? detectLanguage = default,
            bool? diarize = default,
            bool? dictation = default,
            bool? encoding = default,
            global::Deepgram.ManageV1ProjectsUsageBreakdownGetEndpoint? endpoint = default,
            bool? extra = default,
            bool? fillerWords = default,
            bool? intents = default,
            bool? keyterm = default,
            bool? keywords = default,
            bool? language = default,
            bool? measurements = default,
            global::Deepgram.ManageV1ProjectsUsageBreakdownGetMethod? method = default,
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGet8Arguments(
                httpClient: HttpClient,
                start: ref start,
                end: ref end,
                grouping: ref grouping,
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
                version: ref version,
                projectId: ref projectId);

            var __pathBuilder = new global::Deepgram.PathBuilder(
                path: $"/v1/projects/{projectId}/usage/breakdown",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("start", start?.ToString("yyyy-MM-dd"))
                .AddOptionalParameter("end", end?.ToString("yyyy-MM-dd"))
                .AddOptionalParameter("grouping", grouping?.ToValueString())
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
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGet8Request(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                start: start,
                end: end,
                grouping: grouping,
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
                version: version,
                projectId: projectId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGet8Response(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Invalid Request
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::Deepgram.ErrorResponse? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::Deepgram.ErrorResponse.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::Deepgram.ErrorResponse.FromJson(__content_400, JsonSerializerOptions);
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

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessGet8ResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Deepgram.UsageBreakdownV1Response.FromJson(__content, JsonSerializerOptions) ??
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
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Deepgram.UsageBreakdownV1Response.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
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
}