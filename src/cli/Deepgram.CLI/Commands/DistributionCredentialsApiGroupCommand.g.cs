#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class DistributionCredentialsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"distribution-credentials", @"distributionCredentials endpoint commands.");
                         command.Subcommands.Add(DistributionCredentialsCreateCommandApiCommand.Create());
                         command.Subcommands.Add(DistributionCredentialsDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(DistributionCredentialsGetCommandApiCommand.Create());
                         command.Subcommands.Add(DistributionCredentialsListCommandApiCommand.Create());
        return command;
    }
}