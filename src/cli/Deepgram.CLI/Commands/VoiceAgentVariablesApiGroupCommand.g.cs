#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class VoiceAgentVariablesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"voice-agent-variables", @"voiceAgent > variables endpoint commands.");
                         command.Subcommands.Add(VoiceAgentVariablesCreateCommandApiCommand.Create());
                         command.Subcommands.Add(VoiceAgentVariablesDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(VoiceAgentVariablesGetCommandApiCommand.Create());
                         command.Subcommands.Add(VoiceAgentVariablesListCommandApiCommand.Create());
                         command.Subcommands.Add(VoiceAgentVariablesUpdateCommandApiCommand.Create());
        return command;
    }
}