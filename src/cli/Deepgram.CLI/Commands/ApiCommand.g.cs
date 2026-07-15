#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class ApiCommand
{
    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(AgentV1SettingsThinkModelsApiGroupCommand.Create());
                         command.Subcommands.Add(AuthV1TokensApiGroupCommand.Create());
                         command.Subcommands.Add(ListenV1MediaApiGroupCommand.Create());
                         command.Subcommands.Add(ManageV1ModelsApiGroupCommand.Create());
                         command.Subcommands.Add(ManageV1ProjectsApiGroupCommand.Create());
                         command.Subcommands.Add(ManageV1ProjectsBillingBalancesApiGroupCommand.Create());
                         command.Subcommands.Add(ManageV1ProjectsBillingBreakdownApiGroupCommand.Create());
                         command.Subcommands.Add(ManageV1ProjectsBillingFieldsApiGroupCommand.Create());
                         command.Subcommands.Add(ManageV1ProjectsBillingPurchasesApiGroupCommand.Create());
                         command.Subcommands.Add(ManageV1ProjectsKeysApiGroupCommand.Create());
                         command.Subcommands.Add(ManageV1ProjectsMembersApiGroupCommand.Create());
                         command.Subcommands.Add(ManageV1ProjectsMembersInvitesApiGroupCommand.Create());
                         command.Subcommands.Add(ManageV1ProjectsMembersScopesApiGroupCommand.Create());
                         command.Subcommands.Add(ManageV1ProjectsModelsApiGroupCommand.Create());
                         command.Subcommands.Add(ManageV1ProjectsRequestsApiGroupCommand.Create());
                         command.Subcommands.Add(ManageV1ProjectsUsageApiGroupCommand.Create());
                         command.Subcommands.Add(ManageV1ProjectsUsageBreakdownApiGroupCommand.Create());
                         command.Subcommands.Add(ManageV1ProjectsUsageFieldsApiGroupCommand.Create());
                         command.Subcommands.Add(ReadV1TextApiGroupCommand.Create());
                         command.Subcommands.Add(SelfHostedV1DistributionCredentialsApiGroupCommand.Create());
                         command.Subcommands.Add(SpeakV1AudioApiGroupCommand.Create());
                         command.Subcommands.Add(SpeakV2AudioApiGroupCommand.Create());
                         command.Subcommands.Add(VoiceAgentConfigurationsApiGroupCommand.Create());
                         command.Subcommands.Add(VoiceAgentVariablesApiGroupCommand.Create());
        return command;
    }
}