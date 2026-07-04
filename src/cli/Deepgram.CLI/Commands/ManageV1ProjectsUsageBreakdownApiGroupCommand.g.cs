#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class ManageV1ProjectsUsageBreakdownApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"manage-v1-projects-usage-breakdown", @"manage > v1 > projects > usage > breakdown endpoint commands.");
                         command.Subcommands.Add(ManageV1ProjectsUsageBreakdownGetCommandApiCommand.Create());
        return command;
    }
}