#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class ManageV1ProjectsRequestsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"manage-v1-projects-requests", @"manage > v1 > projects > requests endpoint commands.");
                         command.Subcommands.Add(ManageV1ProjectsRequestsGetCommandApiCommand.Create());
                         command.Subcommands.Add(ManageV1ProjectsRequestsListCommandApiCommand.Create());
        return command;
    }
}