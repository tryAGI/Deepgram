using Deepgram.Realtime;

namespace Deepgram.IntegrationTests;

[TestClass]
public sealed class RealtimeTranscriptionSessionTests
{
    [TestMethod]
    public void BuildListenV1Uri_UsesWireSafeBooleansAndLanguageFallback()
    {
        var uri = DeepgramRealtimeTranscription.BuildListenV1Uri(new()
        {
            ModelId = DeepgramClient.Nova3ModelId,
            SampleRate = 24_000,
            Language = "multi",
            LanguageHints = ["ru", "en"],
            Keyterms = ["Codex", "Кодекс"],
        });
        var query = Uri.UnescapeDataString(uri.Query);

        uri.AbsolutePath.Should().Be("/v1/listen");
        query.Should().Contain("model=nova-3");
        query.Should().Contain("sample_rate=24000");
        query.Should().Contain("language=ru");
        query.Should().Contain("interim_results=true");
        query.Should().Contain("punctuate=true");
        query.Should().Contain("smart_format=true");
        query.Should().Contain("keyterm=Codex");
        query.Should().Contain("keyterm=Кодекс");
    }

    [TestMethod]
    public void BuildListenV2Uri_CarriesRepeatedHintsAndTurnOptions()
    {
        var uri = DeepgramRealtimeTranscription.BuildListenV2Uri(new()
        {
            ModelId = DeepgramClient.FluxGeneralMultilingualModelId,
            LanguageHints = ["ru", "en"],
            Keyterms = ["Codex"],
            EagerEotThreshold = 0.7,
            EotTimeoutMilliseconds = 100,
        });
        var query = Uri.UnescapeDataString(uri.Query);

        query.Should().Contain("model=flux-general-multi");
        query.Should().Contain("language_hint=ru");
        query.Should().Contain("language_hint=en");
        query.Should().Contain("keyterm=Codex");
        query.Should().Contain("eager_eot_threshold=0.7");
        query.Should().Contain("eot_timeout_ms=500");
    }

    [TestMethod]
    public void ResolveListenVersion_UsesFluxForV2AndOtherModelsForV1()
    {
        DeepgramRealtimeTranscription.ResolveListenVersion(new()
        {
            ModelId = DeepgramClient.FluxGeneralMultilingualModelId,
        }).Should().Be(DeepgramRealtimeListenVersion.ListenV2);

        DeepgramRealtimeTranscription.ResolveListenVersion(new()
        {
            ModelId = DeepgramClient.Nova3ModelId,
        }).Should().Be(DeepgramRealtimeListenVersion.ListenV1);
    }

    [TestMethod]
    public void ListenV1Assembler_FlushesProviderFinalChunksAtStreamEnd()
    {
        var assembler = new DeepgramListenV1TranscriptAssembler();

        var providerFinal = assembler.MapServerEvent(CreateResult("hello", isFinal: true, speechFinal: false));

        providerFinal.Should().NotBeNull();
        providerFinal!.IsFinal.Should().BeFalse();
        providerFinal.Text.Should().Be("hello");
        assembler.PendingChunkCount.Should().Be(1);

        var flushed = assembler.FlushPending();
        flushed.Should().NotBeNull();
        flushed!.IsFinal.Should().BeTrue();
        flushed.Text.Should().Be("hello");
        flushed.EventType.Should().Be("StreamEndFlush");
        assembler.PendingChunkCount.Should().Be(0);
    }

    [TestMethod]
    public void ListenV1Assembler_JoinsFinalChunksUntilSpeechFinal()
    {
        var assembler = new DeepgramListenV1TranscriptAssembler();
        assembler.MapServerEvent(CreateResult("hello", isFinal: true, speechFinal: false));

        var completed = assembler.MapServerEvent(CreateResult("world", isFinal: true, speechFinal: true));

        completed.Should().NotBeNull();
        completed!.IsFinal.Should().BeTrue();
        completed.Text.Should().Be("hello world");
        completed.EventType.Should().Be("ResultsSpeechFinal");
        assembler.PendingChunkCount.Should().Be(0);
    }

    [TestMethod]
    public void MapListenV2ServerEvent_NormalizesPartialFinalAndFatalEvents()
    {
        var requestId = Guid.NewGuid();
        var partial = DeepgramRealtimeTranscription.MapListenV2ServerEvent(
            new ListenV2ServerEvent(new ListenV2ListenV2TurnInfo
            {
                RequestId = requestId,
                SequenceId = 1,
                Event = ChannelsListenV2MessagesListenV2TurnInfoEvent.Update,
                TurnIndex = 0,
                AudioWindowStart = "0",
                AudioWindowEnd = "0.6",
                Transcript = "hello",
                Words = [],
                EndOfTurnConfidence = "0.2",
            }));
        var final = DeepgramRealtimeTranscription.MapListenV2ServerEvent(
            new ListenV2ServerEvent(new ListenV2ListenV2TurnInfo
            {
                RequestId = requestId,
                SequenceId = 2,
                Event = ChannelsListenV2MessagesListenV2TurnInfoEvent.EndOfTurn,
                TurnIndex = 0,
                AudioWindowStart = "0",
                AudioWindowEnd = "1.2",
                Transcript = "hello world",
                Words = [],
                EndOfTurnConfidence = "0.95",
            }));
        var fatal = DeepgramRealtimeTranscription.MapListenV2ServerEvent(
            new ListenV2ServerEvent(new ListenV2ListenV2FatalError
            {
                SequenceId = 3,
                Code = "INVALID_REQUEST",
                Description = "bad model",
            }));

        partial.Should().NotBeNull();
        partial!.Text.Should().Be("hello");
        partial.IsFinal.Should().BeFalse();
        partial.ProviderSegmentId.Should().Be($"turn:{requestId}:0:1");
        final.Should().NotBeNull();
        final!.IsFinal.Should().BeTrue();
        fatal.Should().NotBeNull();
        fatal!.Error.Should().Be("INVALID_REQUEST: bad model");
    }

    private static ListenV1ServerEvent CreateResult(string transcript, bool isFinal, bool speechFinal) =>
        new ListenV1ListenV1Results
        {
            Type = ChannelsListenV1MessagesListenV1ResultsType.Results,
            ChannelIndex = [0, 1],
            Duration = 0.5,
            Start = 1.25,
            IsFinal = isFinal,
            SpeechFinal = speechFinal,
            Channel = new()
            {
                Alternatives =
                [
                    new()
                    {
                        Transcript = transcript,
                        Confidence = 0.99,
                        Words = [],
                    },
                ],
            },
            Metadata = new()
            {
                RequestId = "request-1",
                ModelUuid = "model-1",
                ModelInfo = new()
                {
                    Name = "nova-3",
                    Version = "1",
                    Arch = "nova",
                },
            },
        };
}
