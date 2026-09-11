namespace Deepgram.IntegrationTests;

[TestClass]
public sealed class TextToSpeechVoiceCatalogTests
{
    [TestMethod]
    public void All_TracksEveryGeneratedVoiceWithoutDuplicateIds()
    {
        DeepgramTextToSpeechVoices.All.Should().HaveCount(Enum.GetValues<V1SpeakPostParametersModel>().Length);
        DeepgramTextToSpeechVoices.All.Select(voice => voice.Id)
            .Should().OnlyHaveUniqueItems();
        DeepgramTextToSpeechVoices.All.Should().Contain(voice =>
            voice.Id == "aura-2-thalia-en" &&
            voice.Name == "Thalia" &&
            voice.Language == "en" &&
            voice.ModelFamily == "aura-2");
    }
}
