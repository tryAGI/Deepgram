#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Deepgram.Realtime.JsonConverters
{
    /// <inheritdoc />
    public class SpeakV1ServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.Realtime.SpeakV1ServerEvent>
    {
        /// <inheritdoc />
        public override global::Deepgram.Realtime.SpeakV1ServerEvent Read(
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

                }
            }

            var __score0 = 0;
            var __score1 = 0;
            if (__jsonProps.Contains("model_name")) __score1++;
            if (__jsonProps.Contains("model_uuid")) __score1++;
            if (__jsonProps.Contains("model_version")) __score1++;
            if (__jsonProps.Contains("request_id")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("sequence_id")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("sequence_id")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("code")) __score4++;
            if (__jsonProps.Contains("description")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            byte[]? speakV1SpeakV1Audio = default;
            global::Deepgram.Realtime.SpeakV1SpeakV1Metadata? speakV1SpeakV1Metadata = default;
            global::Deepgram.Realtime.SpeakV1SpeakV1Flushed? speakV1SpeakV1Flushed = default;
            global::Deepgram.Realtime.SpeakV1SpeakV1Cleared? speakV1SpeakV1Cleared = default;
            global::Deepgram.Realtime.SpeakV1SpeakV1Warning? speakV1SpeakV1Warning = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        speakV1SpeakV1Audio = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Metadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV1SpeakV1Metadata> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Metadata).Name}");
                        speakV1SpeakV1Metadata = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Flushed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV1SpeakV1Flushed> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Flushed).Name}");
                        speakV1SpeakV1Flushed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Cleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV1SpeakV1Cleared> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Cleared).Name}");
                        speakV1SpeakV1Cleared = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Warning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV1SpeakV1Warning> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Warning).Name}");
                        speakV1SpeakV1Warning = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (speakV1SpeakV1Audio == null && speakV1SpeakV1Metadata == null && speakV1SpeakV1Flushed == null && speakV1SpeakV1Cleared == null && speakV1SpeakV1Warning == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    speakV1SpeakV1Audio = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Metadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV1SpeakV1Metadata> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Metadata).Name}");
                    speakV1SpeakV1Metadata = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Flushed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV1SpeakV1Flushed> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Flushed).Name}");
                    speakV1SpeakV1Flushed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Cleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV1SpeakV1Cleared> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Cleared).Name}");
                    speakV1SpeakV1Cleared = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Warning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV1SpeakV1Warning> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Warning).Name}");
                    speakV1SpeakV1Warning = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Deepgram.Realtime.SpeakV1ServerEvent(
                speakV1SpeakV1Audio,

                speakV1SpeakV1Metadata,

                speakV1SpeakV1Flushed,

                speakV1SpeakV1Cleared,

                speakV1SpeakV1Warning
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.Realtime.SpeakV1ServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSpeakV1SpeakV1Audio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeakV1SpeakV1Audio!, typeInfo);
            }
            else if (value.IsSpeakV1SpeakV1Metadata)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Metadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV1SpeakV1Metadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Metadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeakV1SpeakV1Metadata!, typeInfo);
            }
            else if (value.IsSpeakV1SpeakV1Flushed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Flushed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV1SpeakV1Flushed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Flushed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeakV1SpeakV1Flushed!, typeInfo);
            }
            else if (value.IsSpeakV1SpeakV1Cleared)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Cleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV1SpeakV1Cleared?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Cleared).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeakV1SpeakV1Cleared!, typeInfo);
            }
            else if (value.IsSpeakV1SpeakV1Warning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Warning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeakV1SpeakV1Warning?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Warning).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeakV1SpeakV1Warning!, typeInfo);
            }
        }
    }
}