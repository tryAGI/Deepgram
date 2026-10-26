using Deepgram.Realtime;
using System.Text.Json;

namespace Deepgram.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void AgentAliasesFollowDiscriminatedEventNames()
    {
        var update = AgentV1ServerEvent.FromJson("""{"type":"PromptUpdated"}""")!.Value;

        update.IsPromptUpdated.Should().BeTrue();
        update.AgentV1PromptUpdated.Should().BeSameAs(update.PromptUpdated);
        update.AgentV1Welcome.Should().BeNull();
    }

    [TestMethod]
    public void ListenV2AliasesAndDispatchFollowDiscriminatedEventNames()
    {
        var failure = ListenV2ServerEvent.FromJson(
            """{"type":"ConfigureFailure","request_id":"00000000-0000-0000-0000-000000000001","sequence_id":1,"description":"invalid settings"}""")!.Value;

        failure.TryPickConfigureFailure(out var details).Should().BeTrue();
        failure.ListenV2ConfigureFailure.Should().BeSameAs(details);
        failure.ListenV2TurnInfo.Should().BeNull();
        failure.TryPickTurnInfo(out _).Should().BeFalse();
    }
    [TestMethod]
    public void AgentRejectsUnknownTypeInsteadOfAcceptingAnEmptyNestedUnion()
    {
        Assert.ThrowsExactly<JsonException>(() =>
            AgentV1ServerEvent.FromJson("""{"type":"not-an-event"}"""));
    }

}
