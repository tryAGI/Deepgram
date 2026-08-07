#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class ManageV1ModelsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"manage-v1-models", @"manage > v1 > models endpoint commands.");
                         command.Subcommands.Add(ManageV1ModelsGetCommandApiCommand.Create());
                         command.Subcommands.Add(ManageV1ModelsListCommandApiCommand.Create());
        return command;
    }
}