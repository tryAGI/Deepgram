#nullable enable

namespace Deepgram
{
    public partial interface ISpeakClient
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
        global::System.Threading.Tasks.Task<byte[]> GenerateAsync(

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
        global::System.Threading.Tasks.Task<byte[]> GenerateAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}