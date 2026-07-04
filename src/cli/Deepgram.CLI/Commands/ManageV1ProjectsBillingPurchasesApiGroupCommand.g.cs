#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class ManageV1ProjectsBillingPurchasesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"manage-v1-projects-billing-purchases", @"manage > v1 > projects > billing > purchases endpoint commands.");
                         command.Subcommands.Add(ManageV1ProjectsBillingPurchasesListCommandApiCommand.Create());
        return command;
    }
}