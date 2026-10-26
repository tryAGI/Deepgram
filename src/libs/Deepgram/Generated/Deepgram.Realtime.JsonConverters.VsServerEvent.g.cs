#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Deepgram.Realtime.JsonConverters
{
    /// <inheritdoc />
    public class VsServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.Realtime.VsServerEvent>
    {
        /// <inheritdoc />
        public override global::Deepgram.Realtime.VsServerEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            var __score1 = 0;
            if (__jsonProps.Contains("model_name")) __score1++;
            if (__jsonProps.Contains("model_uuids")) __score1++;
            if (__jsonProps.Contains("model_version")) __score1++;
            if (__jsonProps.Contains("request_id")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("speech_id")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("audio_duration_ms")) __score3++;
            if (__jsonProps.Contains("billable_character_count")) __score3++;
            if (__jsonProps.Contains("controls_applied")) __score3++;
            if (__jsonProps.Contains("controls_applied.breaks_applied")) __score3++;
            if (__jsonProps.Contains("controls_applied.pronunciation_warnings")) __score3++;
            if (__jsonProps.Contains("controls_applied.pronunciations_applied")) __score3++;
            if (__jsonProps.Contains("input_character_count")) __score3++;
            if (__jsonProps.Contains("speech_id")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("audio_played_ms")) __score4++;
            if (__jsonProps.Contains("metadata")) __score4++;
            if (__jsonProps.Contains("metadata.audio_duration_ms")) __score4++;
            if (__jsonProps.Contains("metadata.billable_character_count")) __score4++;
            if (__jsonProps.Contains("metadata.controls_applied")) __score4++;
            if (__jsonProps.Contains("metadata.input_character_count")) __score4++;
            if (__jsonProps.Contains("metadata.speech_id")) __score4++;
            if (__jsonProps.Contains("text_remaining")) __score4++;
            if (__jsonProps.Contains("text_spoken")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("speech_id")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("total_audio_duration_ms")) __score6++;
            if (__jsonProps.Contains("total_billable_character_count")) __score6++;
            if (__jsonProps.Contains("total_input_character_count")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("applied")) __score7++;
            if (__jsonProps.Contains("applied.speed")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("code")) __score8++;
            if (__jsonProps.Contains("description")) __score8++;
            if (__jsonProps.Contains("field")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            if (__jsonProps.Contains("value")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("code")) __score9++;
            if (__jsonProps.Contains("description")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("code")) __score10++;
            if (__jsonProps.Contains("description")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }

            byte[]? speakV2SpeakV2Audio = default;
            global::Deepgram.Realtime.SpeakV2SpeakV2Connected? connected = default;
            global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted? speechStarted = default;
            global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata? speechMetadata = default;
            global::Deepgram.Realtime.SpeakV2SpeakV2SpeechInterrupted? speechInterrupted = default;
            global::Deepgram.Realtime.SpeakV2SpeakV2Flushed? flushed = default;
            global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata? sessionMetadata = default;
            global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureSuccess? configureSuccess = default;
            global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureFailure? configureFailure = default;
            global::Deepgram.Realtime.SpeakV2SpeakV2Warning? warning = default;
            global::Deepgram.Realtime.SpeakV2SpeakV2Error? error = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        speakV2SpeakV2Audio = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Connected), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2Connected> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Connected).Name}");
                        connected = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted).Name}");
                        speechStarted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata).Name}");
                        speechMetadata = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechInterrupted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechInterrupted> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechInterrupted).Name}");
                        speechInterrupted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Flushed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2Flushed> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Flushed).Name}");
                        flushed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata).Name}");
                        sessionMetadata = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureSuccess), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureSuccess> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureSuccess).Name}");
                        configureSuccess = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureFailure), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureFailure> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureFailure).Name}");
                        configureFailure = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Warning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2Warning> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Warning).Name}");
                        warning = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 10)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Error), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2Error> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Error).Name}");
                        error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
            }

            if (speakV2SpeakV2Audio == null && connected == null && speechStarted == null && speechMetadata == null && speechInterrupted == null && flushed == null && sessionMetadata == null && configureSuccess == null && configureFailure == null && warning == null && error == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    speakV2SpeakV2Audio = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (speakV2SpeakV2Audio == null && connected == null && speechStarted == null && speechMetadata == null && speechInterrupted == null && flushed == null && sessionMetadata == null && configureSuccess == null && configureFailure == null && warning == null && error == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Connected), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2Connected> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Connected).Name}");
                    connected = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (speakV2SpeakV2Audio == null && connected == null && speechStarted == null && speechMetadata == null && speechInterrupted == null && flushed == null && sessionMetadata == null && configureSuccess == null && configureFailure == null && warning == null && error == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted).Name}");
                    speechStarted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (speakV2SpeakV2Audio == null && connected == null && speechStarted == null && speechMetadata == null && speechInterrupted == null && flushed == null && sessionMetadata == null && configureSuccess == null && configureFailure == null && warning == null && error == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata).Name}");
                    speechMetadata = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (speakV2SpeakV2Audio == null && connected == null && speechStarted == null && speechMetadata == null && speechInterrupted == null && flushed == null && sessionMetadata == null && configureSuccess == null && configureFailure == null && warning == null && error == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechInterrupted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechInterrupted> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechInterrupted).Name}");
                    speechInterrupted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (speakV2SpeakV2Audio == null && connected == null && speechStarted == null && speechMetadata == null && speechInterrupted == null && flushed == null && sessionMetadata == null && configureSuccess == null && configureFailure == null && warning == null && error == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Flushed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2Flushed> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Flushed).Name}");
                    flushed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (speakV2SpeakV2Audio == null && connected == null && speechStarted == null && speechMetadata == null && speechInterrupted == null && flushed == null && sessionMetadata == null && configureSuccess == null && configureFailure == null && warning == null && error == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata).Name}");
                    sessionMetadata = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (speakV2SpeakV2Audio == null && connected == null && speechStarted == null && speechMetadata == null && speechInterrupted == null && flushed == null && sessionMetadata == null && configureSuccess == null && configureFailure == null && warning == null && error == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureSuccess), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureSuccess> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureSuccess).Name}");
                    configureSuccess = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (speakV2SpeakV2Audio == null && connected == null && speechStarted == null && speechMetadata == null && speechInterrupted == null && flushed == null && sessionMetadata == null && configureSuccess == null && configureFailure == null && warning == null && error == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureFailure), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureFailure> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureFailure).Name}");
                    configureFailure = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (speakV2SpeakV2Audio == null && connected == null && speechStarted == null && speechMetadata == null && speechInterrupted == null && flushed == null && sessionMetadata == null && configureSuccess == null && configureFailure == null && warning == null && error == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Warning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2Warning> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Warning).Name}");
                    warning = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (speakV2SpeakV2Audio == null && connected == null && speechStarted == null && speechMetadata == null && speechInterrupted == null && flushed == null && sessionMetadata == null && configureSuccess == null && configureFailure == null && warning == null && error == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Error), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2Error> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Error).Name}");
                    error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            var __value = new global::Deepgram.Realtime.VsServerEvent(
                speakV2SpeakV2Audio,

                connected,

                speechStarted,

                speechMetadata,

                speechInterrupted,

                flushed,

                sessionMetadata,

                configureSuccess,

                configureFailure,

                warning,

                error
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.Realtime.VsServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSpeakV2SpeakV2Audio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSpeakV2SpeakV2Audio(), typeInfo);
            }
            else if (value.IsConnected)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Connected), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2Connected?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Connected).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickConnected(), typeInfo);
            }
            else if (value.IsSpeechStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSpeechStarted(), typeInfo);
            }
            else if (value.IsSpeechMetadata)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSpeechMetadata(), typeInfo);
            }
            else if (value.IsSpeechInterrupted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechInterrupted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechInterrupted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechInterrupted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSpeechInterrupted(), typeInfo);
            }
            else if (value.IsFlushed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Flushed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2Flushed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Flushed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFlushed(), typeInfo);
            }
            else if (value.IsSessionMetadata)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSessionMetadata(), typeInfo);
            }
            else if (value.IsConfigureSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureSuccess), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureSuccess?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureSuccess).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickConfigureSuccess(), typeInfo);
            }
            else if (value.IsConfigureFailure)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureFailure), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureFailure?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureFailure).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickConfigureFailure(), typeInfo);
            }
            else if (value.IsWarning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Warning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2Warning?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Warning).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickWarning(), typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Error), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2Error?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Error).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickError(), typeInfo);
            }
        }
    }
}