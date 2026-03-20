/*
order: 20
title: Speech To Text Client Get Text Async
slug: speech-to-text-client-get-text-async
*/

using Microsoft.Extensions.AI;

namespace Deepgram.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task SpeechToTextClient_GetTextAsync()
    {
        using var client = GetAuthenticatedClient();
        ISpeechToTextClient speechClient = client;

        //// Transcribe audio using the MEAI ISpeechToTextClient interface.
        //// Deepgram requires an audio URL via RawRepresentationFactory.
        using var dummyStream = new MemoryStream();
        var response = await speechClient.GetTextAsync(dummyStream, new SpeechToTextOptions
        {
            ModelId = "nova-3",
            RawRepresentationFactory = _ => new ListenV1RequestUrl
            {
                Url = "https://dpgr.am/spacewalk.wav",
            },
        });

        Console.WriteLine($"Text: {response.Text}");

        response.Text.Should().NotBeNullOrEmpty();
        response.RawRepresentation.Should().NotBeNull();
        response.ResponseId.Should().NotBeNullOrEmpty();
    }
}
