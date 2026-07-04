#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static partial class SpeakV1AudioGenerateCommandApiCommand
{
    private static Option<string?> Callback { get; } = new(
        name: @"--callback")
    {
        Description = @"URL to which we'll make the callback request",
    };

    private static Option<global::Deepgram.V1SpeakPostParametersCallbackMethod?> CallbackMethod { get; } = new(
        name: @"--callback-method")
    {
        Description = @"HTTP method by which the callback request will be made",
    };

    private static Option<bool?> MipOptOut { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--mip-opt-out",
        description: @"Opts out requests from the Deepgram Model Improvement Program. Refer to our Docs for pricing impacts before setting this to true. https://dpgr.am/deepgram-mip");

    private static Option<global::Deepgram.V1SpeakPostParametersTag?> Tag { get; } = new(
        name: @"--tag")
    {
        Description = @"Label your requests for the purpose of identification during usage reporting",
    };

    private static Option<global::Deepgram.V1SpeakPostParametersBitRate?> BitRate { get; } = new(
        name: @"--bit-rate")
    {
        Description = @"The bitrate of the audio in bits per second. Choose from predefined ranges or specific values based on the encoding type.",
    };

    private static Option<global::Deepgram.V1SpeakPostParametersContainer?> Container { get; } = new(
        name: @"--container")
    {
        Description = @"Container specifies the file format wrapper for the output audio. The available options depend on the encoding type.",
    };

    private static Option<global::Deepgram.V1SpeakPostParametersEncoding?> Encoding { get; } = new(
        name: @"--encoding")
    {
        Description = @"Encoding allows you to specify the expected encoding of your audio output",
    };

    private static Option<global::Deepgram.V1SpeakPostParametersModel?> Model { get; } = new(
        name: @"--model")
    {
        Description = @"AI model used to process submitted text",
    };

    private static Option<global::Deepgram.V1SpeakPostParametersSampleRate?> SampleRate { get; } = new(
        name: @"--sample-rate")
    {
        Description = @"Sample Rate specifies the sample rate for the output audio. Based on the encoding, different sample rates are supported. For some encodings, the sample rate is not configurable",
    };

    private static Option<double?> Speed { get; } = new(
        name: @"--speed")
    {
        Description = @"Speaking rate multiplier that adjusts the pace of generated speech while preserving natural prosody and voice quality. Not yet supported in all languages.",
    };

    private static Option<string> Text { get; } = new(
        name: @"--text")
    {
        Description = @"The text content to be converted to speech",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Deepgram.SpeakV1AudioGenerateResponse200 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Deepgram.SpeakV1AudioGenerateResponse200 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"generate", @"Text to Speech transformation
Convert text into natural-sounding speech using Deepgram's TTS REST API");
                        command.Options.Add(Callback);
                        command.Options.Add(CallbackMethod);
                        command.Options.Add(MipOptOut);
                        command.Options.Add(Tag);
                        command.Options.Add(BitRate);
                        command.Options.Add(Container);
                        command.Options.Add(Encoding);
                        command.Options.Add(Model);
                        command.Options.Add(SampleRate);
                        command.Options.Add(Speed);
                        command.Options.Add(Text);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var callback = parseResult.GetValue(Callback);
                        var callbackMethod = parseResult.GetValue(CallbackMethod);
                        var mipOptOut = parseResult.GetValue(MipOptOut);
                        var tag = parseResult.GetValue(Tag);
                        var bitRate = parseResult.GetValue(BitRate);
                        var container = parseResult.GetValue(Container);
                        var encoding = parseResult.GetValue(Encoding);
                        var model = parseResult.GetValue(Model);
                        var sampleRate = parseResult.GetValue(SampleRate);
                        var speed = parseResult.GetValue(Speed);
                        var text = parseResult.GetRequiredValue(Text);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.SpeakV1Audio.GenerateAsync(
                                    callback: callback,
                                    callbackMethod: callbackMethod,
                                    mipOptOut: mipOptOut,
                                    tag: tag,
                                    bitRate: bitRate,
                                    container: container,
                                    encoding: encoding,
                                    model: model,
                                    sampleRate: sampleRate,
                                    speed: speed,
                                    text: text,
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