using System.Text;

namespace Deepgram;

public sealed partial class MediaClient
{
    partial void PrepareTranscribeWithBytesRequest(
        HttpClient httpClient,
        HttpRequestMessage httpRequestMessage,
        string? callback,
        V1ListenPostParametersCallbackMethod? callbackMethod,
        V1ListenPostParametersExtra? extra,
        bool? sentiment,
        V1ListenPostParametersSummarize? summarize,
        V1ListenPostParametersTag? tag,
        bool? topics,
        V1ListenPostParametersCustomTopic? customTopic,
        V1ListenPostParametersCustomTopicMode? customTopicMode,
        bool? intents,
        V1ListenPostParametersCustomIntent? customIntent,
        V1ListenPostParametersCustomIntentMode? customIntentMode,
        bool? detectEntities,
        V1ListenPostParametersDetectLanguage? detectLanguage,
        bool? diarize,
        V1ListenPostParametersDiarizeModel? diarizeModel,
        bool? dictation,
        V1ListenPostParametersEncoding? encoding,
        bool? fillerWords,
        IList<string>? keyterm,
        V1ListenPostParametersKeywords? keywords,
        string? language,
        bool? measurements,
        V1ListenPostParametersModel? model,
        bool? multichannel,
        bool? numerals,
        bool? paragraphs,
        bool? profanityFilter,
        bool? punctuate,
        V1ListenPostParametersRedact? redact,
        V1ListenPostParametersReplace? replace,
        V1ListenPostParametersSearch? search,
        bool? smartFormat,
        bool? utterances,
        double? uttSplit,
        V1ListenPostParametersVersion? version,
        bool? mipOptOut,
        byte[] request)
    {
        _ = HttpClient;

        if (httpRequestMessage.RequestUri is not { } requestUri ||
            detectLanguage is not { } detection ||
            !detection.TryPickV1ListenPostParametersDetectLanguageVariant2(out var languages) ||
            languages is null)
        {
            return;
        }

        httpRequestMessage.RequestUri = ReplaceRepeatedQueryParameter(
            requestUri,
            "detect_language",
            languages);
    }

    private static Uri ReplaceRepeatedQueryParameter(
        Uri requestUri,
        string parameterName,
        IEnumerable<string> values)
    {
        var original = requestUri.OriginalString;
        var fragmentIndex = original.IndexOf('#', StringComparison.Ordinal);
        var fragment = fragmentIndex >= 0 ? original[fragmentIndex..] : string.Empty;
        var withoutFragment = fragmentIndex >= 0 ? original[..fragmentIndex] : original;
        var queryIndex = withoutFragment.IndexOf('?', StringComparison.Ordinal);
        var path = queryIndex >= 0 ? withoutFragment[..queryIndex] : withoutFragment;
        var query = queryIndex >= 0 ? withoutFragment[(queryIndex + 1)..] : string.Empty;
        var encodedName = Uri.EscapeDataString(parameterName);
        var builder = new StringBuilder(path);
        var separator = '?';

        foreach (var pair in query.Split('&', StringSplitOptions.RemoveEmptyEntries))
        {
            var equalsIndex = pair.IndexOf('=', StringComparison.Ordinal);
            var name = equalsIndex >= 0 ? pair[..equalsIndex] : pair;
            if (Uri.UnescapeDataString(name).Equals(parameterName, StringComparison.Ordinal))
            {
                continue;
            }

            builder.Append(separator).Append(pair);
            separator = '&';
        }

        foreach (var value in values.Where(static value => !string.IsNullOrWhiteSpace(value)))
        {
            builder
                .Append(separator)
                .Append(encodedName)
                .Append('=')
                .Append(Uri.EscapeDataString(value));
            separator = '&';
        }

        builder.Append(fragment);
        return new Uri(
            builder.ToString(),
            requestUri.IsAbsoluteUri ? UriKind.Absolute : UriKind.Relative);
    }
}
