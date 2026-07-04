#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class ManageV1ProjectsModelsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"manage-v1-projects-models", @"manage > v1 > projects > models endpoint commands.");
                         command.Subcommands.Add(ManageV1ProjectsModelsGetCommandApiCommand.Create());
                         command.Subcommands.Add(ManageV1ProjectsModelsListCommandApiCommand.Create());
        return command;
    }
}