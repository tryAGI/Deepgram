#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class ManageV1ProjectsBillingFieldsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"manage-v1-projects-billing-fields", @"manage > v1 > projects > billing > fields endpoint commands.");
                         command.Subcommands.Add(ManageV1ProjectsBillingFieldsListCommandApiCommand.Create());
        return command;
    }
}