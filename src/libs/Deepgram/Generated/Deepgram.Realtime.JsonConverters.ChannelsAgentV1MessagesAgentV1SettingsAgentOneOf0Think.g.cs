#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Deepgram.Realtime.JsonConverters
{
    /// <inheritdoc />
    public class ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ThinkJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think>
    {
        /// <inheritdoc />
        public override global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think Read(
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
            if (__jsonProps.Contains("context_length")) __score0++;
            if (__jsonProps.Contains("endpoint")) __score0++;
            if (__jsonProps.Contains("endpoint.headers")) __score0++;
            if (__jsonProps.Contains("endpoint.url")) __score0++;
            if (__jsonProps.Contains("functions")) __score0++;
            if (__jsonProps.Contains("prompt")) __score0++;
            if (__jsonProps.Contains("provider")) __score0++;
            var __score1 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Deepgram.Realtime.ThinkSettingsV1? thinkSettingsV1 = default;
            global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1>? channelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ThinkSettingsV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ThinkSettingsV1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ThinkSettingsV1).Name}");
                        thinkSettingsV1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1>).Name}");
                        channelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (thinkSettingsV1 == null && channelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ThinkSettingsV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ThinkSettingsV1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ThinkSettingsV1).Name}");
                    thinkSettingsV1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (thinkSettingsV1 == null && channelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1>).Name}");
                    channelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think(
                thinkSettingsV1,

                channelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsThinkSettingsV1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ThinkSettingsV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ThinkSettingsV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ThinkSettingsV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThinkSettingsV1!, typeInfo);
            }
            else if (value.IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1!, typeInfo);
            }
        }
    }
}