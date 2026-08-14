#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class TextApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"text", @"text endpoint commands.");
                         command.Subcommands.Add(TextAnalyzeCommandApiCommand.Create());
        return command;
    }
}