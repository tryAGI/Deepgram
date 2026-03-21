/*
order: 50
title: Speech To Text Client Get Streaming Text Async
slug: speech-to-text-client-get-streaming-text-async

Real-time streaming speech-to-text via the MEAI ISpeechToTextClient interface.
Uses typed ConnectAsync internally for model and language selection.
*/

using Microsoft.Extensions.AI;

namespace Deepgram.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task SpeechToTextClient_GetStreamingTextAsync()
    {
        using var client = GetAuthenticatedClient();
        ISpeechToTextClient speechClient = client;

        //// Download a short audio sample to use as streaming input.
        using var httpClient = new HttpClient();
        var audioBytes = await httpClient.GetByteArrayAsync(
            "https://dpgr.am/spacewalk.wav");
        using var audioStream = new MemoryStream(audioBytes);

        //// Stream audio through the MEAI ISpeechToTextClient interface.
        //// This uses typed ConnectAsync internally with model and language params.
        var updates = new List<SpeechToTextResponseUpdate>();
        await foreach (var update in speechClient.GetStreamingTextAsync(
            audioStream,
            new SpeechToTextOptions
            {
                ModelId = "nova-3",
                SpeechLanguage = "en",
            }))
        {
            updates.Add(update);

            if (update.Kind == SpeechToTextResponseUpdateKind.TextUpdated)
            {
                Console.WriteLine($"Final: {update.Text}");
            }
        }

        //// Verify we received session events and transcription results.
        updates.Should().NotBeEmpty();
        updates.Should().Contain(u => u.Kind == SpeechToTextResponseUpdateKind.SessionOpen);
        updates.Should().Contain(u => u.Kind == SpeechToTextResponseUpdateKind.TextUpdated);
        updates.Should().Contain(u => u.Kind == SpeechToTextResponseUpdateKind.SessionClose);

        var finalTranscripts = updates
            .Where(u => u.Kind == SpeechToTextResponseUpdateKind.TextUpdated && u.Text is { Length: > 0 })
            .Select(u => u.Text!)
            .ToList();
        finalTranscripts.Should().NotBeEmpty();
        Console.WriteLine($"Total final transcripts: {finalTranscripts.Count}");
    }
}
