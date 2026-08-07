#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static partial class VoiceAgentVariablesCreateCommandApiCommand
{
    private static Argument<string> ProjectId { get; } = new(
        name: @"project-id")
    {
        Description = @"The unique identifier of the project",
    };

    private static Option<string> Key { get; } = new(
        name: @"--key")
    {
        Description = @"The variable name, following the DG_<VARIABLE_NAME> format",
        Required = true,
    };

    private static Option<object> Value { get; } = new(
        name: @"--value")
    {
        Description = @"The value to substitute. Can be any valid JSON type (string, number, boolean, object, or array)",
        Required = true,
    };

    private static Option<int?> ApiVersion { get; } = new(
        name: @"--api-version")
    {
        Description = @"API version. Defaults to 1",
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

                    private static string FormatResponse(ParseResult parseResult, global::Deepgram.AgentVariableV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Deepgram.AgentVariableV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create", @"Create an Agent Variable
Creates a new template variable. Variables follow the `DG_&lt;VARIABLE_NAME&gt;` naming format and can substitute any JSON value in an agent configuration.");
                        command.Arguments.Add(ProjectId);
                        command.Options.Add(Key);
                        command.Options.Add(Value);
                        command.Options.Add(ApiVersion);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Deepgram.CreateAgentVariableV1Request>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Deepgram.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var projectId = parseResult.GetRequiredValue(ProjectId);
                        var key = parseResult.GetRequiredValue(Key);
                        var value = parseResult.GetRequiredValue(Value);
                        var apiVersion = CliRuntime.WasSpecified(parseResult, ApiVersion) ? parseResult.GetValue(ApiVersion) : (__requestBase is { } __ApiVersionBaseValue ? __ApiVersionBaseValue.ApiVersion : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.VoiceAgentVariables.CreateAsync(
                                    projectId: projectId,
                                    key: key,
                                    value: value,
                                    apiVersion: apiVersion,
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