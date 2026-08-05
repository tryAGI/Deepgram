#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class AudioApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"audio", @"audio endpoint commands.");
                         command.Subcommands.Add(AudioGenerateCommandApiCommand.Create());
                         command.Subcommands.Add(AudioGenerate2CommandApiCommand.Create());
        return command;
    }
}