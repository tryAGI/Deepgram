#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class ProjectsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"projects", @"projects endpoint commands.");
                         command.Subcommands.Add(ProjectsDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectsGetCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectsLeaveCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectsListCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectsUpdateCommandApiCommand.Create());
        return command;
    }
}