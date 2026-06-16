#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class ApiCommand
{
    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(SubpackageAgentSubpackageAgentV1SubpackageAgentV1SettingsSubpackageAgentV1SettingsThinkSubpackageAgentV1SettingsThinkModelsApiGroupCommand.Create());
                         command.Subcommands.Add(SubpackageAuthSubpackageAuthV1SubpackageAuthV1TokensApiGroupCommand.Create());
                         command.Subcommands.Add(SubpackageListenSubpackageListenV1SubpackageListenV1MediaApiGroupCommand.Create());
                         command.Subcommands.Add(SubpackageManageSubpackageManageV1SubpackageManageV1ModelsApiGroupCommand.Create());
                         command.Subcommands.Add(SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsApiGroupCommand.Create());
                         command.Subcommands.Add(SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsBillingSubpackageManageV1ProjectsBillingBalancesApiGroupCommand.Create());
                         command.Subcommands.Add(SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsBillingSubpackageManageV1ProjectsBillingBreakdownApiGroupCommand.Create());
                         command.Subcommands.Add(SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsBillingSubpackageManageV1ProjectsBillingFieldsApiGroupCommand.Create());
                         command.Subcommands.Add(SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsBillingSubpackageManageV1ProjectsBillingPurchasesApiGroupCommand.Create());
                         command.Subcommands.Add(SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsKeysApiGroupCommand.Create());
                         command.Subcommands.Add(SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsMembersApiGroupCommand.Create());
                         command.Subcommands.Add(SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsMembersSubpackageManageV1ProjectsMembersInvitesApiGroupCommand.Create());
                         command.Subcommands.Add(SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsMembersSubpackageManageV1ProjectsMembersScopesApiGroupCommand.Create());
                         command.Subcommands.Add(SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsModelsApiGroupCommand.Create());
                         command.Subcommands.Add(SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsRequestsApiGroupCommand.Create());
                         command.Subcommands.Add(SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsUsageApiGroupCommand.Create());
                         command.Subcommands.Add(SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsUsageSubpackageManageV1ProjectsUsageBreakdownApiGroupCommand.Create());
                         command.Subcommands.Add(SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsUsageSubpackageManageV1ProjectsUsageFieldsApiGroupCommand.Create());
                         command.Subcommands.Add(SubpackageReadSubpackageReadV1SubpackageReadV1TextApiGroupCommand.Create());
                         command.Subcommands.Add(SubpackageSelfHostedSubpackageSelfHostedV1SubpackageSelfHostedV1DistributionCredentialsApiGroupCommand.Create());
                         command.Subcommands.Add(SubpackageSpeakSubpackageSpeakV1SubpackageSpeakV1AudioApiGroupCommand.Create());
                         command.Subcommands.Add(SubpackageVoiceAgentSubpackageVoiceAgentConfigurationsApiGroupCommand.Create());
                         command.Subcommands.Add(SubpackageVoiceAgentSubpackageVoiceAgentVariablesApiGroupCommand.Create());
        return command;
    }
}