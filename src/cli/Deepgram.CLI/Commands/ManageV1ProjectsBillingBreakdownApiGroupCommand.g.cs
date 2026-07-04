#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class ManageV1ProjectsBillingBreakdownApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"manage-v1-projects-billing-breakdown", @"manage > v1 > projects > billing > breakdown endpoint commands.");
                         command.Subcommands.Add(ManageV1ProjectsBillingBreakdownListCommandApiCommand.Create());
        return command;
    }
}