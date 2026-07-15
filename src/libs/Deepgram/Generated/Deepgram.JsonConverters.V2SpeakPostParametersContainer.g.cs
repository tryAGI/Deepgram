#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Deepgram.JsonConverters
{
    /// <inheritdoc />
    public class V2SpeakPostParametersContainerJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.V2SpeakPostParametersContainer>
    {
        /// <inheritdoc />
        public override global::Deepgram.V2SpeakPostParametersContainer Read(
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersContainer0), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersContainer1), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersContainer2), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersContainer3), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersContainer4), options);
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

            global::Deepgram.V2SpeakPostParametersContainer0? v2SpeakPostParametersContainer0 = default;
            global::Deepgram.V2SpeakPostParametersContainer1? v2SpeakPostParametersContainer1 = default;
            global::Deepgram.V2SpeakPostParametersContainer2? v2SpeakPostParametersContainer2 = default;
            global::Deepgram.V2SpeakPostParametersContainer3? v2SpeakPostParametersContainer3 = default;
            global::Deepgram.V2SpeakPostParametersContainer4? v2SpeakPostParametersContainer4 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersContainer0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersContainer0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersContainer0).Name}");
                        v2SpeakPostParametersContainer0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersContainer1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersContainer1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersContainer1).Name}");
                        v2SpeakPostParametersContainer1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersContainer2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersContainer2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersContainer2).Name}");
                        v2SpeakPostParametersContainer2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersContainer3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersContainer3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersContainer3).Name}");
                        v2SpeakPostParametersContainer3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersContainer4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersContainer4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersContainer4).Name}");
                        v2SpeakPostParametersContainer4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (v2SpeakPostParametersContainer0 == null && v2SpeakPostParametersContainer1 == null && v2SpeakPostParametersContainer2 == null && v2SpeakPostParametersContainer3 == null && v2SpeakPostParametersContainer4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersContainer0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersContainer0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersContainer0).Name}");
                    v2SpeakPostParametersContainer0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (v2SpeakPostParametersContainer0 == null && v2SpeakPostParametersContainer1 == null && v2SpeakPostParametersContainer2 == null && v2SpeakPostParametersContainer3 == null && v2SpeakPostParametersContainer4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersContainer1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersContainer1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersContainer1).Name}");
                    v2SpeakPostParametersContainer1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (v2SpeakPostParametersContainer0 == null && v2SpeakPostParametersContainer1 == null && v2SpeakPostParametersContainer2 == null && v2SpeakPostParametersContainer3 == null && v2SpeakPostParametersContainer4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersContainer2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersContainer2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersContainer2).Name}");
                    v2SpeakPostParametersContainer2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (v2SpeakPostParametersContainer0 == null && v2SpeakPostParametersContainer1 == null && v2SpeakPostParametersContainer2 == null && v2SpeakPostParametersContainer3 == null && v2SpeakPostParametersContainer4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersContainer3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersContainer3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersContainer3).Name}");
                    v2SpeakPostParametersContainer3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (v2SpeakPostParametersContainer0 == null && v2SpeakPostParametersContainer1 == null && v2SpeakPostParametersContainer2 == null && v2SpeakPostParametersContainer3 == null && v2SpeakPostParametersContainer4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersContainer4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersContainer4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersContainer4).Name}");
                    v2SpeakPostParametersContainer4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Deepgram.V2SpeakPostParametersContainer(
                v2SpeakPostParametersContainer0,

                v2SpeakPostParametersContainer1,

                v2SpeakPostParametersContainer2,

                v2SpeakPostParametersContainer3,

                v2SpeakPostParametersContainer4
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.V2SpeakPostParametersContainer value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsV2SpeakPostParametersContainer0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersContainer0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersContainer0> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersContainer0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.V2SpeakPostParametersContainer0!.Value, typeInfo);
            }
            else if (value.IsV2SpeakPostParametersContainer1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersContainer1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersContainer1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersContainer1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.V2SpeakPostParametersContainer1!.Value, typeInfo);
            }
            else if (value.IsV2SpeakPostParametersContainer2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersContainer2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersContainer2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersContainer2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.V2SpeakPostParametersContainer2!.Value, typeInfo);
            }
            else if (value.IsV2SpeakPostParametersContainer3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersContainer3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersContainer3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersContainer3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.V2SpeakPostParametersContainer3!.Value, typeInfo);
            }
            else if (value.IsV2SpeakPostParametersContainer4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersContainer4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersContainer4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersContainer4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.V2SpeakPostParametersContainer4!.Value, typeInfo);
            }
        }
    }
}