#nullable enable

namespace Deepgram
{
    public partial interface ISubpackageSpeakSubpackageSpeakV1SubpackageSpeakV1AudioClient
    {
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
        /// <param name="bitRate"></param>
        /// <param name="container"></param>
        /// <param name="encoding"></param>
        /// <param name="model">
        /// Default Value: aura-asteria-en
        /// </param>
        /// <param name="sampleRate"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.SpeakV1AudioGenerateResponse200> GenerateAsync(

            global::Deepgram.SpeakV1Request request,
            string? callback = default,
            global::Deepgram.V1SpeakPostParametersCallbackMethod? callbackMethod = default,
            bool? mipOptOut = default,
            global::Deepgram.V1SpeakPostParametersTag? tag = default,
            global::Deepgram.V1SpeakPostParametersBitRate? bitRate = default,
            global::Deepgram.V1SpeakPostParametersContainer? container = default,
            global::Deepgram.V1SpeakPostParametersEncoding? encoding = default,
            global::Deepgram.V1SpeakPostParametersModel? model = default,
            global::Deepgram.V1SpeakPostParametersSampleRate? sampleRate = default,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        /// <param name="bitRate"></param>
        /// <param name="container"></param>
        /// <param name="encoding"></param>
        /// <param name="model">
        /// Default Value: aura-asteria-en
        /// </param>
        /// <param name="sampleRate"></param>
        /// <param name="text">
        /// The text content to be converted to speech
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.SpeakV1AudioGenerateResponse200> GenerateAsync(
            string text,
            string? callback = default,
            global::Deepgram.V1SpeakPostParametersCallbackMethod? callbackMethod = default,
            bool? mipOptOut = default,
            global::Deepgram.V1SpeakPostParametersTag? tag = default,
            global::Deepgram.V1SpeakPostParametersBitRate? bitRate = default,
            global::Deepgram.V1SpeakPostParametersContainer? container = default,
            global::Deepgram.V1SpeakPostParametersEncoding? encoding = default,
            global::Deepgram.V1SpeakPostParametersModel? model = default,
            global::Deepgram.V1SpeakPostParametersSampleRate? sampleRate = default,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}