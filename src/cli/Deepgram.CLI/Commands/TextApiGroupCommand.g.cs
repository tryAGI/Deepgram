#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static partial class TextApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"text", @"text endpoint commands.");
                         command.Subcommands.Add(TextAnalyzeCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}