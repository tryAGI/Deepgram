/*
order: 40
title: Realtime Speech To Text
slug: realtime-speech-to-text

Real-time speech-to-text streaming using the typed ConnectAsync with query parameters.
*/

namespace Deepgram.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_RealtimeSpeechToText()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("DEEPGRAM_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("DEEPGRAM_API_KEY environment variable is not found.");

        //// Create a realtime ListenV1 client and authenticate.
        await using var realtimeClient = new Realtime.DeepgramListenV1RealtimeClient();
        realtimeClient.AuthorizeUsingToken(apiKey);

        //// Connect with typed query parameters — model, interim results, and language.
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));
        await realtimeClient.ConnectAsync(
            model: Realtime.ListenV1Model.Nova3,
            interimResults: Realtime.ListenV1InterimResults.True,
            language: "en",
            cancellationToken: cts.Token);

        realtimeClient.IsConnected.Should().BeTrue();

        //// Download a short audio sample and send it as binary frames.
        using var httpClient = new HttpClient();
        var audioBytes = await httpClient.GetByteArrayAsync(
            "https://dpgr.am/spacewalk.wav", cts.Token);

        // Send audio in 8KB chunks.
        const int chunkSize = 8192;
        for (var offset = 0; offset < audioBytes.Length; offset += chunkSize)
        {
            var length = Math.Min(chunkSize, audioBytes.Length - offset);
            await realtimeClient.SendAsync(
                new ArraySegment<byte>(audioBytes, offset, length),
                System.Net.WebSockets.WebSocketMessageType.Binary,
                endOfMessage: true,
                cts.Token);
        }

        //// Signal end of audio and close the stream.
        await realtimeClient.SendListenV1CloseStreamAsync(
            new Realtime.ListenV1ControlMessage
            {
                Type = Realtime.ListenV1ControlMessageType.CloseStream,
            },
            cts.Token);

        //// Receive transcription events until the connection closes.
        var transcripts = new List<string>();
        string? responseId = null;

        await foreach (var serverEvent in realtimeClient
            .ReceiveUpdatesAsync(cts.Token))
        {
            if (serverEvent.IsMetadata && serverEvent.Metadata is { } metadata)
            {
                responseId = metadata.RequestId.ToString();
                Console.WriteLine($"Session started: {responseId}");
            }
            else if (serverEvent.IsResults && serverEvent.Results is { } results)
            {
                if (results.IsFinal == true &&
                    results.Channel?.Alternatives is { Count: > 0 } alts &&
                    alts[0].Transcript is { Length: > 0 } transcript)
                {
                    transcripts.Add(transcript);
                    Console.WriteLine($"Final: {transcript}");
                }
            }
        }

        //// Verify we received transcription results.
        responseId.Should().NotBeNullOrEmpty();
        transcripts.Should().NotBeEmpty();
        transcripts[0].Should().NotBeNullOrEmpty();
        Console.WriteLine($"Total final transcripts: {transcripts.Count}");
    }
}
