#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Deepgram.Realtime.JsonConverters
{
    /// <inheritdoc />
    public class ChannelsAgentV1MessagesAgentV1SettingsAgentListenProviderJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider>
    {
        /// <inheritdoc />
        public override global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider Read(
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
            if (__jsonProps.Contains("keyterms")) __score0++;
            if (__jsonProps.Contains("language")) __score0++;
            if (__jsonProps.Contains("model")) __score0++;
            if (__jsonProps.Contains("smart_format")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("version")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("keyterms")) __score1++;
            if (__jsonProps.Contains("language_hint")) __score1++;
            if (__jsonProps.Contains("model")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("version")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0? channelsAgentV1MessagesAgentV1SettingsAgentListenProvider0 = default;
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1? channelsAgentV1MessagesAgentV1SettingsAgentListenProvider1 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0).Name}");
                        channelsAgentV1MessagesAgentV1SettingsAgentListenProvider0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1).Name}");
                        channelsAgentV1MessagesAgentV1SettingsAgentListenProvider1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (channelsAgentV1MessagesAgentV1SettingsAgentListenProvider0 == null && channelsAgentV1MessagesAgentV1SettingsAgentListenProvider1 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0).Name}");
                    channelsAgentV1MessagesAgentV1SettingsAgentListenProvider0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1).Name}");
                    channelsAgentV1MessagesAgentV1SettingsAgentListenProvider1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider(
                channelsAgentV1MessagesAgentV1SettingsAgentListenProvider0,

                channelsAgentV1MessagesAgentV1SettingsAgentListenProvider1
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0!, typeInfo);
            }
            else if (value.IsChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1!, typeInfo);
            }
        }
    }
}