namespace Deepgram.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static DeepgramClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("DEEPGRAM_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("DEEPGRAM_API_KEY environment variable is not found.");

        var client = new DeepgramClient(apiKey);
        
        return client;
    }
}
