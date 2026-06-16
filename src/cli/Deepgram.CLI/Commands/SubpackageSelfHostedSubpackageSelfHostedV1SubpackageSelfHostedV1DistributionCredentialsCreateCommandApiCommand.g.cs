#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static partial class SubpackageSelfHostedSubpackageSelfHostedV1SubpackageSelfHostedV1DistributionCredentialsCreateCommandApiCommand
{
    private static Argument<string> ProjectId { get; } = new(
        name: @"project-id")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<global::Deepgram.V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems>?> Scopes { get; } = new(
        name: @"--scopes")
    {
        Description = @"List of permission scopes for the credentials",
    };

    private static Option<global::Deepgram.V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider?> Provider { get; } = new(
        name: @"--provider")
    {
        Description = @"The provider of the distribution service",
    };

    private static Option<string?> Comment { get; } = new(
        name: @"--comment")
    {
        Description = @"Optional comment about the credentials",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::Deepgram.CreateProjectDistributionCredentialsV1Response value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Deepgram.CreateProjectDistributionCredentialsV1Response value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create", @"Create a Project Self-Hosted Distribution Credential
Creates a set of distribution credentials for the specified project");
                        command.Arguments.Add(ProjectId);
                        command.Options.Add(Scopes);
                        command.Options.Add(Provider);
                        command.Options.Add(Comment);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Deepgram.CreateProjectDistributionCredentialsV1Request>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Deepgram.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var projectId = parseResult.GetRequiredValue(ProjectId);
                        var scopes = parseResult.GetValue(Scopes);
                        var provider = parseResult.GetValue(Provider);
                        var comment = CliRuntime.WasSpecified(parseResult, Comment) ? parseResult.GetValue(Comment) : (__requestBase is { } __CommentBaseValue ? __CommentBaseValue.Comment : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.SubpackageSelfHostedSubpackageSelfHostedV1SubpackageSelfHostedV1DistributionCredentials.CreateAsync(
                                    projectId: projectId,
                                    scopes: scopes,
                                    provider: provider,
                                    comment: comment,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Deepgram.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}