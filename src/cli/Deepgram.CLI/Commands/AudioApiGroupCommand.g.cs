#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static partial class AudioApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"audio", @"audio endpoint commands.");
                         command.Subcommands.Add(AudioGenerateCommandApiCommand.Create());
                         command.Subcommands.Add(AudioGenerate2CommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}