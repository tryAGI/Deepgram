#nullable enable
#pragma warning disable MEAI001

using System.Globalization;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.AI;

namespace Deepgram;

public sealed partial class DeepgramClient : Microsoft.Extensions.AI.ITextToSpeechClient
{
    private const string DefaultTextToSpeechModel = "aura-2-asteria-en";
    private TextToSpeechClientMetadata? _textToSpeechMetadata;

    object? Microsoft.Extensions.AI.ITextToSpeechClient.GetService(Type serviceType, object? serviceKey)
    {
        ArgumentNullException.ThrowIfNull(serviceType);

        return serviceKey is not null ? null :
            serviceType == typeof(TextToSpeechClientMetadata) ? (_textToSpeechMetadata ??= new("deepgram", new Uri(DefaultBaseUrl), DefaultTextToSpeechModel)) :
            serviceType.IsInstanceOfType(this) ? this :
            null;
    }

    async Task<TextToSpeechResponse> Microsoft.Extensions.AI.ITextToSpeechClient.GetAudioAsync(
        string text,
        TextToSpeechOptions? options,
        CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(text);

        var request = CreateSpeakRequest(text, options);
        var resolved = ResolveSpeakOptions(options);
        using var httpRequest = CreateSpeakHttpRequest(request, resolved);
        using var response = await HttpClient.SendAsync(
            httpRequest,
            HttpCompletionOption.ResponseContentRead,
            cancellationToken).ConfigureAwait(false);

        await ThrowIfNotSuccessAsync(response, cancellationToken).ConfigureAwait(false);

        var audio = await response.Content.ReadAsByteArrayAsync(cancellationToken).ConfigureAwait(false);
        var responseId = GetResponseId(response);
        return new TextToSpeechResponse([
            new DataContent(audio, resolved.MediaType),
        ])
        {
            ResponseId = responseId,
            ModelId = resolved.ModelId,
            RawRepresentation = request,
            AdditionalProperties = CreateResponseProperties(resolved, responseId),
        };
    }

