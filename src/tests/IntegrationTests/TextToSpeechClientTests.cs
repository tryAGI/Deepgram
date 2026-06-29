#nullable enable
#pragma warning disable MEAI001

using System.Net;
using System.Text.Json;
using Microsoft.Extensions.AI;

namespace Deepgram.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void TextToSpeechClient_GetService_Metadata()
    {
        using var client = new DeepgramClient("test-api-key");
        Microsoft.Extensions.AI.ITextToSpeechClient ttsClient = client;

        var metadata = ttsClient.GetService<TextToSpeechClientMetadata>();

        metadata.Should().NotBeNull();
        metadata!.ProviderName.Should().Be("deepgram");
        metadata.DefaultModelId.Should().Be("aura-2-asteria-en");
        metadata.ProviderUri.Should().NotBeNull();
        ttsClient.GetService<DeepgramClient>().Should().BeSameAs(client);
    }

    [TestMethod]
    public async Task TextToSpeechClient_MapsOptionsToSpeakRequest()
    {
        var handler = new StaticResponseHandler(HttpStatusCode.OK, [1, 2, 3], "audio/mpeg");
        using var client = new DeepgramClient(
            "test-api-key",
            new HttpClient(handler)
            {
                BaseAddress = new Uri(DeepgramClient.DefaultBaseUrl),
            });
        Microsoft.Extensions.AI.ITextToSpeechClient ttsClient = client;
        SpeakV1Request? capturedRequest = null;

        var response = await ttsClient.GetAudioAsync(
            "Hello from Deepgram.",
            new TextToSpeechOptions
            {
                ModelId = "aura-2-andromeda-en",
                AudioFormat = "wav",
                Speed = 1.12f,
                AdditionalProperties = new()
                {
                    [DeepgramTextToSpeechPropertyNames.SampleRate] = 24000,
                    [DeepgramTextToSpeechPropertyNames.MipOptOut] = true,
                    [DeepgramTextToSpeechPropertyNames.Tag] = new[] { "agent", "tts" },
                },
                RawRepresentationFactory = _ =>
                {
                    capturedRequest = new SpeakV1Request
                    {
                        Text = string.Empty,
                    };

                    return capturedRequest;
                },
            });

        capturedRequest.Should().NotBeNull();
        capturedRequest!.Text.Should().Be("Hello from Deepgram.");

        handler.LastRequest.Should().NotBeNull();
        handler.LastRequest!.RequestUri!.AbsolutePath.Should().Be("/v1/speak");
        handler.LastRequest.Headers.Authorization!.Scheme.Should().Be("Token");
        handler.LastRequest.Headers.Authorization.Parameter.Should().Be("test-api-key");

        var query = ParseTtsQuery(handler.LastRequest.RequestUri);
        query.Should().Contain(("model", "aura-2-andromeda-en"));
        query.Should().Contain(("encoding", "linear16"));
        query.Should().Contain(("container", "wav"));
        query.Should().Contain(("sample_rate", "24000"));
        query.Should().Contain(("speed", "1.12"));
        query.Should().Contain(("mip_opt_out", "true"));
        query.Where(static parameter => parameter.Name == "tag")
            .Select(static parameter => parameter.Value)
            .Should().Equal("agent", "tts");

        response.Contents.OfType<DataContent>().Single().Data.ToArray().Should().Equal([1, 2, 3]);
        response.ModelId.Should().Be("aura-2-andromeda-en");
        response.AdditionalProperties![DeepgramTextToSpeechPropertyNames.Encoding].Should().Be("linear16");

        using var document = JsonDocument.Parse(handler.LastRequestBody!);
        document.RootElement.GetProperty("text").GetString().Should().Be("Hello from Deepgram.");
    }

    [TestMethod]
    public async Task TextToSpeechClient_StreamsAudioChunks()
    {
        var handler = new StaticResponseHandler(HttpStatusCode.OK, [1, 2, 3, 4], "audio/mpeg");
        using var client = new DeepgramClient(
            "test-api-key",
            new HttpClient(handler)
            {
                BaseAddress = new Uri(DeepgramClient.DefaultBaseUrl),
            });
        Microsoft.Extensions.AI.ITextToSpeechClient ttsClient = client;

        var updates = new List<TextToSpeechResponseUpdate>();
        await foreach (var update in ttsClient.GetStreamingAudioAsync(
            "Streaming Deepgram speech.",
            new TextToSpeechOptions
            {
                ModelId = "aura-2-asteria-en",
                AudioFormat = "mp3",
            }))
        {
            updates.Add(update);
        }

        updates.First().Kind.Should().Be(TextToSpeechResponseUpdateKind.SessionOpen);
        updates.Should().Contain(static update => update.Kind == TextToSpeechResponseUpdateKind.AudioUpdating);
        updates.Should().Contain(static update => update.Kind == TextToSpeechResponseUpdateKind.AudioUpdated);
        updates.Last().Kind.Should().Be(TextToSpeechResponseUpdateKind.SessionClose);
    }

    private static IReadOnlyList<(string Name, string Value)> ParseTtsQuery(Uri uri)
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

    private sealed class StaticResponseHandler(
        HttpStatusCode statusCode,
        byte[] responseBody,
        string mediaType) : HttpMessageHandler
    {
        public HttpRequestMessage? LastRequest { get; private set; }
        public string? LastRequestBody { get; private set; }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            LastRequest = request;
            LastRequestBody = request.Content is null
                ? null
                : await request.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            return new HttpResponseMessage(statusCode)
            {
                RequestMessage = request,
                Content = new ByteArrayContent(responseBody)
                {
                    Headers =
                    {
                        ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(mediaType),
                    },
                },
                Headers =
                {
                    { "dg-request-id", "test-request-id" },
                },
            };
        }
    }
}
