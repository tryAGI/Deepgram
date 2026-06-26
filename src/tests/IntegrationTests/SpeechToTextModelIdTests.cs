namespace Deepgram.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void SpeechToTextModelIds_MapToGeneratedRealtimeModels()
    {
        Realtime.ListenV1ModelExtensions.ToEnum(DeepgramClient.Nova3ModelId)
            .Should().Be(Realtime.ListenV1Model.Nova3);

        Realtime.ListenV2ModelExtensions.ToEnum(DeepgramClient.FluxGeneralEnglishModelId)
            .Should().Be(Realtime.ListenV2Model.FluxGeneralEn);

        Realtime.ListenV2ModelExtensions.ToEnum(DeepgramClient.FluxGeneralMultilingualModelId)
            .Should().Be(Realtime.ListenV2Model.FluxGeneralMulti);
    }
}
