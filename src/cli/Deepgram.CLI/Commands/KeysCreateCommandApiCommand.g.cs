#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static partial class KeysCreateCommandApiCommand
{
    private static Argument<string> ProjectId { get; } = new(
        name: @"project-id")
    {
        Description = @"The unique identifier of the project",
    };

    private static Option<string> Comment { get; } = new(
        name: @"--comment")
    {
        Description = @"",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.IList<string>> Scopes { get; } = new(
        name: @"--scopes")
    {
        Description = @"",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Tags { get; } = new(
        name: @"--tags")
    {
        Description = @"",
    };

    private static Option<global::System.DateTime?> ExpirationDate { get; } = new(
        name: @"--expiration-date")
    {
        Description = @"",
    };

    private static Option<double?> TimeToLiveInSeconds { get; } = new(
        name: @"--time-to-live-in-seconds")
    {
        Description = @"",
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

                    private static string FormatResponse(ParseResult parseResult, global::Deepgram.CreateKeyV1Response value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Deepgram.CreateKeyV1Response value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create", @"Create a Project Key
Creates a new API key with specified settings for the project");
                        command.Arguments.Add(ProjectId);
                        command.Options.Add(Comment);
                        command.Options.Add(Scopes);
                        command.Options.Add(Tags);
                        command.Options.Add(ExpirationDate);
                        command.Options.Add(TimeToLiveInSeconds);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Deepgram.CreateKeyV1Request>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Deepgram.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var projectId = parseResult.GetRequiredValue(ProjectId);
                        var comment = parseResult.GetRequiredValue(Comment);
                        var scopes = parseResult.GetRequiredValue(Scopes);
                        var tags = CliRuntime.WasSpecified(parseResult, Tags) ? parseResult.GetValue(Tags) : (__requestBase is { } __TagsBaseValue ? __TagsBaseValue.Tags : default);
                        var expirationDate = CliRuntime.WasSpecified(parseResult, ExpirationDate) ? parseResult.GetValue(ExpirationDate) : (__requestBase is { } __ExpirationDateBaseValue ? __ExpirationDateBaseValue.ExpirationDate : default);
                        var timeToLiveInSeconds = CliRuntime.WasSpecified(parseResult, TimeToLiveInSeconds) ? parseResult.GetValue(TimeToLiveInSeconds) : (__requestBase is { } __TimeToLiveInSecondsBaseValue ? __TimeToLiveInSecondsBaseValue.TimeToLiveInSeconds : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Keys.CreateAsync(
                                    projectId: projectId,
                                    comment: comment,
                                    scopes: scopes,
                                    tags: tags,
                                    expirationDate: expirationDate,
                                    timeToLiveInSeconds: timeToLiveInSeconds,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Deepgram.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}