#nullable enable

namespace Deepgram
{
    public partial interface IListenClient
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
        global::System.Threading.Tasks.Task<global::Deepgram.OneOf<global::Deepgram.ListenV1Response, global::Deepgram.ListenV1AcceptedResponse>> ListenV1MediaTranscribeAsync(

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
        global::System.Threading.Tasks.Task<global::Deepgram.OneOf<global::Deepgram.ListenV1Response, global::Deepgram.ListenV1AcceptedResponse>> ListenV1MediaTranscribeAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}