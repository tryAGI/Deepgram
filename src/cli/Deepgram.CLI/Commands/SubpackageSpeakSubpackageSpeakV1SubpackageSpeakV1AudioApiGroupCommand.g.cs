#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class SubpackageSpeakSubpackageSpeakV1SubpackageSpeakV1AudioApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"subpackage-speak-subpackage-speak-v1-subpackage-speak-v1-audio", @"subpackage_speak.subpackage_speak/v1.subpackage_speak/v1/audio endpoint commands.");
                         command.Subcommands.Add(SubpackageSpeakSubpackageSpeakV1SubpackageSpeakV1AudioGenerateCommandApiCommand.Create());
        return command;
    }
}