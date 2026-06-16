#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class SubpackageVoiceAgentSubpackageVoiceAgentConfigurationsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"subpackage-voice-agent-subpackage-voice-agent-configurations", @"subpackage_voiceAgent.subpackage_voiceAgent/configurations endpoint commands.");
                         command.Subcommands.Add(SubpackageVoiceAgentSubpackageVoiceAgentConfigurationsCreateCommandApiCommand.Create());
                         command.Subcommands.Add(SubpackageVoiceAgentSubpackageVoiceAgentConfigurationsDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(SubpackageVoiceAgentSubpackageVoiceAgentConfigurationsGetCommandApiCommand.Create());
                         command.Subcommands.Add(SubpackageVoiceAgentSubpackageVoiceAgentConfigurationsListCommandApiCommand.Create());
                         command.Subcommands.Add(SubpackageVoiceAgentSubpackageVoiceAgentConfigurationsUpdateCommandApiCommand.Create());
        return command;
    }
}