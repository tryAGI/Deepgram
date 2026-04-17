#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Deepgram.JsonConverters
{
    /// <inheritdoc />
    public class AgentThinkModelsV1ResponseModelsItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.AgentThinkModelsV1ResponseModelsItems>
    {
        /// <inheritdoc />
        public override global::Deepgram.AgentThinkModelsV1ResponseModelsItems Read(
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
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("provider")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("provider")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("provider")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("provider")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("id")) __score4++;
            if (__jsonProps.Contains("name")) __score4++;
            if (__jsonProps.Contains("provider")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::Deepgram.AgentThinkModelsV1ResponseModelsItems0? agentThinkModelsV1ResponseModelsItems0 = default;
            global::Deepgram.AgentThinkModelsV1ResponseModelsItems1? agentThinkModelsV1ResponseModelsItems1 = default;
            global::Deepgram.AgentThinkModelsV1ResponseModelsItems2? agentThinkModelsV1ResponseModelsItems2 = default;
            global::Deepgram.AgentThinkModelsV1ResponseModelsItems3? agentThinkModelsV1ResponseModelsItems3 = default;
            global::Deepgram.AgentThinkModelsV1ResponseModelsItems4? agentThinkModelsV1ResponseModelsItems4 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.AgentThinkModelsV1ResponseModelsItems0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems0).Name}");
                        agentThinkModelsV1ResponseModelsItems0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.AgentThinkModelsV1ResponseModelsItems1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems1).Name}");
                        agentThinkModelsV1ResponseModelsItems1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.AgentThinkModelsV1ResponseModelsItems2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems2).Name}");
                        agentThinkModelsV1ResponseModelsItems2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.AgentThinkModelsV1ResponseModelsItems3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems3).Name}");
                        agentThinkModelsV1ResponseModelsItems3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.AgentThinkModelsV1ResponseModelsItems4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems4).Name}");
                        agentThinkModelsV1ResponseModelsItems4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (agentThinkModelsV1ResponseModelsItems0 == null && agentThinkModelsV1ResponseModelsItems1 == null && agentThinkModelsV1ResponseModelsItems2 == null && agentThinkModelsV1ResponseModelsItems3 == null && agentThinkModelsV1ResponseModelsItems4 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.AgentThinkModelsV1ResponseModelsItems0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems0).Name}");
                    agentThinkModelsV1ResponseModelsItems0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.AgentThinkModelsV1ResponseModelsItems1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems1).Name}");
                    agentThinkModelsV1ResponseModelsItems1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.AgentThinkModelsV1ResponseModelsItems2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems2).Name}");
                    agentThinkModelsV1ResponseModelsItems2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.AgentThinkModelsV1ResponseModelsItems3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems3).Name}");
                    agentThinkModelsV1ResponseModelsItems3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.AgentThinkModelsV1ResponseModelsItems4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems4).Name}");
                    agentThinkModelsV1ResponseModelsItems4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Deepgram.AgentThinkModelsV1ResponseModelsItems(
                agentThinkModelsV1ResponseModelsItems0,

                agentThinkModelsV1ResponseModelsItems1,

                agentThinkModelsV1ResponseModelsItems2,

                agentThinkModelsV1ResponseModelsItems3,

                agentThinkModelsV1ResponseModelsItems4
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.AgentThinkModelsV1ResponseModelsItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAgentThinkModelsV1ResponseModelsItems0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.AgentThinkModelsV1ResponseModelsItems0?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentThinkModelsV1ResponseModelsItems0!, typeInfo);
            }
            else if (value.IsAgentThinkModelsV1ResponseModelsItems1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.AgentThinkModelsV1ResponseModelsItems1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentThinkModelsV1ResponseModelsItems1!, typeInfo);
            }
            else if (value.IsAgentThinkModelsV1ResponseModelsItems2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.AgentThinkModelsV1ResponseModelsItems2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentThinkModelsV1ResponseModelsItems2!, typeInfo);
            }
            else if (value.IsAgentThinkModelsV1ResponseModelsItems3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.AgentThinkModelsV1ResponseModelsItems3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentThinkModelsV1ResponseModelsItems3!, typeInfo);
            }
            else if (value.IsAgentThinkModelsV1ResponseModelsItems4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.AgentThinkModelsV1ResponseModelsItems4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentThinkModelsV1ResponseModelsItems4!, typeInfo);
            }
        }
    }
}