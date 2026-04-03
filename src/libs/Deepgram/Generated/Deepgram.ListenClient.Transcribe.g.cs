
#nullable enable

namespace Deepgram
{
    public partial class ListenClient
    {
        partial void PrepareTranscribeArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? callback,
            ref global::Deepgram.ListenV1MediaTranscribeCallbackMethod? callbackMethod,
            ref global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? extra,
            ref bool? sentiment,
            ref global::Deepgram.OneOf<global::Deepgram.ListenV1MediaTranscribeSummarize2?, bool?>? summarize,
            ref global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? tag,
            ref bool? topics,
            ref global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? customTopic,
            ref global::Deepgram.ListenV1MediaTranscribeCustomTopicMode? customTopicMode,
            ref bool? intents,
            ref global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? customIntent,
            ref global::Deepgram.ListenV1MediaTranscribeCustomIntentMode? customIntentMode,
            ref bool? detectEntities,
            ref global::Deepgram.OneOf<bool?, global::System.Collections.Generic.IList<string>>? detectLanguage,
            ref bool? diarize,
            ref bool? dictation,
            ref global::Deepgram.ListenV1MediaTranscribeEncoding? encoding,
            ref bool? fillerWords,
            global::System.Collections.Generic.IList<string>? keyterm,
            ref global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? keywords,
            ref string? language,
            ref bool? measurements,
            ref global::Deepgram.OneOf<global::Deepgram.ListenV1MediaTranscribeModel2?, string>? model,
            ref bool? multichannel,
            ref bool? numerals,
            ref bool? paragraphs,
            ref bool? profanityFilter,
            ref bool? punctuate,
            ref global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<global::Deepgram.ListenV1MediaTranscribeRedactVariant2Item>>? redact,
            ref global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? replace,
            ref global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? search,
            ref bool? smartFormat,
            ref bool? utterances,
            ref double? uttSplit,
            ref global::Deepgram.OneOf<global::Deepgram.ListenV1MediaTranscribeVersion2?, string>? version,
            ref bool? mipOptOut,
            global::Deepgram.ListenV1RequestUrl request);
        partial void PrepareTranscribeRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? callback,
            global::Deepgram.ListenV1MediaTranscribeCallbackMethod? callbackMethod,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? extra,
            bool? sentiment,
            global::Deepgram.OneOf<global::Deepgram.ListenV1MediaTranscribeSummarize2?, bool?>? summarize,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? tag,
            bool? topics,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? customTopic,
            global::Deepgram.ListenV1MediaTranscribeCustomTopicMode? customTopicMode,
            bool? intents,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? customIntent,
            global::Deepgram.ListenV1MediaTranscribeCustomIntentMode? customIntentMode,
            bool? detectEntities,
            global::Deepgram.OneOf<bool?, global::System.Collections.Generic.IList<string>>? detectLanguage,
            bool? diarize,
            bool? dictation,
            global::Deepgram.ListenV1MediaTranscribeEncoding? encoding,
            bool? fillerWords,
            global::System.Collections.Generic.IList<string>? keyterm,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? keywords,
            string? language,
            bool? measurements,
            global::Deepgram.OneOf<global::Deepgram.ListenV1MediaTranscribeModel2?, string>? model,
            bool? multichannel,
            bool? numerals,
            bool? paragraphs,
            bool? profanityFilter,
            bool? punctuate,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<global::Deepgram.ListenV1MediaTranscribeRedactVariant2Item>>? redact,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? replace,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? search,
            bool? smartFormat,
            bool? utterances,
            double? uttSplit,
            global::Deepgram.OneOf<global::Deepgram.ListenV1MediaTranscribeVersion2?, string>? version,
            bool? mipOptOut,
            global::Deepgram.ListenV1RequestUrl request);
        partial void ProcessTranscribeResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTranscribeResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Transcribe and analyze pre-recorded audio and video<br/>
        /// Transcribe audio and video using Deepgram's speech-to-text REST API
        /// </summary>
        /// <param name="callback"></param>
        /// <param name="callbackMethod">
        /// Default Value: POST
        /// </param>
        /// <param name="extra"></param>
        /// <param name="sentiment">
        /// Default Value: false
        /// </param>
        /// <param name="summarize"></param>
        /// <param name="tag"></param>
        /// <param name="topics">
        /// Default Value: false
        /// </param>
        /// <param name="customTopic"></param>
        /// <param name="customTopicMode">
        /// Default Value: extended
        /// </param>
        /// <param name="intents">
        /// Default Value: false
        /// </param>
        /// <param name="customIntent"></param>
        /// <param name="customIntentMode">
        /// Default Value: extended
        /// </param>
        /// <param name="detectEntities">
        /// Default Value: false
        /// </param>
        /// <param name="detectLanguage"></param>
        /// <param name="diarize">
        /// Default Value: false
        /// </param>
        /// <param name="dictation">
        /// Default Value: false
        /// </param>
        /// <param name="encoding"></param>
        /// <param name="fillerWords">
        /// Default Value: false
        /// </param>
        /// <param name="keyterm"></param>
        /// <param name="keywords"></param>
        /// <param name="language">
        /// Default Value: en
        /// </param>
        /// <param name="measurements">
        /// Default Value: false
        /// </param>
        /// <param name="model">
        /// Default Value: base-general<br/>
        /// Example: nova-3
        /// </param>
        /// <param name="multichannel">
        /// Default Value: false
        /// </param>
        /// <param name="numerals">
        /// Default Value: false
        /// </param>
        /// <param name="paragraphs">
        /// Default Value: false
        /// </param>
        /// <param name="profanityFilter">
        /// Default Value: false
        /// </param>
        /// <param name="punctuate">
        /// Default Value: false
        /// </param>
        /// <param name="redact">
        /// Default Value: false
        /// </param>
        /// <param name="replace"></param>
        /// <param name="search"></param>
        /// <param name="smartFormat">
        /// Default Value: false
        /// </param>
        /// <param name="utterances">
        /// Default Value: false
        /// </param>
        /// <param name="uttSplit">
        /// Default Value: 0.8
        /// </param>
        /// <param name="version">
        /// Default Value: latest
        /// </param>
        /// <param name="mipOptOut">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Deepgram.OneOf<global::Deepgram.ListenV1Response, global::Deepgram.ListenV1AcceptedResponse>> TranscribeAsync(

            global::Deepgram.ListenV1RequestUrl request,
            string? callback = default,
            global::Deepgram.ListenV1MediaTranscribeCallbackMethod? callbackMethod = default,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? extra = default,
            bool? sentiment = default,
            global::Deepgram.OneOf<global::Deepgram.ListenV1MediaTranscribeSummarize2?, bool?>? summarize = default,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? tag = default,
            bool? topics = default,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? customTopic = default,
            global::Deepgram.ListenV1MediaTranscribeCustomTopicMode? customTopicMode = default,
            bool? intents = default,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? customIntent = default,
            global::Deepgram.ListenV1MediaTranscribeCustomIntentMode? customIntentMode = default,
            bool? detectEntities = default,
            global::Deepgram.OneOf<bool?, global::System.Collections.Generic.IList<string>>? detectLanguage = default,
            bool? diarize = default,
            bool? dictation = default,
            global::Deepgram.ListenV1MediaTranscribeEncoding? encoding = default,
            bool? fillerWords = default,
            global::System.Collections.Generic.IList<string>? keyterm = default,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? keywords = default,
            string? language = default,
            bool? measurements = default,
            global::Deepgram.OneOf<global::Deepgram.ListenV1MediaTranscribeModel2?, string>? model = default,
            bool? multichannel = default,
            bool? numerals = default,
            bool? paragraphs = default,
            bool? profanityFilter = default,
            bool? punctuate = default,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<global::Deepgram.ListenV1MediaTranscribeRedactVariant2Item>>? redact = default,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? replace = default,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? search = default,
            bool? smartFormat = default,
            bool? utterances = default,
            double? uttSplit = default,
            global::Deepgram.OneOf<global::Deepgram.ListenV1MediaTranscribeVersion2?, string>? version = default,
            bool? mipOptOut = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareTranscribeArguments(
                httpClient: HttpClient,
                callback: ref callback,
                callbackMethod: ref callbackMethod,
                extra: ref extra,
                sentiment: ref sentiment,
                summarize: ref summarize,
                tag: ref tag,
                topics: ref topics,
                customTopic: ref customTopic,
                customTopicMode: ref customTopicMode,
                intents: ref intents,
                customIntent: ref customIntent,
                customIntentMode: ref customIntentMode,
                detectEntities: ref detectEntities,
                detectLanguage: ref detectLanguage,
                diarize: ref diarize,
                dictation: ref dictation,
                encoding: ref encoding,
                fillerWords: ref fillerWords,
                keyterm: keyterm,
                keywords: ref keywords,
                language: ref language,
                measurements: ref measurements,
                model: ref model,
                multichannel: ref multichannel,
                numerals: ref numerals,
                paragraphs: ref paragraphs,
                profanityFilter: ref profanityFilter,
                punctuate: ref punctuate,
                redact: ref redact,
                replace: ref replace,
                search: ref search,
                smartFormat: ref smartFormat,
                utterances: ref utterances,
                uttSplit: ref uttSplit,
                version: ref version,
                mipOptOut: ref mipOptOut,
                request: request);

            var __pathBuilder = new global::Deepgram.PathBuilder(
                path: "/v1/listen",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("callback", callback)
                .AddOptionalParameter("callback_method", callbackMethod?.ToValueString())
                .AddOptionalParameter("extra", extra?.ToString())
                .AddOptionalParameter("sentiment", sentiment?.ToString().ToLowerInvariant())
                .AddOptionalParameter("summarize", summarize?.ToString())
                .AddOptionalParameter("tag", tag?.ToString())
                .AddOptionalParameter("topics", topics?.ToString().ToLowerInvariant())
                .AddOptionalParameter("custom_topic", customTopic?.ToString())
                .AddOptionalParameter("custom_topic_mode", customTopicMode?.ToValueString())
                .AddOptionalParameter("intents", intents?.ToString().ToLowerInvariant())
                .AddOptionalParameter("custom_intent", customIntent?.ToString())
                .AddOptionalParameter("custom_intent_mode", customIntentMode?.ToValueString())
                .AddOptionalParameter("detect_entities", detectEntities?.ToString().ToLowerInvariant())
                .AddOptionalParameter("detect_language", detectLanguage?.ToString())
                .AddOptionalParameter("diarize", diarize?.ToString().ToLowerInvariant())
                .AddOptionalParameter("dictation", dictation?.ToString().ToLowerInvariant())
                .AddOptionalParameter("encoding", encoding?.ToValueString())
                .AddOptionalParameter("filler_words", fillerWords?.ToString().ToLowerInvariant())
                .AddOptionalParameter("keyterm", keyterm, delimiter: ",", explode: true)
                .AddOptionalParameter("keywords", keywords?.ToString())
                .AddOptionalParameter("language", language)
                .AddOptionalParameter("measurements", measurements?.ToString().ToLowerInvariant())
                .AddOptionalParameter("model", model?.ToString())
                .AddOptionalParameter("multichannel", multichannel?.ToString().ToLowerInvariant())
                .AddOptionalParameter("numerals", numerals?.ToString().ToLowerInvariant())
                .AddOptionalParameter("paragraphs", paragraphs?.ToString().ToLowerInvariant())
                .AddOptionalParameter("profanity_filter", profanityFilter?.ToString().ToLowerInvariant())
                .AddOptionalParameter("punctuate", punctuate?.ToString().ToLowerInvariant())
                .AddOptionalParameter("redact", redact?.ToString())
                .AddOptionalParameter("replace", replace?.ToString())
                .AddOptionalParameter("search", search?.ToString())
                .AddOptionalParameter("smart_format", smartFormat?.ToString().ToLowerInvariant())
                .AddOptionalParameter("utterances", utterances?.ToString().ToLowerInvariant())
                .AddOptionalParameter("utt_split", uttSplit?.ToString())
                .AddOptionalParameter("version", version?.ToString())
                .AddOptionalParameter("mip_opt_out", mipOptOut?.ToString().ToLowerInvariant()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareTranscribeRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                callback: callback,
                callbackMethod: callbackMethod,
                extra: extra,
                sentiment: sentiment,
                summarize: summarize,
                tag: tag,
                topics: topics,
                customTopic: customTopic,
                customTopicMode: customTopicMode,
                intents: intents,
                customIntent: customIntent,
                customIntentMode: customIntentMode,
                detectEntities: detectEntities,
                detectLanguage: detectLanguage,
                diarize: diarize,
                dictation: dictation,
                encoding: encoding,
                fillerWords: fillerWords,
                keyterm: keyterm,
                keywords: keywords,
                language: language,
                measurements: measurements,
                model: model,
                multichannel: multichannel,
                numerals: numerals,
                paragraphs: paragraphs,
                profanityFilter: profanityFilter,
                punctuate: punctuate,
                redact: redact,
                replace: replace,
                search: search,
                smartFormat: smartFormat,
                utterances: utterances,
                uttSplit: uttSplit,
                version: version,
                mipOptOut: mipOptOut,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessTranscribeResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Invalid Request
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::Deepgram.ListenV1Response? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::Deepgram.ListenV1Response.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::Deepgram.ListenV1Response.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::Deepgram.ApiException<global::Deepgram.ListenV1Response>(
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
                ProcessTranscribeResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Deepgram.OneOf<global::Deepgram.ListenV1Response, global::Deepgram.ListenV1AcceptedResponse>.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::Deepgram.OneOf<global::Deepgram.ListenV1Response, global::Deepgram.ListenV1AcceptedResponse>.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// <summary>
        /// Transcribe and analyze pre-recorded audio and video<br/>
        /// Transcribe audio and video using Deepgram's speech-to-text REST API
        /// </summary>
        /// <param name="callback"></param>
        /// <param name="callbackMethod">
        /// Default Value: POST
        /// </param>
        /// <param name="extra"></param>
        /// <param name="sentiment">
        /// Default Value: false
        /// </param>
        /// <param name="summarize"></param>
        /// <param name="tag"></param>
        /// <param name="topics">
        /// Default Value: false
        /// </param>
        /// <param name="customTopic"></param>
        /// <param name="customTopicMode">
        /// Default Value: extended
        /// </param>
        /// <param name="intents">
        /// Default Value: false
        /// </param>
        /// <param name="customIntent"></param>
        /// <param name="customIntentMode">
        /// Default Value: extended
        /// </param>
        /// <param name="detectEntities">
        /// Default Value: false
        /// </param>
        /// <param name="detectLanguage"></param>
        /// <param name="diarize">
        /// Default Value: false
        /// </param>
        /// <param name="dictation">
        /// Default Value: false
        /// </param>
        /// <param name="encoding"></param>
        /// <param name="fillerWords">
        /// Default Value: false
        /// </param>
        /// <param name="keyterm"></param>
        /// <param name="keywords"></param>
        /// <param name="language">
        /// Default Value: en
        /// </param>
        /// <param name="measurements">
        /// Default Value: false
        /// </param>
        /// <param name="model">
        /// Default Value: base-general<br/>
        /// Example: nova-3
        /// </param>
        /// <param name="multichannel">
        /// Default Value: false
        /// </param>
        /// <param name="numerals">
        /// Default Value: false
        /// </param>
        /// <param name="paragraphs">
        /// Default Value: false
        /// </param>
        /// <param name="profanityFilter">
        /// Default Value: false
        /// </param>
        /// <param name="punctuate">
        /// Default Value: false
        /// </param>
        /// <param name="redact">
        /// Default Value: false
        /// </param>
        /// <param name="replace"></param>
        /// <param name="search"></param>
        /// <param name="smartFormat">
        /// Default Value: false
        /// </param>
        /// <param name="utterances">
        /// Default Value: false
        /// </param>
        /// <param name="uttSplit">
        /// Default Value: 0.8
        /// </param>
        /// <param name="version">
        /// Default Value: latest
        /// </param>
        /// <param name="mipOptOut">
        /// Default Value: false
        /// </param>
        /// <param name="url">
        /// Example: https://dpgr.am/spacewalk.wav
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Deepgram.OneOf<global::Deepgram.ListenV1Response, global::Deepgram.ListenV1AcceptedResponse>> TranscribeAsync(
            string url,
            string? callback = default,
            global::Deepgram.ListenV1MediaTranscribeCallbackMethod? callbackMethod = default,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? extra = default,
            bool? sentiment = default,
            global::Deepgram.OneOf<global::Deepgram.ListenV1MediaTranscribeSummarize2?, bool?>? summarize = default,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? tag = default,
            bool? topics = default,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? customTopic = default,
            global::Deepgram.ListenV1MediaTranscribeCustomTopicMode? customTopicMode = default,
            bool? intents = default,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? customIntent = default,
            global::Deepgram.ListenV1MediaTranscribeCustomIntentMode? customIntentMode = default,
            bool? detectEntities = default,
            global::Deepgram.OneOf<bool?, global::System.Collections.Generic.IList<string>>? detectLanguage = default,
            bool? diarize = default,
            bool? dictation = default,
            global::Deepgram.ListenV1MediaTranscribeEncoding? encoding = default,
            bool? fillerWords = default,
            global::System.Collections.Generic.IList<string>? keyterm = default,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? keywords = default,
            string? language = default,
            bool? measurements = default,
            global::Deepgram.OneOf<global::Deepgram.ListenV1MediaTranscribeModel2?, string>? model = default,
            bool? multichannel = default,
            bool? numerals = default,
            bool? paragraphs = default,
            bool? profanityFilter = default,
            bool? punctuate = default,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<global::Deepgram.ListenV1MediaTranscribeRedactVariant2Item>>? redact = default,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? replace = default,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? search = default,
            bool? smartFormat = default,
            bool? utterances = default,
            double? uttSplit = default,
            global::Deepgram.OneOf<global::Deepgram.ListenV1MediaTranscribeVersion2?, string>? version = default,
            bool? mipOptOut = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Deepgram.ListenV1RequestUrl
            {
                Url = url,
            };

            return await TranscribeAsync(
                callback: callback,
                callbackMethod: callbackMethod,
                extra: extra,
                sentiment: sentiment,
                summarize: summarize,
                tag: tag,
                topics: topics,
                customTopic: customTopic,
                customTopicMode: customTopicMode,
                intents: intents,
                customIntent: customIntent,
                customIntentMode: customIntentMode,
                detectEntities: detectEntities,
                detectLanguage: detectLanguage,
                diarize: diarize,
                dictation: dictation,
                encoding: encoding,
                fillerWords: fillerWords,
                keyterm: keyterm,
                keywords: keywords,
                language: language,
                measurements: measurements,
                model: model,
                multichannel: multichannel,
                numerals: numerals,
                paragraphs: paragraphs,
                profanityFilter: profanityFilter,
                punctuate: punctuate,
                redact: redact,
                replace: replace,
                search: search,
                smartFormat: smartFormat,
                utterances: utterances,
                uttSplit: uttSplit,
                version: version,
                mipOptOut: mipOptOut,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}