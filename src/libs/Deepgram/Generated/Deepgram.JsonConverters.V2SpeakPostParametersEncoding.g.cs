#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Deepgram.JsonConverters
{
    /// <inheritdoc />
    public class V2SpeakPostParametersEncodingJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.V2SpeakPostParametersEncoding>
    {
        /// <inheritdoc />
        public override global::Deepgram.V2SpeakPostParametersEncoding Read(
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersEncoding0), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersEncoding1), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersEncoding2), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersEncoding3), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersEncoding4), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score4++;
                    }
                }
            }
            var __score5 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersEncoding5), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score5++;
                    }
                }
            }
            var __score6 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersEncoding6), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score6++;
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
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }

            global::Deepgram.V2SpeakPostParametersEncoding0? v2SpeakPostParametersEncoding0 = default;
            global::Deepgram.V2SpeakPostParametersEncoding1? v2SpeakPostParametersEncoding1 = default;
            global::Deepgram.V2SpeakPostParametersEncoding2? v2SpeakPostParametersEncoding2 = default;
            global::Deepgram.V2SpeakPostParametersEncoding3? v2SpeakPostParametersEncoding3 = default;
            global::Deepgram.V2SpeakPostParametersEncoding4? v2SpeakPostParametersEncoding4 = default;
            global::Deepgram.V2SpeakPostParametersEncoding5? v2SpeakPostParametersEncoding5 = default;
            global::Deepgram.V2SpeakPostParametersEncoding6? v2SpeakPostParametersEncoding6 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersEncoding0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersEncoding0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersEncoding0).Name}");
                        v2SpeakPostParametersEncoding0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersEncoding1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersEncoding1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersEncoding1).Name}");
                        v2SpeakPostParametersEncoding1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersEncoding2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersEncoding2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersEncoding2).Name}");
                        v2SpeakPostParametersEncoding2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersEncoding3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersEncoding3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersEncoding3).Name}");
                        v2SpeakPostParametersEncoding3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersEncoding4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersEncoding4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersEncoding4).Name}");
                        v2SpeakPostParametersEncoding4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersEncoding5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersEncoding5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersEncoding5).Name}");
                        v2SpeakPostParametersEncoding5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersEncoding6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersEncoding6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersEncoding6).Name}");
                        v2SpeakPostParametersEncoding6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (v2SpeakPostParametersEncoding0 == null && v2SpeakPostParametersEncoding1 == null && v2SpeakPostParametersEncoding2 == null && v2SpeakPostParametersEncoding3 == null && v2SpeakPostParametersEncoding4 == null && v2SpeakPostParametersEncoding5 == null && v2SpeakPostParametersEncoding6 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersEncoding0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersEncoding0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersEncoding0).Name}");
                    v2SpeakPostParametersEncoding0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (v2SpeakPostParametersEncoding0 == null && v2SpeakPostParametersEncoding1 == null && v2SpeakPostParametersEncoding2 == null && v2SpeakPostParametersEncoding3 == null && v2SpeakPostParametersEncoding4 == null && v2SpeakPostParametersEncoding5 == null && v2SpeakPostParametersEncoding6 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersEncoding1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersEncoding1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersEncoding1).Name}");
                    v2SpeakPostParametersEncoding1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (v2SpeakPostParametersEncoding0 == null && v2SpeakPostParametersEncoding1 == null && v2SpeakPostParametersEncoding2 == null && v2SpeakPostParametersEncoding3 == null && v2SpeakPostParametersEncoding4 == null && v2SpeakPostParametersEncoding5 == null && v2SpeakPostParametersEncoding6 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersEncoding2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersEncoding2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersEncoding2).Name}");
                    v2SpeakPostParametersEncoding2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (v2SpeakPostParametersEncoding0 == null && v2SpeakPostParametersEncoding1 == null && v2SpeakPostParametersEncoding2 == null && v2SpeakPostParametersEncoding3 == null && v2SpeakPostParametersEncoding4 == null && v2SpeakPostParametersEncoding5 == null && v2SpeakPostParametersEncoding6 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersEncoding3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersEncoding3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersEncoding3).Name}");
                    v2SpeakPostParametersEncoding3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (v2SpeakPostParametersEncoding0 == null && v2SpeakPostParametersEncoding1 == null && v2SpeakPostParametersEncoding2 == null && v2SpeakPostParametersEncoding3 == null && v2SpeakPostParametersEncoding4 == null && v2SpeakPostParametersEncoding5 == null && v2SpeakPostParametersEncoding6 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersEncoding4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersEncoding4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersEncoding4).Name}");
                    v2SpeakPostParametersEncoding4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (v2SpeakPostParametersEncoding0 == null && v2SpeakPostParametersEncoding1 == null && v2SpeakPostParametersEncoding2 == null && v2SpeakPostParametersEncoding3 == null && v2SpeakPostParametersEncoding4 == null && v2SpeakPostParametersEncoding5 == null && v2SpeakPostParametersEncoding6 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersEncoding5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersEncoding5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersEncoding5).Name}");
                    v2SpeakPostParametersEncoding5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (v2SpeakPostParametersEncoding0 == null && v2SpeakPostParametersEncoding1 == null && v2SpeakPostParametersEncoding2 == null && v2SpeakPostParametersEncoding3 == null && v2SpeakPostParametersEncoding4 == null && v2SpeakPostParametersEncoding5 == null && v2SpeakPostParametersEncoding6 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersEncoding6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersEncoding6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersEncoding6).Name}");
                    v2SpeakPostParametersEncoding6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Deepgram.V2SpeakPostParametersEncoding(
                v2SpeakPostParametersEncoding0,

                v2SpeakPostParametersEncoding1,

                v2SpeakPostParametersEncoding2,

                v2SpeakPostParametersEncoding3,

                v2SpeakPostParametersEncoding4,

                v2SpeakPostParametersEncoding5,

                v2SpeakPostParametersEncoding6
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.V2SpeakPostParametersEncoding value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsV2SpeakPostParametersEncoding0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersEncoding0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersEncoding0> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersEncoding0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.V2SpeakPostParametersEncoding0!.Value, typeInfo);
            }
            else if (value.IsV2SpeakPostParametersEncoding1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersEncoding1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersEncoding1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersEncoding1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.V2SpeakPostParametersEncoding1!.Value, typeInfo);
            }
            else if (value.IsV2SpeakPostParametersEncoding2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersEncoding2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersEncoding2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersEncoding2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.V2SpeakPostParametersEncoding2!.Value, typeInfo);
            }
            else if (value.IsV2SpeakPostParametersEncoding3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersEncoding3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersEncoding3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersEncoding3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.V2SpeakPostParametersEncoding3!.Value, typeInfo);
            }
            else if (value.IsV2SpeakPostParametersEncoding4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersEncoding4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersEncoding4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersEncoding4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.V2SpeakPostParametersEncoding4!.Value, typeInfo);
            }
            else if (value.IsV2SpeakPostParametersEncoding5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersEncoding5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersEncoding5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersEncoding5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.V2SpeakPostParametersEncoding5!.Value, typeInfo);
            }
            else if (value.IsV2SpeakPostParametersEncoding6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersEncoding6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersEncoding6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersEncoding6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.V2SpeakPostParametersEncoding6!.Value, typeInfo);
            }
        }
    }
}