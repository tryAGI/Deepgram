#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class SpeakV1AudioApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"speak-v1-audio", @"speak > v1 > audio endpoint commands.");
                         command.Subcommands.Add(SpeakV1AudioGenerateCommandApiCommand.Create());
        return command;
    }
}