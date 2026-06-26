using System.Reflection;
using Microsoft.Extensions.AI;

namespace Deepgram.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void SpeechToTextFluxOptions_BuildRepeatedListenV2QueryParameters()
    {
        var options = new SpeechToTextOptions
        {
            SpeechLanguage = "en",
            AdditionalProperties = new AdditionalPropertiesDictionary
            {
                [DeepgramSpeechToTextPropertyNames.LanguageHint] = new[] { "en", "ru" },
                [DeepgramSpeechToTextPropertyNames.Keyterm] = new[] { "Advantage", "tryAGI" },
                [DeepgramSpeechToTextPropertyNames.Encoding] = Realtime.ListenV2Encoding.Linear16,
                [DeepgramSpeechToTextPropertyNames.SampleRate] = 16000,
                [DeepgramSpeechToTextPropertyNames.EotThreshold] = 0.7,
                [DeepgramSpeechToTextPropertyNames.EagerEotThreshold] = 0.5,
                [DeepgramSpeechToTextPropertyNames.EotTimeoutMs] = 1200,
                [DeepgramSpeechToTextPropertyNames.ProfanityFilter] = true,
            },
        };

        var uri = BuildListenV2StreamingUriForTest(options, Realtime.ListenV2Model.FluxGeneralMulti);
        var query = ParseQuery(uri);

        query.Should().Contain(("model", DeepgramClient.FluxGeneralMultilingualModelId));
        query.Where(static parameter => parameter.Name == DeepgramSpeechToTextPropertyNames.LanguageHint)
            .Select(static parameter => parameter.Value)
            .Should().Equal("en", "ru");
        query.Where(static parameter => parameter.Name == DeepgramSpeechToTextPropertyNames.Keyterm)
            .Select(static parameter => parameter.Value)
            .Should().Equal("Advantage", "tryAGI");
        query.Should().Contain((DeepgramSpeechToTextPropertyNames.Encoding, "linear16"));
        query.Should().Contain((DeepgramSpeechToTextPropertyNames.SampleRate, "16000"));
        query.Should().Contain((DeepgramSpeechToTextPropertyNames.EotThreshold, "0.7"));
        query.Should().Contain((DeepgramSpeechToTextPropertyNames.EagerEotThreshold, "0.5"));
        query.Should().Contain((DeepgramSpeechToTextPropertyNames.EotTimeoutMs, "1200"));
        query.Should().Contain((DeepgramSpeechToTextPropertyNames.ProfanityFilter, "true"));
    }

    private static Uri BuildListenV2StreamingUriForTest(
        SpeechToTextOptions options,
        Realtime.ListenV2Model model)
    {
        var method = typeof(DeepgramClient).GetMethod(
            "BuildListenV2StreamingUri",
            BindingFlags.NonPublic | BindingFlags.Static);

        method.Should().NotBeNull();
        var uri = method!.Invoke(null, new object?[] { options, model }) as Uri;
        uri.Should().NotBeNull();
        return uri!;
    }

    private static IReadOnlyList<(string Name, string Value)> ParseQuery(Uri uri)
    {
        return uri.Query
            .TrimStart('?')
            .Split('&', StringSplitOptions.RemoveEmptyEntries)
            .Select(static parameter =>
            {
                var parts = parameter.Split('=', 2);
                return (
                    Name: Uri.UnescapeDataString(parts[0]),
                    Value: parts.Length == 2 ? Uri.UnescapeDataString(parts[1]) : string.Empty);
            })
            .ToArray();
    }
}
