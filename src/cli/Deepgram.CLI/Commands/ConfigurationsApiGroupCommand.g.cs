#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class ConfigurationsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"configurations", @"configurations endpoint commands.");
                         command.Subcommands.Add(ConfigurationsCreateCommandApiCommand.Create());
                         command.Subcommands.Add(ConfigurationsDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(ConfigurationsGetCommandApiCommand.Create());
                         command.Subcommands.Add(ConfigurationsListCommandApiCommand.Create());
                         command.Subcommands.Add(ConfigurationsUpdateCommandApiCommand.Create());
        return command;
    }
}