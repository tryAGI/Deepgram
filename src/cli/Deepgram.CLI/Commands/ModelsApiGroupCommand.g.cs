#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class ModelsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"models", @"models endpoint commands.");
                         command.Subcommands.Add(ModelsGetCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsGet2CommandApiCommand.Create());
                         command.Subcommands.Add(ModelsListCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsList2CommandApiCommand.Create());
                         command.Subcommands.Add(ModelsList3CommandApiCommand.Create());
        return command;
    }
}