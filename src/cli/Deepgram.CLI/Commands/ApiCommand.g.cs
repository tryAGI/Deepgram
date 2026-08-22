#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class ApiCommand
{
    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(AudioApiGroupCommand.Create());
                         command.Subcommands.Add(BalancesApiGroupCommand.Create());
                         command.Subcommands.Add(BreakdownApiGroupCommand.Create());
                         command.Subcommands.Add(ConfigurationsApiGroupCommand.Create());
                         command.Subcommands.Add(DistributionCredentialsApiGroupCommand.Create());
                         command.Subcommands.Add(FieldsApiGroupCommand.Create());
                         command.Subcommands.Add(InvitesApiGroupCommand.Create());
                         command.Subcommands.Add(KeysApiGroupCommand.Create());
                         command.Subcommands.Add(MediaApiGroupCommand.Create());
                         command.Subcommands.Add(MembersApiGroupCommand.Create());
                         command.Subcommands.Add(ModelsApiGroupCommand.Create());
                         command.Subcommands.Add(ProjectsApiGroupCommand.Create());
                         command.Subcommands.Add(PurchasesApiGroupCommand.Create());
                         command.Subcommands.Add(RequestsApiGroupCommand.Create());
                         command.Subcommands.Add(ScopesApiGroupCommand.Create());
                         command.Subcommands.Add(TextApiGroupCommand.Create());
                         command.Subcommands.Add(TokensApiGroupCommand.Create());
                         command.Subcommands.Add(VariablesApiGroupCommand.Create());
        return command;
    }
}