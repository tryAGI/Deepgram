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
            if (__jsonProps.Contains("controls_applied.pronunciation_warnings")) __score3++;
            if (__jsonProps.Contains("controls_applied.pronunciations_applied")) __score3++;
            if (__jsonProps.Contains("input_character_count")) __score3++;
            if (__jsonProps.Contains("speech_id")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("speech_id")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("total_audio_duration_ms")) __score5++;
            if (__jsonProps.Contains("total_billable_character_count")) __score5++;
            if (__jsonProps.Contains("total_input_character_count")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("code")) __score6++;
            if (__jsonProps.Contains("description")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("code")) __score7++;
            if (__jsonProps.Contains("description")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
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

            byte[]? speakV2SpeakV2Audio = default;
            global::Deepgram.Realtime.SpeakV2SpeakV2Connected? speakV2SpeakV2Connected = default;
            global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted? speakV2SpeakV2SpeechStarted = default;
            global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata? speakV2SpeakV2SpeechMetadata = default;
            global::Deepgram.Realtime.SpeakV2SpeakV2Flushed? speakV2SpeakV2Flushed = default;
            global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata? speakV2SpeakV2SessionMetadata = default;
            global::Deepgram.Realtime.SpeakV2SpeakV2Warning? speakV2SpeakV2Warning = default;
            global::Deepgram.Realtime.SpeakV2SpeakV2Error? speakV2SpeakV2Error = default;
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
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Connected), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2Connected> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Connected).Name}");
                        speakV2SpeakV2Connected = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted).Name}");
                        speakV2SpeakV2SpeechStarted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata).Name}");
                        speakV2SpeakV2SpeechMetadata = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Flushed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2Flushed> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Flushed).Name}");
                        speakV2SpeakV2Flushed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata).Name}");
                        speakV2SpeakV2SessionMetadata = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Warning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2Warning> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Warning).Name}");
                        speakV2SpeakV2Warning = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Error), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2Error> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Error).Name}");
                        speakV2SpeakV2Error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (speakV2SpeakV2Audio == null && speakV2SpeakV2Connected == null && speakV2SpeakV2SpeechStarted == null && speakV2SpeakV2SpeechMetadata == null && speakV2SpeakV2Flushed == null && speakV2SpeakV2SessionMetadata == null && speakV2SpeakV2Warning == null && speakV2SpeakV2Error == null)
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
            }

            if (speakV2SpeakV2Audio == null && speakV2SpeakV2Connected == null && speakV2SpeakV2SpeechStarted == null && speakV2SpeakV2SpeechMetadata == null && speakV2SpeakV2Flushed == null && speakV2SpeakV2SessionMetadata == null && speakV2SpeakV2Warning == null && speakV2SpeakV2Error == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Connected), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2Connected> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Connected).Name}");
                    speakV2SpeakV2Connected = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (speakV2SpeakV2Audio == null && speakV2SpeakV2Connected == null && speakV2SpeakV2SpeechStarted == null && speakV2SpeakV2SpeechMetadata == null && speakV2SpeakV2Flushed == null && speakV2SpeakV2SessionMetadata == null && speakV2SpeakV2Warning == null && speakV2SpeakV2Error == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted).Name}");
                    speakV2SpeakV2SpeechStarted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (speakV2SpeakV2Audio == null && speakV2SpeakV2Connected == null && speakV2SpeakV2SpeechStarted == null && speakV2SpeakV2SpeechMetadata == null && speakV2SpeakV2Flushed == null && speakV2SpeakV2SessionMetadata == null && speakV2SpeakV2Warning == null && speakV2SpeakV2Error == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata).Name}");
                    speakV2SpeakV2SpeechMetadata = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (speakV2SpeakV2Audio == null && speakV2SpeakV2Connected == null && speakV2SpeakV2SpeechStarted == null && speakV2SpeakV2SpeechMetadata == null && speakV2SpeakV2Flushed == null && speakV2SpeakV2SessionMetadata == null && speakV2SpeakV2Warning == null && speakV2SpeakV2Error == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Flushed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2Flushed> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Flushed).Name}");
                    speakV2SpeakV2Flushed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (speakV2SpeakV2Audio == null && speakV2SpeakV2Connected == null && speakV2SpeakV2SpeechStarted == null && speakV2SpeakV2SpeechMetadata == null && speakV2SpeakV2Flushed == null && speakV2SpeakV2SessionMetadata == null && speakV2SpeakV2Warning == null && speakV2SpeakV2Error == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata).Name}");
                    speakV2SpeakV2SessionMetadata = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (speakV2SpeakV2Audio == null && speakV2SpeakV2Connected == null && speakV2SpeakV2SpeechStarted == null && speakV2SpeakV2SpeechMetadata == null && speakV2SpeakV2Flushed == null && speakV2SpeakV2SessionMetadata == null && speakV2SpeakV2Warning == null && speakV2SpeakV2Error == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Warning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2Warning> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Warning).Name}");
                    speakV2SpeakV2Warning = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (speakV2SpeakV2Audio == null && speakV2SpeakV2Connected == null && speakV2SpeakV2SpeechStarted == null && speakV2SpeakV2SpeechMetadata == null && speakV2SpeakV2Flushed == null && speakV2SpeakV2SessionMetadata == null && speakV2SpeakV2Warning == null && speakV2SpeakV2Error == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Error), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2Error> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Error).Name}");
                    speakV2SpeakV2Error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Deepgram.Realtime.VsServerEvent(
                speakV2SpeakV2Audio,

                speakV2SpeakV2Connected,

                speakV2SpeakV2SpeechStarted,

                speakV2SpeakV2SpeechMetadata,

                speakV2SpeakV2Flushed,

                speakV2SpeakV2SessionMetadata,

                speakV2SpeakV2Warning,

                speakV2SpeakV2Error
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
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeakV2SpeakV2Audio!, typeInfo);
            }
            else if (value.IsSpeakV2SpeakV2Connected)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Connected), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2Connected?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Connected).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeakV2SpeakV2Connected!, typeInfo);
            }
            else if (value.IsSpeakV2SpeakV2SpeechStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeakV2SpeakV2SpeechStarted!, typeInfo);
            }
            else if (value.IsSpeakV2SpeakV2SpeechMetadata)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeakV2SpeakV2SpeechMetadata!, typeInfo);
            }
            else if (value.IsSpeakV2SpeakV2Flushed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Flushed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2Flushed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Flushed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeakV2SpeakV2Flushed!, typeInfo);
            }
            else if (value.IsSpeakV2SpeakV2SessionMetadata)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeakV2SpeakV2SessionMetadata!, typeInfo);
            }
            else if (value.IsSpeakV2SpeakV2Warning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Warning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2Warning?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Warning).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeakV2SpeakV2Warning!, typeInfo);
            }
            else if (value.IsSpeakV2SpeakV2Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Error), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV2SpeakV2Error?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Error).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeakV2SpeakV2Error!, typeInfo);
            }
        }
    }
}