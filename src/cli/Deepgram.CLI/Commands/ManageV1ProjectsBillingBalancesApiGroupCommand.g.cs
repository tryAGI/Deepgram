#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class ManageV1ProjectsBillingBalancesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"manage-v1-projects-billing-balances", @"manage > v1 > projects > billing > balances endpoint commands.");
                         command.Subcommands.Add(ManageV1ProjectsBillingBalancesGetCommandApiCommand.Create());
                         command.Subcommands.Add(ManageV1ProjectsBillingBalancesListCommandApiCommand.Create());
        return command;
    }
}