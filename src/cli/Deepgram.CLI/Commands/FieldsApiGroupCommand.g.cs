#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class FieldsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"fields", @"fields endpoint commands.");
                         command.Subcommands.Add(FieldsListCommandApiCommand.Create());
                         command.Subcommands.Add(FieldsList2CommandApiCommand.Create());
        return command;
    }
}