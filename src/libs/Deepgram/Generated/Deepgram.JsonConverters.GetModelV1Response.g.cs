#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Deepgram.JsonConverters
{
    /// <inheritdoc />
    public class GetModelV1ResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.GetModelV1Response>
    {
        /// <inheritdoc />
        public override global::Deepgram.GetModelV1Response Read(
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
            if (__jsonProps.Contains("architecture")) __score0++;
            if (__jsonProps.Contains("batch")) __score0++;
            if (__jsonProps.Contains("canonical_name")) __score0++;
            if (__jsonProps.Contains("formatted_output")) __score0++;
            if (__jsonProps.Contains("languages")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("streaming")) __score0++;
            if (__jsonProps.Contains("uuid")) __score0++;
            if (__jsonProps.Contains("version")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("architecture")) __score1++;
            if (__jsonProps.Contains("canonical_name")) __score1++;
            if (__jsonProps.Contains("languages")) __score1++;
            if (__jsonProps.Contains("metadata")) __score1++;
            if (__jsonProps.Contains("metadata.accent")) __score1++;
            if (__jsonProps.Contains("metadata.age")) __score1++;
            if (__jsonProps.Contains("metadata.color")) __score1++;
            if (__jsonProps.Contains("metadata.image")) __score1++;
            if (__jsonProps.Contains("metadata.sample")) __score1++;
            if (__jsonProps.Contains("metadata.tags")) __score1++;
            if (__jsonProps.Contains("metadata.use_cases")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("uuid")) __score1++;
            if (__jsonProps.Contains("version")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Deepgram.GetModelV1Response0? getModelV1Response0 = default;
            global::Deepgram.GetModelV1Response1? getModelV1Response1 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.GetModelV1Response0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.GetModelV1Response0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.GetModelV1Response0).Name}");
                        getModelV1Response0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.GetModelV1Response1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.GetModelV1Response1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.GetModelV1Response1).Name}");
                        getModelV1Response1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (getModelV1Response0 == null && getModelV1Response1 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.GetModelV1Response0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.GetModelV1Response0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.GetModelV1Response0).Name}");
                    getModelV1Response0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (getModelV1Response0 == null && getModelV1Response1 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.GetModelV1Response1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.GetModelV1Response1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.GetModelV1Response1).Name}");
                    getModelV1Response1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Deepgram.GetModelV1Response(
                getModelV1Response0,

                getModelV1Response1
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.GetModelV1Response value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGetModelV1Response0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.GetModelV1Response0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.GetModelV1Response0?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.GetModelV1Response0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetModelV1Response0!, typeInfo);
            }
            else if (value.IsGetModelV1Response1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.GetModelV1Response1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.GetModelV1Response1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.GetModelV1Response1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetModelV1Response1!, typeInfo);
            }
        }
    }
}