using System.Net;
using System.Net.Http.Headers;

namespace Deepgram.IntegrationTests;

[TestClass]
public sealed class UploadedTranscriptionTests
{
    [TestMethod]
    public async Task TranscribeWithBytes_UsesBinaryBodyTokenAuthAndRepeatedLanguageDetection()
    {
        var handler = new RecordingHandler();
        using var httpClient = new HttpClient(handler);
        using var client = new DeepgramClient("test-api-key", httpClient, disposeHttpClient: false);
        client.Options.Retry.MaxAttempts = 1;

        var response = await client.Media.TranscribeWithBytesAsync(
            request: [1, 2, 3, 4],
            detectLanguage: new V1ListenPostParametersDetectLanguage(
                v1ListenPostParametersDetectLanguageVariant1: null,
                v1ListenPostParametersDetectLanguageVariant2: ["ru", "en"]),
            model: "nova-3-general",
            punctuate: true,
            cancellationToken: TestContext.CancellationToken);

        response.PickListenV1AcceptedResponse().RequestId.Should().Be(Guid.Parse("11111111-1111-1111-1111-111111111111"));
        handler.Method.Should().Be(HttpMethod.Post);
        handler.Authorization.Should().Be(new AuthenticationHeaderValue("Token", "test-api-key"));
        handler.ContentType.Should().Be(new MediaTypeHeaderValue("application/octet-stream"));
        handler.Body.Should().Equal(1, 2, 3, 4);
        handler.RequestUri.Should().NotBeNull();
        handler.RequestUri!.AbsolutePath.Should().Be("/v1/listen");
        handler.RequestUri.Query.Should().Contain("model=nova-3-general");
        handler.RequestUri.Query.Should().Contain("punctuate=true");
        handler.RequestUri.Query.Should().Contain("detect_language=ru&detect_language=en");
        handler.RequestUri.Query.Should().NotContain("System.Collections");
    }

    public TestContext TestContext { get; set; } = null!;

    private sealed class RecordingHandler : HttpMessageHandler
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

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("{\"request_id\":\"11111111-1111-1111-1111-111111111111\"}"),
            };
        }
    }
}
