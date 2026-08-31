using System.Net;
using System.Net.Http.Headers;

namespace Deepgram.IntegrationTests;

[TestClass]
public sealed class AuthenticationTests
{
    [TestMethod]
    public async Task ProjectsList_UsesDeepgramTokenAuthorization()
    {
        var handler = new RecordingHandler();
        using var httpClient = new HttpClient(handler);
        using var client = new DeepgramClient("test-api-key", httpClient, disposeHttpClient: false);
        client.Options.Retry.MaxAttempts = 1;

        var response = await client.Projects.ListAsync();

        response.Projects.Should().BeEmpty();
        handler.RequestUri.Should().Be(new Uri("https://api.deepgram.com/v1/projects"));
        handler.Authorization.Should().Be(new AuthenticationHeaderValue("Token", "test-api-key"));
    }

    private sealed class RecordingHandler : HttpMessageHandler
    {
        public Uri? RequestUri { get; private set; }

        public AuthenticationHeaderValue? Authorization { get; private set; }

        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            RequestUri = request.RequestUri;
            Authorization = request.Headers.Authorization;

            return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("{\"projects\":[]}"),
            });
        }
    }
}
