#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Deepgram.JsonConverters
{
    /// <inheritdoc />
    public class V1SpeakPostParametersSampleRateJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.V1SpeakPostParametersSampleRate>
    {
        /// <inheritdoc />
        public override global::Deepgram.V1SpeakPostParametersSampleRate Read(
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
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V1SpeakPostParametersSampleRate0), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score0++;
                    }
                }
            }
            var __score1 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V1SpeakPostParametersSampleRate1), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score1++;
                    }
                }
            }
            var __score2 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V1SpeakPostParametersSampleRate2), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score2++;
                    }
                }
            }
            var __score3 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V1SpeakPostParametersSampleRate3), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score3++;
                    }
                }
            }
            var __score4 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V1SpeakPostParametersSampleRate4), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score4++;
                    }
                }
            }
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::Deepgram.V1SpeakPostParametersSampleRate0? v1SpeakPostParametersSampleRate0 = default;
            global::Deepgram.V1SpeakPostParametersSampleRate1? v1SpeakPostParametersSampleRate1 = default;
            global::Deepgram.V1SpeakPostParametersSampleRate2? v1SpeakPostParametersSampleRate2 = default;
            global::Deepgram.V1SpeakPostParametersSampleRate3? v1SpeakPostParametersSampleRate3 = default;
            global::Deepgram.V1SpeakPostParametersSampleRate4? v1SpeakPostParametersSampleRate4 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V1SpeakPostParametersSampleRate0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V1SpeakPostParametersSampleRate0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V1SpeakPostParametersSampleRate0).Name}");
                        v1SpeakPostParametersSampleRate0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V1SpeakPostParametersSampleRate1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V1SpeakPostParametersSampleRate1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V1SpeakPostParametersSampleRate1).Name}");
                        v1SpeakPostParametersSampleRate1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V1SpeakPostParametersSampleRate2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V1SpeakPostParametersSampleRate2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V1SpeakPostParametersSampleRate2).Name}");
                        v1SpeakPostParametersSampleRate2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V1SpeakPostParametersSampleRate3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V1SpeakPostParametersSampleRate3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V1SpeakPostParametersSampleRate3).Name}");
                        v1SpeakPostParametersSampleRate3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V1SpeakPostParametersSampleRate4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V1SpeakPostParametersSampleRate4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V1SpeakPostParametersSampleRate4).Name}");
                        v1SpeakPostParametersSampleRate4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (v1SpeakPostParametersSampleRate0 == null && v1SpeakPostParametersSampleRate1 == null && v1SpeakPostParametersSampleRate2 == null && v1SpeakPostParametersSampleRate3 == null && v1SpeakPostParametersSampleRate4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V1SpeakPostParametersSampleRate0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V1SpeakPostParametersSampleRate0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V1SpeakPostParametersSampleRate0).Name}");
                    v1SpeakPostParametersSampleRate0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V1SpeakPostParametersSampleRate1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V1SpeakPostParametersSampleRate1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V1SpeakPostParametersSampleRate1).Name}");
                    v1SpeakPostParametersSampleRate1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V1SpeakPostParametersSampleRate2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V1SpeakPostParametersSampleRate2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V1SpeakPostParametersSampleRate2).Name}");
                    v1SpeakPostParametersSampleRate2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V1SpeakPostParametersSampleRate3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V1SpeakPostParametersSampleRate3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V1SpeakPostParametersSampleRate3).Name}");
                    v1SpeakPostParametersSampleRate3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V1SpeakPostParametersSampleRate4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V1SpeakPostParametersSampleRate4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V1SpeakPostParametersSampleRate4).Name}");
                    v1SpeakPostParametersSampleRate4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Deepgram.V1SpeakPostParametersSampleRate(
                v1SpeakPostParametersSampleRate0,

                v1SpeakPostParametersSampleRate1,

                v1SpeakPostParametersSampleRate2,

                v1SpeakPostParametersSampleRate3,

                v1SpeakPostParametersSampleRate4
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.V1SpeakPostParametersSampleRate value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsV1SpeakPostParametersSampleRate0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V1SpeakPostParametersSampleRate0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V1SpeakPostParametersSampleRate0> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V1SpeakPostParametersSampleRate0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.V1SpeakPostParametersSampleRate0!.Value, typeInfo);
            }
            else if (value.IsV1SpeakPostParametersSampleRate1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V1SpeakPostParametersSampleRate1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V1SpeakPostParametersSampleRate1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V1SpeakPostParametersSampleRate1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.V1SpeakPostParametersSampleRate1!.Value, typeInfo);
            }
            else if (value.IsV1SpeakPostParametersSampleRate2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V1SpeakPostParametersSampleRate2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V1SpeakPostParametersSampleRate2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V1SpeakPostParametersSampleRate2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.V1SpeakPostParametersSampleRate2!.Value, typeInfo);
            }
            else if (value.IsV1SpeakPostParametersSampleRate3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V1SpeakPostParametersSampleRate3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V1SpeakPostParametersSampleRate3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V1SpeakPostParametersSampleRate3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.V1SpeakPostParametersSampleRate3!.Value, typeInfo);
            }
            else if (value.IsV1SpeakPostParametersSampleRate4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V1SpeakPostParametersSampleRate4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V1SpeakPostParametersSampleRate4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V1SpeakPostParametersSampleRate4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.V1SpeakPostParametersSampleRate4!.Value, typeInfo);
            }
        }
    }
}