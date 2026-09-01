using System.Net;
using System.Net.Http.Headers;
using System.Text.Json;

namespace Deepgram.IntegrationTests;

[TestClass]
public sealed class TextToSpeechTests
{
    [TestMethod]
    public async Task GenerateAsStream_UsesJsonBodyTokenAuthAndReturnsBinaryAudio()
    {
        var handler = new RecordingHandler([1, 2, 3, 4]);
        using var httpClient = new HttpClient(handler);
        using var client = new DeepgramClient("test-api-key", httpClient, disposeHttpClient: false);
        client.Options.Retry.MaxAttempts = 1;

        await using var response = await client.Audio.GenerateAsStreamAsync(
            request: new SpeakV1Request("Hello from the generated SDK."),
            container: V1SpeakPostParametersContainer0.None,
            encoding: V1SpeakPostParametersEncoding0.Linear16,
            model: V1SpeakPostParametersModel.Aura2ApolloEn,
            sampleRate: V1SpeakPostParametersSampleRate0.x24000,
            speed: 1.1,
            cancellationToken: TestContext.CancellationToken);
        using var audio = new MemoryStream();
        await response.CopyToAsync(audio, TestContext.CancellationToken);

        audio.ToArray().Should().Equal(1, 2, 3, 4);
        handler.Method.Should().Be(HttpMethod.Post);
        handler.Authorization.Should().Be(new AuthenticationHeaderValue("Token", "test-api-key"));
        handler.ContentType?.MediaType.Should().Be("application/json");
        handler.RequestUri.Should().NotBeNull();
        handler.RequestUri!.AbsolutePath.Should().Be("/v1/speak");
        handler.RequestUri.Query.Should().Contain("container=none");
        handler.RequestUri.Query.Should().Contain("encoding=linear16");
        handler.RequestUri.Query.Should().Contain("model=aura-2-apollo-en");
        handler.RequestUri.Query.Should().Contain("sample_rate=24000");
        handler.RequestUri.Query.Should().Contain("speed=1.1");

        using var requestBody = JsonDocument.Parse(handler.Body);
        requestBody.RootElement.GetProperty("text").GetString()
            .Should().Be("Hello from the generated SDK.");
    }

    public TestContext TestContext { get; set; } = null!;

    private sealed class RecordingHandler(byte[] responseBody) : HttpMessageHandler
    {
        public HttpMethod? Method { get; private set; }

        public Uri? RequestUri { get; private set; }

        public AuthenticationHeaderValue? Authorization { get; private set; }

        public MediaTypeHeaderValue? ContentType { get; private set; }

        public byte[] Body { get; private set; } = [];

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            Method = request.Method;
            RequestUri = request.RequestUri;
            Authorization = request.Headers.Authorization;
            ContentType = request.Content?.Headers.ContentType;
            Body = request.Content is null
                ? []
                : await request.Content.ReadAsByteArrayAsync(cancellationToken);

            var content = new ByteArrayContent(responseBody);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = content,
            };
        }
    }
}
