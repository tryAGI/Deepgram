#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Deepgram.Realtime.JsonConverters
{
    /// <inheritdoc />
    public class ListenV2ServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.Realtime.ListenV2ServerEvent>
    {
        /// <inheritdoc />
        public override global::Deepgram.Realtime.ListenV2ServerEvent Read(
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
            if (__jsonProps.Contains("request_id")) __score0++;
            if (__jsonProps.Contains("sequence_id")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("audio_window_end")) __score1++;
            if (__jsonProps.Contains("audio_window_start")) __score1++;
            if (__jsonProps.Contains("end_of_turn_confidence")) __score1++;
            if (__jsonProps.Contains("event")) __score1++;
            if (__jsonProps.Contains("languages")) __score1++;
            if (__jsonProps.Contains("languages_hinted")) __score1++;
            if (__jsonProps.Contains("request_id")) __score1++;
            if (__jsonProps.Contains("sequence_id")) __score1++;
            if (__jsonProps.Contains("transcript")) __score1++;
            if (__jsonProps.Contains("trigger")) __score1++;
            if (__jsonProps.Contains("turn_index")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("words")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("keyterms")) __score2++;
            if (__jsonProps.Contains("language_hints")) __score2++;
            if (__jsonProps.Contains("numerals")) __score2++;
            if (__jsonProps.Contains("request_id")) __score2++;
            if (__jsonProps.Contains("sequence_id")) __score2++;
            if (__jsonProps.Contains("thresholds")) __score2++;
            if (__jsonProps.Contains("thresholds.eager_eot_threshold")) __score2++;
            if (__jsonProps.Contains("thresholds.eot_threshold")) __score2++;
            if (__jsonProps.Contains("thresholds.eot_timeout_ms")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("code")) __score3++;
            if (__jsonProps.Contains("description")) __score3++;
            if (__jsonProps.Contains("request_id")) __score3++;
            if (__jsonProps.Contains("sequence_id")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("code")) __score4++;
            if (__jsonProps.Contains("description")) __score4++;
            if (__jsonProps.Contains("request_id")) __score4++;
            if (__jsonProps.Contains("sequence_id")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("code")) __score5++;
            if (__jsonProps.Contains("description")) __score5++;
            if (__jsonProps.Contains("sequence_id")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            global::Deepgram.Realtime.ListenV2ListenV2Connected? listenV2ListenV2Connected = default;
            global::Deepgram.Realtime.ListenV2ListenV2TurnInfo? turnInfo = default;
            global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess? configureSuccess = default;
            global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure? configureFailure = default;
            global::Deepgram.Realtime.ListenV2ListenV2Warning? warning = default;
            global::Deepgram.Realtime.ListenV2ListenV2FatalError? listenV2ListenV2FatalError = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV2ListenV2Connected), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV2ListenV2Connected> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV2ListenV2Connected).Name}");
                        listenV2ListenV2Connected = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV2ListenV2TurnInfo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV2ListenV2TurnInfo> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV2ListenV2TurnInfo).Name}");
                        turnInfo = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess).Name}");
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
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure).Name}");
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
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV2ListenV2Warning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV2ListenV2Warning> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV2ListenV2Warning).Name}");
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
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV2ListenV2FatalError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV2ListenV2FatalError> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV2ListenV2FatalError).Name}");
                        listenV2ListenV2FatalError = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            if (listenV2ListenV2Connected == null && turnInfo == null && configureSuccess == null && configureFailure == null && warning == null && listenV2ListenV2FatalError == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV2ListenV2Connected), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV2ListenV2Connected> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV2ListenV2Connected).Name}");
                    listenV2ListenV2Connected = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            if (listenV2ListenV2Connected == null && turnInfo == null && configureSuccess == null && configureFailure == null && warning == null && listenV2ListenV2FatalError == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV2ListenV2TurnInfo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV2ListenV2TurnInfo> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV2ListenV2TurnInfo).Name}");
                    turnInfo = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            if (listenV2ListenV2Connected == null && turnInfo == null && configureSuccess == null && configureFailure == null && warning == null && listenV2ListenV2FatalError == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess).Name}");
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

            if (listenV2ListenV2Connected == null && turnInfo == null && configureSuccess == null && configureFailure == null && warning == null && listenV2ListenV2FatalError == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure).Name}");
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

            if (listenV2ListenV2Connected == null && turnInfo == null && configureSuccess == null && configureFailure == null && warning == null && listenV2ListenV2FatalError == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV2ListenV2Warning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV2ListenV2Warning> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV2ListenV2Warning).Name}");
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

            if (listenV2ListenV2Connected == null && turnInfo == null && configureSuccess == null && configureFailure == null && warning == null && listenV2ListenV2FatalError == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV2ListenV2FatalError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV2ListenV2FatalError> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV2ListenV2FatalError).Name}");
                    listenV2ListenV2FatalError = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            var __value = new global::Deepgram.Realtime.ListenV2ServerEvent(
                listenV2ListenV2Connected,

                turnInfo,

                configureSuccess,

                configureFailure,

                warning,

                listenV2ListenV2FatalError
                );

            if (!__value.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid JSON format for OneOf<{typeof(global::Deepgram.Realtime.ListenV2ListenV2Connected).Name}, {typeof(global::Deepgram.Realtime.ListenV2ListenV2TurnInfo).Name}, {typeof(global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess).Name}, {typeof(global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure).Name}, {typeof(global::Deepgram.Realtime.ListenV2ListenV2Warning).Name}, {typeof(global::Deepgram.Realtime.ListenV2ListenV2FatalError).Name}>");
            }

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.Realtime.ListenV2ServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            if (!value.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid OneOf<{typeof(global::Deepgram.Realtime.ListenV2ListenV2Connected).Name}, {typeof(global::Deepgram.Realtime.ListenV2ListenV2TurnInfo).Name}, {typeof(global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess).Name}, {typeof(global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure).Name}, {typeof(global::Deepgram.Realtime.ListenV2ListenV2Warning).Name}, {typeof(global::Deepgram.Realtime.ListenV2ListenV2FatalError).Name}> object.");
            }

            if (value.IsListenV2ListenV2Connected)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV2ListenV2Connected), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV2ListenV2Connected?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV2ListenV2Connected).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickListenV2ListenV2Connected(), typeInfo);
            }
            else if (value.IsTurnInfo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV2ListenV2TurnInfo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV2ListenV2TurnInfo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV2ListenV2TurnInfo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTurnInfo(), typeInfo);
            }
            else if (value.IsConfigureSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickConfigureSuccess(), typeInfo);
            }
            else if (value.IsConfigureFailure)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickConfigureFailure(), typeInfo);
            }
            else if (value.IsWarning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV2ListenV2Warning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV2ListenV2Warning?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV2ListenV2Warning).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickWarning(), typeInfo);
            }
            else if (value.IsListenV2ListenV2FatalError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV2ListenV2FatalError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV2ListenV2FatalError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV2ListenV2FatalError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickListenV2ListenV2FatalError(), typeInfo);
            }
        }
    }
}