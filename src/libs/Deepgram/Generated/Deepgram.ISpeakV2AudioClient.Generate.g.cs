#nullable enable

namespace Deepgram
{
    public partial interface ISpeakV2AudioClient
    {
        /// <summary>
        /// Flux Text to Speech (batch)<br/>
        /// Synthesize a complete block of text into a single audio response using Deepgram's Flux TTS batch (REST) API. Use this for pre-rendering fixed audio (IVR prompts, notifications, narration) where the whole text is known up front and you don't need incremental playback or interruption.
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
        /// <param name="model"></param>
        /// <param name="sampleRate">
        /// Default Value: 24000
        /// </param>
        /// <param name="priority"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.SpeakV2AcceptedResponse> GenerateAsync(
            string model,

            global::Deepgram.SpeakV2Request request,
            string? callback = default,
            global::Deepgram.V2SpeakPostParametersCallbackMethod? callbackMethod = default,
            bool? mipOptOut = default,
            global::Deepgram.V2SpeakPostParametersTag? tag = default,
            global::Deepgram.V2SpeakPostParametersBitRate? bitRate = default,
            global::Deepgram.V2SpeakPostParametersContainer? container = default,
            global::Deepgram.V2SpeakPostParametersEncoding? encoding = default,
            global::Deepgram.V2SpeakPostParametersSampleRate? sampleRate = default,
            global::Deepgram.V2SpeakPostParametersPriority? priority = default,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Flux Text to Speech (batch)<br/>
        /// Synthesize a complete block of text into a single audio response using Deepgram's Flux TTS batch (REST) API. Use this for pre-rendering fixed audio (IVR prompts, notifications, narration) where the whole text is known up front and you don't need incremental playback or interruption.
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
        /// <param name="model"></param>
        /// <param name="sampleRate">
        /// Default Value: 24000
        /// </param>
        /// <param name="priority"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.AutoSDKHttpResponse<global::Deepgram.SpeakV2AcceptedResponse>> GenerateAsResponseAsync(
            string model,

            global::Deepgram.SpeakV2Request request,
            string? callback = default,
            global::Deepgram.V2SpeakPostParametersCallbackMethod? callbackMethod = default,
            bool? mipOptOut = default,
            global::Deepgram.V2SpeakPostParametersTag? tag = default,
            global::Deepgram.V2SpeakPostParametersBitRate? bitRate = default,
            global::Deepgram.V2SpeakPostParametersContainer? container = default,
            global::Deepgram.V2SpeakPostParametersEncoding? encoding = default,
            global::Deepgram.V2SpeakPostParametersSampleRate? sampleRate = default,
            global::Deepgram.V2SpeakPostParametersPriority? priority = default,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Flux Text to Speech (batch)<br/>
        /// Synthesize a complete block of text into a single audio response using Deepgram's Flux TTS batch (REST) API. Use this for pre-rendering fixed audio (IVR prompts, notifications, narration) where the whole text is known up front and you don't need incremental playback or interruption.
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
        /// <param name="model"></param>
        /// <param name="sampleRate">
        /// Default Value: 24000
        /// </param>
        /// <param name="priority"></param>
        /// <param name="text">
        /// The text content to be converted to speech. The server normalizes and preprocesses the text (e.g. stripping inline controls) before synthesis.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.SpeakV2AcceptedResponse> GenerateAsync(
            string model,
            string text,
            string? callback = default,
            global::Deepgram.V2SpeakPostParametersCallbackMethod? callbackMethod = default,
            bool? mipOptOut = default,
            global::Deepgram.V2SpeakPostParametersTag? tag = default,
            global::Deepgram.V2SpeakPostParametersBitRate? bitRate = default,
            global::Deepgram.V2SpeakPostParametersContainer? container = default,
            global::Deepgram.V2SpeakPostParametersEncoding? encoding = default,
            global::Deepgram.V2SpeakPostParametersSampleRate? sampleRate = default,
            global::Deepgram.V2SpeakPostParametersPriority? priority = default,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}