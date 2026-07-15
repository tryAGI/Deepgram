#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Deepgram.JsonConverters
{
    /// <inheritdoc />
    public class V2SpeakPostParametersBitRateJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.V2SpeakPostParametersBitRate>
    {
        /// <inheritdoc />
        public override global::Deepgram.V2SpeakPostParametersBitRate Read(
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersBitRate0), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(int), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(int), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score2++;
                    }
                }
            }
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Deepgram.V2SpeakPostParametersBitRate0? v2SpeakPostParametersBitRate0 = default;
            int? v2SpeakPostParametersBitRateVariant2 = default;
            int? v2SpeakPostParametersBitRateVariant3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersBitRate0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersBitRate0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersBitRate0).Name}");
                        v2SpeakPostParametersBitRate0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(int), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<int> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(int).Name}");
                        v2SpeakPostParametersBitRateVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(int), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<int> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(int).Name}");
                        v2SpeakPostParametersBitRateVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (v2SpeakPostParametersBitRate0 == null && v2SpeakPostParametersBitRateVariant2 == null && v2SpeakPostParametersBitRateVariant3 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersBitRate0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersBitRate0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersBitRate0).Name}");
                    v2SpeakPostParametersBitRate0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (v2SpeakPostParametersBitRate0 == null && v2SpeakPostParametersBitRateVariant2 == null && v2SpeakPostParametersBitRateVariant3 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(int), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<int> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(int).Name}");
                    v2SpeakPostParametersBitRateVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (v2SpeakPostParametersBitRate0 == null && v2SpeakPostParametersBitRateVariant2 == null && v2SpeakPostParametersBitRateVariant3 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(int), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<int> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(int).Name}");
                    v2SpeakPostParametersBitRateVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Deepgram.V2SpeakPostParametersBitRate(
                v2SpeakPostParametersBitRate0,

                v2SpeakPostParametersBitRateVariant2,

                v2SpeakPostParametersBitRateVariant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.V2SpeakPostParametersBitRate value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsV2SpeakPostParametersBitRate0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V2SpeakPostParametersBitRate0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V2SpeakPostParametersBitRate0> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V2SpeakPostParametersBitRate0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.V2SpeakPostParametersBitRate0!.Value, typeInfo);
            }
            else if (value.IsV2SpeakPostParametersBitRateVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(int), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<int> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(int).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.V2SpeakPostParametersBitRateVariant2!.Value, typeInfo);
            }
            else if (value.IsV2SpeakPostParametersBitRateVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(int), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<int> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(int).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.V2SpeakPostParametersBitRateVariant3!.Value, typeInfo);
            }
        }
    }
}