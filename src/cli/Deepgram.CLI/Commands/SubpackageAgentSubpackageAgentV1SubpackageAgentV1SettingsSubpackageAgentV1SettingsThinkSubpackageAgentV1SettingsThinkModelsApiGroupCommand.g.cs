#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class SubpackageAgentSubpackageAgentV1SubpackageAgentV1SettingsSubpackageAgentV1SettingsThinkSubpackageAgentV1SettingsThinkModelsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"subpackage-agent-subpackage-agent-v1-subpackage-agent-v1-settings-subpackage-agent-v1-settings-think-subpackage-agent-v1-settings-think-models", @"subpackage_agent.subpackage_agent/v1.subpackage_agent/v1/settings.subpackage_agent/v1/settings/think.subpackage_agent/v1/settings/think/models endpoint commands.");
                         command.Subcommands.Add(SubpackageAgentSubpackageAgentV1SubpackageAgentV1SettingsSubpackageAgentV1SettingsThinkSubpackageAgentV1SettingsThinkModelsListCommandApiCommand.Create());
        return command;
    }
}