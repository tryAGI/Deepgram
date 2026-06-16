#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class SubpackageVoiceAgentSubpackageVoiceAgentVariablesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"subpackage-voice-agent-subpackage-voice-agent-variables", @"subpackage_voiceAgent.subpackage_voiceAgent/variables endpoint commands.");
                         command.Subcommands.Add(SubpackageVoiceAgentSubpackageVoiceAgentVariablesCreateCommandApiCommand.Create());
                         command.Subcommands.Add(SubpackageVoiceAgentSubpackageVoiceAgentVariablesDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(SubpackageVoiceAgentSubpackageVoiceAgentVariablesGetCommandApiCommand.Create());
                         command.Subcommands.Add(SubpackageVoiceAgentSubpackageVoiceAgentVariablesListCommandApiCommand.Create());
                         command.Subcommands.Add(SubpackageVoiceAgentSubpackageVoiceAgentVariablesUpdateCommandApiCommand.Create());
        return command;
    }
}