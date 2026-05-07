#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Deepgram.Realtime.JsonConverters
{
    /// <inheritdoc />
    public class ListenV1ServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.Realtime.ListenV1ServerEvent>
    {
        /// <inheritdoc />
        public override global::Deepgram.Realtime.ListenV1ServerEvent Read(
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
            if (__jsonProps.Contains("channel")) __score0++;
            if (__jsonProps.Contains("channel.alternatives")) __score0++;
            if (__jsonProps.Contains("channel_index")) __score0++;
            if (__jsonProps.Contains("duration")) __score0++;
            if (__jsonProps.Contains("entities")) __score0++;
            if (__jsonProps.Contains("from_finalize")) __score0++;
            if (__jsonProps.Contains("is_final")) __score0++;
            if (__jsonProps.Contains("metadata")) __score0++;
            if (__jsonProps.Contains("metadata.model_info")) __score0++;
            if (__jsonProps.Contains("metadata.model_uuid")) __score0++;
            if (__jsonProps.Contains("metadata.request_id")) __score0++;
            if (__jsonProps.Contains("speech_final")) __score0++;
            if (__jsonProps.Contains("start")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("channels")) __score1++;
            if (__jsonProps.Contains("created")) __score1++;
            if (__jsonProps.Contains("duration")) __score1++;
            if (__jsonProps.Contains("request_id")) __score1++;
            if (__jsonProps.Contains("sha256")) __score1++;
            if (__jsonProps.Contains("transaction_key")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("channel")) __score2++;
            if (__jsonProps.Contains("last_word_end")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("channel")) __score3++;
            if (__jsonProps.Contains("timestamp")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::Deepgram.Realtime.ListenV1ListenV1Results? listenV1ListenV1Results = default;
            global::Deepgram.Realtime.ListenV1ListenV1Metadata? listenV1ListenV1Metadata = default;
            global::Deepgram.Realtime.ListenV1ListenV1UtteranceEnd? listenV1ListenV1UtteranceEnd = default;
            global::Deepgram.Realtime.ListenV1ListenV1SpeechStarted? listenV1ListenV1SpeechStarted = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV1ListenV1Results), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV1ListenV1Results> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV1ListenV1Results).Name}");
                        listenV1ListenV1Results = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV1ListenV1Metadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV1ListenV1Metadata> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV1ListenV1Metadata).Name}");
                        listenV1ListenV1Metadata = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV1ListenV1UtteranceEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV1ListenV1UtteranceEnd> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV1ListenV1UtteranceEnd).Name}");
                        listenV1ListenV1UtteranceEnd = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV1ListenV1SpeechStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV1ListenV1SpeechStarted> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV1ListenV1SpeechStarted).Name}");
                        listenV1ListenV1SpeechStarted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (listenV1ListenV1Results == null && listenV1ListenV1Metadata == null && listenV1ListenV1UtteranceEnd == null && listenV1ListenV1SpeechStarted == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV1ListenV1Results), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV1ListenV1Results> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV1ListenV1Results).Name}");
                    listenV1ListenV1Results = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV1ListenV1Metadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV1ListenV1Metadata> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV1ListenV1Metadata).Name}");
                    listenV1ListenV1Metadata = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV1ListenV1UtteranceEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV1ListenV1UtteranceEnd> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV1ListenV1UtteranceEnd).Name}");
                    listenV1ListenV1UtteranceEnd = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV1ListenV1SpeechStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV1ListenV1SpeechStarted> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV1ListenV1SpeechStarted).Name}");
                    listenV1ListenV1SpeechStarted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Deepgram.Realtime.ListenV1ServerEvent(
                listenV1ListenV1Results,

                listenV1ListenV1Metadata,

                listenV1ListenV1UtteranceEnd,

                listenV1ListenV1SpeechStarted
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.Realtime.ListenV1ServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsListenV1ListenV1Results)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV1ListenV1Results), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV1ListenV1Results?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV1ListenV1Results).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListenV1ListenV1Results!, typeInfo);
            }
            else if (value.IsListenV1ListenV1Metadata)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV1ListenV1Metadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV1ListenV1Metadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV1ListenV1Metadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListenV1ListenV1Metadata!, typeInfo);
            }
            else if (value.IsListenV1ListenV1UtteranceEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV1ListenV1UtteranceEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV1ListenV1UtteranceEnd?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV1ListenV1UtteranceEnd).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListenV1ListenV1UtteranceEnd!, typeInfo);
            }
            else if (value.IsListenV1ListenV1SpeechStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV1ListenV1SpeechStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV1ListenV1SpeechStarted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV1ListenV1SpeechStarted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListenV1ListenV1SpeechStarted!, typeInfo);
            }
        }
    }
}