    async IAsyncEnumerable<TextToSpeechResponseUpdate> Microsoft.Extensions.AI.ITextToSpeechClient.GetStreamingAudioAsync(
        string text,
        TextToSpeechOptions? options,
        [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(text);

        var request = CreateSpeakRequest(text, options);
        var resolved = ResolveSpeakOptions(options);
        var localResponseId = Guid.NewGuid().ToString("N");

        yield return new TextToSpeechResponseUpdate
        {
            Kind = TextToSpeechResponseUpdateKind.SessionOpen,
            ResponseId = localResponseId,
            ModelId = resolved.ModelId,
            RawRepresentation = request,
            AdditionalProperties = CreateResponseProperties(resolved),
        };

        using var httpRequest = CreateSpeakHttpRequest(request, resolved);
        using var response = await HttpClient.SendAsync(
            httpRequest,
            HttpCompletionOption.ResponseHeadersRead,
            cancellationToken).ConfigureAwait(false);

        await ThrowIfNotSuccessAsync(response, cancellationToken).ConfigureAwait(false);

        var responseId = GetResponseId(response) ?? localResponseId;
        using var stream = await response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
        var buffer = new byte[16 * 1024];
        while (true)
        {
            var bytesRead = await stream.ReadAsync(buffer, cancellationToken).ConfigureAwait(false);
            if (bytesRead <= 0)
            {
                break;
            }

            yield return new TextToSpeechResponseUpdate([
                new DataContent(buffer.AsSpan(0, bytesRead).ToArray(), resolved.MediaType),
            ])
            {
                Kind = TextToSpeechResponseUpdateKind.AudioUpdating,
                ResponseId = responseId,
                ModelId = resolved.ModelId,
                AdditionalProperties = CreateResponseProperties(resolved, responseId),
            };
        }

        yield return new TextToSpeechResponseUpdate
        {
            Kind = TextToSpeechResponseUpdateKind.AudioUpdated,
            ResponseId = responseId,
            ModelId = resolved.ModelId,
            AdditionalProperties = CreateResponseProperties(resolved, responseId),
        };

        yield return new TextToSpeechResponseUpdate
        {
            Kind = TextToSpeechResponseUpdateKind.SessionClose,
            ResponseId = responseId,
            ModelId = resolved.ModelId,
        };
    }

    private SpeakV1Request CreateSpeakRequest(string text, TextToSpeechOptions? options)
    {
        var request = options?.RawRepresentationFactory?.Invoke(this) as SpeakV1Request
            ?? new SpeakV1Request(text);

        if (string.IsNullOrWhiteSpace(request.Text))
        {
            request.Text = text;
        }

        return request;
    }

    private HttpRequestMessage CreateSpeakHttpRequest(
        SpeakV1Request request,
        ResolvedDeepgramTextToSpeechOptions resolved)
    {
        var httpRequest = new HttpRequestMessage(HttpMethod.Post, BuildSpeakUri(resolved))
        {
            Content = new StringContent(
                request.ToJson(SourceGenerationContext.Default),
                System.Text.Encoding.UTF8,
                "application/json"),
        };

        var authorization = ResolveDeepgramAuthorization();
        httpRequest.Headers.Authorization = new AuthenticationHeaderValue("Token", authorization.Value);

        PrepareRequest(HttpClient, httpRequest);

        return httpRequest;
    }

    private static ResolvedDeepgramTextToSpeechOptions ResolveSpeakOptions(TextToSpeechOptions? options)
    {
        var audioFormat = options.GetString(DeepgramTextToSpeechPropertyNames.Encoding)
            ?? options?.AudioFormat;
        var (encoding, container, mediaType) = ResolveFormat(
            audioFormat,
            options.GetString(DeepgramTextToSpeechPropertyNames.Container));
        var modelId =
            options?.ModelId is { Length: > 0 } modelIdValue ? modelIdValue :
            options?.VoiceId is { Length: > 0 } voiceIdValue ? voiceIdValue :
            DefaultTextToSpeechModel;

        return new ResolvedDeepgramTextToSpeechOptions(
            modelId,
            encoding,
            container,
            mediaType,
            options.GetInt(DeepgramTextToSpeechPropertyNames.SampleRate),
            options.GetInt(DeepgramTextToSpeechPropertyNames.BitRate),
            options?.Speed,
            options.GetBool(DeepgramTextToSpeechPropertyNames.MipOptOut),
            options.GetString(DeepgramTextToSpeechPropertyNames.Callback),
            options.GetString(DeepgramTextToSpeechPropertyNames.CallbackMethod),
            options.GetTagValues());
    }

    private static (string Encoding, string? Container, string MediaType) ResolveFormat(
        string? format,
        string? container)
    {
        if (format is not { Length: > 0 })
        {
            return ("mp3", container, "audio/mpeg");
        }

        if (string.Equals(format, "audio/mpeg", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "audio/mp3", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "mp3", StringComparison.OrdinalIgnoreCase))
        {
            return ("mp3", container, "audio/mpeg");
        }

        if (string.Equals(format, "audio/wav", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "audio/wave", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "wav", StringComparison.OrdinalIgnoreCase))
        {
            return ("linear16", container ?? "wav", "audio/wav");
        }

        if (string.Equals(format, "audio/pcm", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "pcm", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "pcm_s16le", StringComparison.OrdinalIgnoreCase))
        {
            return ("linear16", container ?? "none", "audio/pcm;codec=s16le");
        }

        if (string.Equals(format, "audio/basic", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "mulaw", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "mu-law", StringComparison.OrdinalIgnoreCase))
        {
            return ("mulaw", container, "audio/basic");
        }

        if (string.Equals(format, "alaw", StringComparison.OrdinalIgnoreCase))
        {
            return ("alaw", container, "audio/pcma");
        }

        if (string.Equals(format, "audio/ogg", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "opus", StringComparison.OrdinalIgnoreCase))
        {
            return ("opus", container, "audio/ogg;codecs=opus");
        }

        if (string.Equals(format, "audio/aac", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "aac", StringComparison.OrdinalIgnoreCase))
        {
            return ("aac", container, "audio/aac");
        }

        if (string.Equals(format, "audio/flac", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "flac", StringComparison.OrdinalIgnoreCase))
        {
            return ("flac", container, "audio/flac");
        }

        return (format, container, "application/octet-stream");
    }

    private Uri BuildSpeakUri(ResolvedDeepgramTextToSpeechOptions resolved)
    {
        var baseUri = HttpClient.BaseAddress ?? new Uri(DefaultBaseUrl);
        var uriBuilder = new UriBuilder(new Uri(baseUri, "/v1/speak"));
        var queryParameters = new List<KeyValuePair<string, string>>
        {
            new("model", resolved.ModelId),
            new("encoding", resolved.Encoding),
        };

        AddOptionalQueryParameter(queryParameters, "container", resolved.Container);
        AddOptionalQueryParameter(queryParameters, "sample_rate", resolved.SampleRate);
        AddOptionalQueryParameter(queryParameters, "bit_rate", resolved.BitRate);
        AddOptionalQueryParameter(queryParameters, "speed", resolved.Speed);
        AddOptionalQueryParameter(queryParameters, "mip_opt_out", resolved.MipOptOut);
        AddOptionalQueryParameter(queryParameters, "callback", resolved.Callback);
        AddOptionalQueryParameter(queryParameters, "callback_method", resolved.CallbackMethod);
        foreach (var tag in resolved.Tags)
        {
            AddOptionalQueryParameter(queryParameters, "tag", tag);
        }

        uriBuilder.Query = string.Join("&", queryParameters.Select(static parameter =>
            $"{Uri.EscapeDataString(parameter.Key)}={Uri.EscapeDataString(parameter.Value)}"));

        return uriBuilder.Uri;
    }

    private EndPointAuthorization ResolveDeepgramAuthorization()
    {
        for (var i = 0; i < Authorizations.Count; i++)
        {
            var authorization = Authorizations[i];
            if (authorization is { Type: "Http", Value.Length: > 0 }
                && (string.Equals(authorization.Name, "Token", StringComparison.OrdinalIgnoreCase)
                    || string.Equals(authorization.Name, "Bearer", StringComparison.OrdinalIgnoreCase)))
            {
                return authorization;
            }
        }

        throw new InvalidOperationException("No API key found in DeepgramClient.Authorizations. Ensure the client was created with an API key.");
    }

    private static async Task ThrowIfNotSuccessAsync(
        HttpResponseMessage response,
        CancellationToken cancellationToken)
    {
        if (response.IsSuccessStatusCode)
        {
            return;
        }

        string? responseBody = null;
        Exception? readException = null;
        try
        {
            responseBody = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
        }
        catch (HttpRequestException ex)
        {
            readException = ex;
        }
        catch (IOException ex)
        {
            readException = ex;
        }

        throw ApiException.Create(
            response.StatusCode,
            responseBody ?? response.ReasonPhrase ?? string.Empty,
            readException,
            responseBody,
            AutoSDKHttpResponse.CreateHeaders(response));
    }

    private static void AddOptionalQueryParameter(
        List<KeyValuePair<string, string>> queryParameters,
        string name,
        string? value)
    {
        if (value is { Length: > 0 })
        {
            queryParameters.Add(new(name, value));
        }
    }

    private static void AddOptionalQueryParameter(
        List<KeyValuePair<string, string>> queryParameters,
        string name,
        int? value)
    {
        if (value is { } intValue)
        {
            queryParameters.Add(new(name, intValue.ToString(CultureInfo.InvariantCulture)));
        }
    }

    private static void AddOptionalQueryParameter(
        List<KeyValuePair<string, string>> queryParameters,
        string name,
        double? value)
    {
        if (value is { } doubleValue)
        {
            queryParameters.Add(new(name, doubleValue.ToString("G9", CultureInfo.InvariantCulture)));
        }
    }

    private static void AddOptionalQueryParameter(
        List<KeyValuePair<string, string>> queryParameters,
        string name,
        bool? value)
    {
        if (value is { } boolValue)
        {
            queryParameters.Add(new(name, boolValue ? "true" : "false"));
        }
    }

    private static string? GetResponseId(HttpResponseMessage response)
    {
        return TryGetHeader(response, "dg-request-id")
            ?? TryGetHeader(response, "request-id")
            ?? TryGetHeader(response, "x-request-id");
    }

    private static string? TryGetHeader(HttpResponseMessage response, string name)
    {
        return response.Headers.TryGetValues(name, out var values)
            ? values.FirstOrDefault()
            : response.Content.Headers.TryGetValues(name, out values)
                ? values.FirstOrDefault()
                : null;
    }

    private static AdditionalPropertiesDictionary CreateResponseProperties(
        ResolvedDeepgramTextToSpeechOptions resolved,
        string? responseId = null)
    {
        AdditionalPropertiesDictionary properties = new()
        {
            ["model_id"] = resolved.ModelId,
            [DeepgramTextToSpeechPropertyNames.Encoding] = resolved.Encoding,
            ["media_type"] = resolved.MediaType,
        };

        if (resolved.Container is { Length: > 0 })
        {
            properties[DeepgramTextToSpeechPropertyNames.Container] = resolved.Container;
        }

        if (resolved.SampleRate is { } sampleRate)
        {
            properties[DeepgramTextToSpeechPropertyNames.SampleRate] = sampleRate;
        }

        if (responseId is { Length: > 0 })
        {
            properties["request_id"] = responseId;
        }

        return properties;
    }

    private sealed record ResolvedDeepgramTextToSpeechOptions(
        string ModelId,
        string Encoding,
        string? Container,
        string MediaType,
        int? SampleRate,
        int? BitRate,
        double? Speed,
        bool? MipOptOut,
        string? Callback,
        string? CallbackMethod,
        IReadOnlyList<string> Tags);
}

internal static class DeepgramTextToSpeechOptionsExtensions
{
    public static bool? GetBool(this TextToSpeechOptions? options, string key)
    {
        if (options?.AdditionalProperties is not { } properties || !properties.TryGetValue(key, out var value))
        {
            return null;
        }

        return value switch
        {
            bool boolValue => boolValue,
            string text when bool.TryParse(text, out var parsed) => parsed,
            _ => null,
        };
    }

    public static int? GetInt(this TextToSpeechOptions? options, string key)
    {
        if (options?.AdditionalProperties is not { } properties || !properties.TryGetValue(key, out var value))
        {
            return null;
        }

        return value switch
        {
            int intValue => intValue,
            long longValue when longValue is >= int.MinValue and <= int.MaxValue => (int)longValue,
            string text when int.TryParse(text, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed) => parsed,
            _ => null,
        };
    }

    public static string? GetString(this TextToSpeechOptions? options, string key)
    {
        return options?.AdditionalProperties is { } properties
            && properties.TryGetValue(key, out var value)
            && value is string text
            && text.Length > 0
                ? text
                : null;
    }

    public static IReadOnlyList<string> GetTagValues(this TextToSpeechOptions? options)
    {
        if (options?.AdditionalProperties is not { } properties
            || !properties.TryGetValue(DeepgramTextToSpeechPropertyNames.Tag, out var value))
        {
            return [];
        }

        return value switch
        {
            string text when text.Length > 0 => [text],
            IEnumerable<string> values => values.Where(static text => text.Length > 0).ToArray(),
            _ => [],
        };
    }
}
