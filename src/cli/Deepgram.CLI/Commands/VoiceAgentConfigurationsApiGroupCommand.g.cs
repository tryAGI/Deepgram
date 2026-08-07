#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class VoiceAgentConfigurationsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"voice-agent-configurations", @"voiceAgent > configurations endpoint commands.");
                         command.Subcommands.Add(VoiceAgentConfigurationsCreateCommandApiCommand.Create());
                         command.Subcommands.Add(VoiceAgentConfigurationsDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(VoiceAgentConfigurationsGetCommandApiCommand.Create());
                         command.Subcommands.Add(VoiceAgentConfigurationsListCommandApiCommand.Create());
                         command.Subcommands.Add(VoiceAgentConfigurationsUpdateCommandApiCommand.Create());
        return command;
    }
}