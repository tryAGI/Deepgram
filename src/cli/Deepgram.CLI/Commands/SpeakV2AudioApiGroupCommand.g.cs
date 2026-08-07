#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class SpeakV2AudioApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"speak-v2-audio", @"speak > v2 > audio endpoint commands.");
                         command.Subcommands.Add(SpeakV2AudioGenerateCommandApiCommand.Create());
        return command;
    }
}