#nullable enable

namespace Deepgram
{
    public partial interface ISubpackageListenSubpackageListenV1SubpackageListenV1MediaClient
    {
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
        /// <param name="model"></param>
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
        /// <param name="redact"></param>
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
        /// <param name="version"></param>
        /// <param name="mipOptOut">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.ListenV1MediaTranscribeResponse200> TranscribeAsync(

            global::Deepgram.ListenV1RequestUrl request,
            string? callback = default,
            global::Deepgram.V1ListenPostParametersCallbackMethod? callbackMethod = default,
            global::Deepgram.V1ListenPostParametersExtra? extra = default,
            bool? sentiment = default,
            global::Deepgram.V1ListenPostParametersSummarize? summarize = default,
            global::Deepgram.V1ListenPostParametersTag? tag = default,
            bool? topics = default,
            global::Deepgram.V1ListenPostParametersCustomTopic? customTopic = default,
            global::Deepgram.V1ListenPostParametersCustomTopicMode? customTopicMode = default,
            bool? intents = default,
            global::Deepgram.V1ListenPostParametersCustomIntent? customIntent = default,
            global::Deepgram.V1ListenPostParametersCustomIntentMode? customIntentMode = default,
            bool? detectEntities = default,
            global::Deepgram.V1ListenPostParametersDetectLanguage? detectLanguage = default,
            bool? diarize = default,
            bool? dictation = default,
            global::Deepgram.V1ListenPostParametersEncoding? encoding = default,
            bool? fillerWords = default,
            global::System.Collections.Generic.IList<string>? keyterm = default,
            global::Deepgram.V1ListenPostParametersKeywords? keywords = default,
            string? language = default,
            bool? measurements = default,
            global::Deepgram.V1ListenPostParametersModel? model = default,
            bool? multichannel = default,
            bool? numerals = default,
            bool? paragraphs = default,
            bool? profanityFilter = default,
            bool? punctuate = default,
            global::Deepgram.V1ListenPostParametersRedact? redact = default,
            global::Deepgram.V1ListenPostParametersReplace? replace = default,
            global::Deepgram.V1ListenPostParametersSearch? search = default,
            bool? smartFormat = default,
            bool? utterances = default,
            double? uttSplit = default,
            global::Deepgram.V1ListenPostParametersVersion? version = default,
            bool? mipOptOut = default,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        /// <param name="model"></param>
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
        /// <param name="redact"></param>
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
        /// <param name="version"></param>
        /// <param name="mipOptOut">
        /// Default Value: false
        /// </param>
        /// <param name="url"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.ListenV1MediaTranscribeResponse200> TranscribeAsync(
            string url,
            string? callback = default,
            global::Deepgram.V1ListenPostParametersCallbackMethod? callbackMethod = default,
            global::Deepgram.V1ListenPostParametersExtra? extra = default,
            bool? sentiment = default,
            global::Deepgram.V1ListenPostParametersSummarize? summarize = default,
            global::Deepgram.V1ListenPostParametersTag? tag = default,
            bool? topics = default,
            global::Deepgram.V1ListenPostParametersCustomTopic? customTopic = default,
            global::Deepgram.V1ListenPostParametersCustomTopicMode? customTopicMode = default,
            bool? intents = default,
            global::Deepgram.V1ListenPostParametersCustomIntent? customIntent = default,
            global::Deepgram.V1ListenPostParametersCustomIntentMode? customIntentMode = default,
            bool? detectEntities = default,
            global::Deepgram.V1ListenPostParametersDetectLanguage? detectLanguage = default,
            bool? diarize = default,
            bool? dictation = default,
            global::Deepgram.V1ListenPostParametersEncoding? encoding = default,
            bool? fillerWords = default,
            global::System.Collections.Generic.IList<string>? keyterm = default,
            global::Deepgram.V1ListenPostParametersKeywords? keywords = default,
            string? language = default,
            bool? measurements = default,
            global::Deepgram.V1ListenPostParametersModel? model = default,
            bool? multichannel = default,
            bool? numerals = default,
            bool? paragraphs = default,
            bool? profanityFilter = default,
            bool? punctuate = default,
            global::Deepgram.V1ListenPostParametersRedact? redact = default,
            global::Deepgram.V1ListenPostParametersReplace? replace = default,
            global::Deepgram.V1ListenPostParametersSearch? search = default,
            bool? smartFormat = default,
            bool? utterances = default,
            double? uttSplit = default,
            global::Deepgram.V1ListenPostParametersVersion? version = default,
            bool? mipOptOut = default,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}