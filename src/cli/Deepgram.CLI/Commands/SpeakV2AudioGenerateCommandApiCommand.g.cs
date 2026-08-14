#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static partial class SpeakV2AudioGenerateCommandApiCommand
{
    private static Option<string?> Callback { get; } = new(
        name: @"--callback")
    {
        Description = @"URL to which we'll make the callback request",
    };

    private static Option<global::Deepgram.V2SpeakPostParametersCallbackMethod?> CallbackMethod { get; } = new(
        name: @"--callback-method")
    {
        Description = @"HTTP method by which the callback request will be made",
    };

    private static Option<bool?> MipOptOut { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--mip-opt-out",
        description: @"Opts out requests from the Deepgram Model Improvement Program. Refer to our Docs for pricing impacts before setting this to true. https://dpgr.am/deepgram-mip");

    private static Option<global::Deepgram.V2SpeakPostParametersTag?> Tag { get; } = new(
        name: @"--tag")
    {
        Description = @"Label your requests for the purpose of identification during usage reporting",
    };

    private static Option<global::Deepgram.V2SpeakPostParametersBitRate?> BitRate { get; } = new(
        name: @"--bit-rate")
    {
        Description = @"The bitrate of the audio in bits per second. Choose from predefined ranges or specific values based on the encoding type.",
    };

    private static Option<global::Deepgram.V2SpeakPostParametersContainer?> Container { get; } = new(
        name: @"--container")
    {
        Description = @"Container specifies the file format wrapper for the output audio. The available options depend on the encoding type.",
    };

    private static Option<global::Deepgram.V2SpeakPostParametersEncoding?> Encoding { get; } = new(
        name: @"--encoding")
    {
        Description = @"Encoding allows you to specify the expected encoding of your audio output",
    };

    private static Option<global::Deepgram.V2SpeakPostParametersExpressivity?> Expressivity { get; } = new(
        name: @"--expressivity")
    {
        Description = @"Expressive range of the generated speech, on a calm-to-animated axis. Accepted values: `-2`, `-1`, `0`, `1`, `2`. `0` (the default) is the voice's tuned delivery and the production-validated setting, with `-2` the calm end of the range and `2` the animated end. Supported on all Flux voices; applies to the whole request. Beta: behavior may change in future model versions, and non-default values increase the risk of hallucinations and pronunciation errors; audition before shipping. An invalid value is rejected with a `400` — `EXPRESSIVITY_OUT_OF_RANGE` for a value outside the range, `EXPRESSIVITY_INCREMENT_INVALID` for a fractional value. See [Expressivity](/docs/tts-expressivity).",
    };

    private static Option<string> Model { get; } = new(
        name: @"--model")
    {
        Description = @"Flux TTS model used to synthesize the submitted text, in the form `flux-{voice}-{language}` (for example, `flux-alexis-en`). Required; unlike the v1 (Aura) endpoint there is no default and only flux models are accepted. English-only at launch.",
        Required = true,
    };

    private static Option<global::Deepgram.V2SpeakPostParametersSampleRate?> SampleRate { get; } = new(
        name: @"--sample-rate")
    {
        Description = @"Sample Rate specifies the sample rate for the output audio. Based on the encoding, different sample rates are supported. For some encodings, the sample rate is not configurable",
    };

    private static Option<global::Deepgram.V2SpeakPostParametersSpeed?> Speed { get; } = new(
        name: @"--speed")
    {
        Description = @"Speaking rate multiplier that adjusts the pace of generated speech while preserving natural prosody and voice quality. Accepted values run `0.85` to `1.15` in `0.05` increments. Not yet supported in all languages.",
    };

    private static Option<global::Deepgram.V2SpeakPostParametersPriority?> Priority { get; } = new(
        name: @"--priority")
    {
        Description = @"Processing priority for asynchronous (callback) requests. The only supported value is low.",
    };

    private static Option<string> Text { get; } = new(
        name: @"--text")
    {
        Description = @"The text content to be converted to speech. The server normalizes and preprocesses the text before synthesis. Inline pause and pronunciation controls are not yet applied; they are stripped from the text before synthesis.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Deepgram.SpeakV2AcceptedResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Deepgram.SpeakV2AcceptedResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"generate", @"Flux Text to Speech (batch)
Synthesize a complete block of text into a single audio response using Deepgram's Flux TTS batch (REST) API. Use this for pre-rendering fixed audio (IVR prompts, notifications, narration) where the whole text is known up front and you don't need incremental playback or interruption.");
                        command.Options.Add(Callback);
                        command.Options.Add(CallbackMethod);
                        command.Options.Add(MipOptOut);
                        command.Options.Add(Tag);
                        command.Options.Add(BitRate);
                        command.Options.Add(Container);
                        command.Options.Add(Encoding);
                        command.Options.Add(Expressivity);
                        command.Options.Add(Model);
                        command.Options.Add(SampleRate);
                        command.Options.Add(Speed);
                        command.Options.Add(Priority);
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
                        var expressivity = parseResult.GetValue(Expressivity);
                        var model = parseResult.GetRequiredValue(Model);
                        var sampleRate = parseResult.GetValue(SampleRate);
                        var speed = parseResult.GetValue(Speed);
                        var priority = parseResult.GetValue(Priority);
                        var text = parseResult.GetRequiredValue(Text);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.SpeakV2Audio.GenerateAsync(
                                    callback: callback,
                                    callbackMethod: callbackMethod,
                                    mipOptOut: mipOptOut,
                                    tag: tag,
                                    bitRate: bitRate,
                                    container: container,
                                    encoding: encoding,
                                    expressivity: expressivity,
                                    model: model,
                                    sampleRate: sampleRate,
                                    speed: speed,
                                    priority: priority,
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