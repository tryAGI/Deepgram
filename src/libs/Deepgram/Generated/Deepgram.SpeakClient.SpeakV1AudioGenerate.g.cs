
#nullable enable

namespace Deepgram
{
    public partial class SpeakClient
    {
        partial void PrepareSpeakV1AudioGenerateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? callback,
            ref global::Deepgram.SpeakV1AudioGenerateCallbackMethod? callbackMethod,
            ref bool? mipOptOut,
            ref global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? tag,
            ref double? bitRate,
            ref global::Deepgram.OneOf<global::Deepgram.SpeakV1AudioGenerateContainerNone?, global::Deepgram.SpeakV1AudioGenerateContainerLinear16?, global::Deepgram.SpeakV1AudioGenerateContainerMulaw?, global::Deepgram.SpeakV1AudioGenerateContainerAlaw?, global::Deepgram.SpeakV1AudioGenerateContainerOpus?>? container,
            ref global::Deepgram.OneOf<global::Deepgram.SpeakV1AudioGenerateEncodingLinear16?, global::Deepgram.SpeakV1AudioGenerateEncodingFlac?, global::Deepgram.SpeakV1AudioGenerateEncodingMulaw?, global::Deepgram.SpeakV1AudioGenerateEncodingAlaw?, global::Deepgram.SpeakV1AudioGenerateEncodingMp3?, global::Deepgram.SpeakV1AudioGenerateEncodingOpus?, global::Deepgram.SpeakV1AudioGenerateEncodingAac?>? encoding,
            ref global::Deepgram.SpeakV1AudioGenerateModel? model,
            ref double? sampleRate,
            global::Deepgram.SpeakV1Request request);
        partial void PrepareSpeakV1AudioGenerateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? callback,
            global::Deepgram.SpeakV1AudioGenerateCallbackMethod? callbackMethod,
            bool? mipOptOut,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? tag,
            double? bitRate,
            global::Deepgram.OneOf<global::Deepgram.SpeakV1AudioGenerateContainerNone?, global::Deepgram.SpeakV1AudioGenerateContainerLinear16?, global::Deepgram.SpeakV1AudioGenerateContainerMulaw?, global::Deepgram.SpeakV1AudioGenerateContainerAlaw?, global::Deepgram.SpeakV1AudioGenerateContainerOpus?>? container,
            global::Deepgram.OneOf<global::Deepgram.SpeakV1AudioGenerateEncodingLinear16?, global::Deepgram.SpeakV1AudioGenerateEncodingFlac?, global::Deepgram.SpeakV1AudioGenerateEncodingMulaw?, global::Deepgram.SpeakV1AudioGenerateEncodingAlaw?, global::Deepgram.SpeakV1AudioGenerateEncodingMp3?, global::Deepgram.SpeakV1AudioGenerateEncodingOpus?, global::Deepgram.SpeakV1AudioGenerateEncodingAac?>? encoding,
            global::Deepgram.SpeakV1AudioGenerateModel? model,
            double? sampleRate,
            global::Deepgram.SpeakV1Request request);
        partial void ProcessSpeakV1AudioGenerateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSpeakV1AudioGenerateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref byte[] content);

        /// <summary>
        /// Text to Speech transformation<br/>
        /// Convert text into natural-sounding speech using Deepgram's TTS REST API
        /// </summary>
        /// <param name="callback"></param>
        /// <param name="callbackMethod">
        /// Default Value: POST
        /// </param>
        /// <param name="mipOptOut">
        /// Default Value: false
        /// </param>
        /// <param name="tag"></param>
        /// <param name="bitRate">
        /// Default Value: 48000
        /// </param>
        /// <param name="container">
        /// Default Value: wav
        /// </param>
        /// <param name="encoding">
        /// Default Value: mp3
        /// </param>
        /// <param name="model">
        /// Default Value: aura-asteria-en
        /// </param>
        /// <param name="sampleRate">
        /// Default Value: 24000
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<byte[]> SpeakV1AudioGenerateAsync(

            global::Deepgram.SpeakV1Request request,
            string? callback = default,
            global::Deepgram.SpeakV1AudioGenerateCallbackMethod? callbackMethod = default,
            bool? mipOptOut = default,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? tag = default,
            double? bitRate = default,
            global::Deepgram.OneOf<global::Deepgram.SpeakV1AudioGenerateContainerNone?, global::Deepgram.SpeakV1AudioGenerateContainerLinear16?, global::Deepgram.SpeakV1AudioGenerateContainerMulaw?, global::Deepgram.SpeakV1AudioGenerateContainerAlaw?, global::Deepgram.SpeakV1AudioGenerateContainerOpus?>? container = default,
            global::Deepgram.OneOf<global::Deepgram.SpeakV1AudioGenerateEncodingLinear16?, global::Deepgram.SpeakV1AudioGenerateEncodingFlac?, global::Deepgram.SpeakV1AudioGenerateEncodingMulaw?, global::Deepgram.SpeakV1AudioGenerateEncodingAlaw?, global::Deepgram.SpeakV1AudioGenerateEncodingMp3?, global::Deepgram.SpeakV1AudioGenerateEncodingOpus?, global::Deepgram.SpeakV1AudioGenerateEncodingAac?>? encoding = default,
            global::Deepgram.SpeakV1AudioGenerateModel? model = default,
            double? sampleRate = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSpeakV1AudioGenerateArguments(
                httpClient: HttpClient,
                callback: ref callback,
                callbackMethod: ref callbackMethod,
                mipOptOut: ref mipOptOut,
                tag: ref tag,
                bitRate: ref bitRate,
                container: ref container,
                encoding: ref encoding,
                model: ref model,
                sampleRate: ref sampleRate,
                request: request);

            var __pathBuilder = new global::Deepgram.PathBuilder(
                path: "/v1/speak",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("callback", callback)
                .AddOptionalParameter("callback_method", callbackMethod?.ToValueString())
                .AddOptionalParameter("mip_opt_out", mipOptOut?.ToString())
                .AddOptionalParameter("tag", tag?.ToString())
                .AddOptionalParameter("bit_rate", bitRate?.ToString())
                .AddOptionalParameter("container", container?.ToString())
                .AddOptionalParameter("encoding", encoding?.ToString())
                .AddOptionalParameter("model", model?.ToValueString())
                .AddOptionalParameter("sample_rate", sampleRate?.ToString()) 
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareSpeakV1AudioGenerateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                callback: callback,
                callbackMethod: callbackMethod,
                mipOptOut: mipOptOut,
                tag: tag,
                bitRate: bitRate,
                container: container,
                encoding: encoding,
                model: model,
                sampleRate: sampleRate,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessSpeakV1AudioGenerateResponse(
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
                        __value_400 = global::Deepgram.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

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

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsByteArrayAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessSpeakV1AudioGenerateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return __content;
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Deepgram.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
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

                    var __content = await __response.Content.ReadAsByteArrayAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return __content;
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
        /// Text to Speech transformation<br/>
        /// Convert text into natural-sounding speech using Deepgram's TTS REST API
        /// </summary>
        /// <param name="callback"></param>
        /// <param name="callbackMethod">
        /// Default Value: POST
        /// </param>
        /// <param name="mipOptOut">
        /// Default Value: false
        /// </param>
        /// <param name="tag"></param>
        /// <param name="bitRate">
        /// Default Value: 48000
        /// </param>
        /// <param name="container">
        /// Default Value: wav
        /// </param>
        /// <param name="encoding">
        /// Default Value: mp3
        /// </param>
        /// <param name="model">
        /// Default Value: aura-asteria-en
        /// </param>
        /// <param name="sampleRate">
        /// Default Value: 24000
        /// </param>
        /// <param name="text">
        /// The text content to be converted to speech<br/>
        /// Example: Hello, welcome to Deepgram!
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<byte[]> SpeakV1AudioGenerateAsync(
            string text,
            string? callback = default,
            global::Deepgram.SpeakV1AudioGenerateCallbackMethod? callbackMethod = default,
            bool? mipOptOut = default,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? tag = default,
            double? bitRate = default,
            global::Deepgram.OneOf<global::Deepgram.SpeakV1AudioGenerateContainerNone?, global::Deepgram.SpeakV1AudioGenerateContainerLinear16?, global::Deepgram.SpeakV1AudioGenerateContainerMulaw?, global::Deepgram.SpeakV1AudioGenerateContainerAlaw?, global::Deepgram.SpeakV1AudioGenerateContainerOpus?>? container = default,
            global::Deepgram.OneOf<global::Deepgram.SpeakV1AudioGenerateEncodingLinear16?, global::Deepgram.SpeakV1AudioGenerateEncodingFlac?, global::Deepgram.SpeakV1AudioGenerateEncodingMulaw?, global::Deepgram.SpeakV1AudioGenerateEncodingAlaw?, global::Deepgram.SpeakV1AudioGenerateEncodingMp3?, global::Deepgram.SpeakV1AudioGenerateEncodingOpus?, global::Deepgram.SpeakV1AudioGenerateEncodingAac?>? encoding = default,
            global::Deepgram.SpeakV1AudioGenerateModel? model = default,
            double? sampleRate = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Deepgram.SpeakV1Request
            {
                Text = text,
            };

            return await SpeakV1AudioGenerateAsync(
                callback: callback,
                callbackMethod: callbackMethod,
                mipOptOut: mipOptOut,
                tag: tag,
                bitRate: bitRate,
                container: container,
                encoding: encoding,
                model: model,
                sampleRate: sampleRate,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}