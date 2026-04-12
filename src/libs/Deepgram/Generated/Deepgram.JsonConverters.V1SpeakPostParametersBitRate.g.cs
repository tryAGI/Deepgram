#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Deepgram.JsonConverters
{
    /// <inheritdoc />
    public class V1SpeakPostParametersBitRateJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.V1SpeakPostParametersBitRate>
    {
        /// <inheritdoc />
        public override global::Deepgram.V1SpeakPostParametersBitRate Read(
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V1SpeakPostParametersBitRate0), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(double), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(double), options);
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

            global::Deepgram.V1SpeakPostParametersBitRate0? v1SpeakPostParametersBitRate0 = default;
            double? v1SpeakPostParametersBitRateVariant2 = default;
            double? v1SpeakPostParametersBitRateVariant3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V1SpeakPostParametersBitRate0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V1SpeakPostParametersBitRate0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V1SpeakPostParametersBitRate0).Name}");
                        v1SpeakPostParametersBitRate0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(double), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<double> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(double).Name}");
                        v1SpeakPostParametersBitRateVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(double), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<double> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(double).Name}");
                        v1SpeakPostParametersBitRateVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (v1SpeakPostParametersBitRate0 == null && v1SpeakPostParametersBitRateVariant2 == null && v1SpeakPostParametersBitRateVariant3 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V1SpeakPostParametersBitRate0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V1SpeakPostParametersBitRate0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V1SpeakPostParametersBitRate0).Name}");
                    v1SpeakPostParametersBitRate0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(double), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<double> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(double).Name}");
                    v1SpeakPostParametersBitRateVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(double), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<double> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(double).Name}");
                    v1SpeakPostParametersBitRateVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Deepgram.V1SpeakPostParametersBitRate(
                v1SpeakPostParametersBitRate0,

                v1SpeakPostParametersBitRateVariant2,

                v1SpeakPostParametersBitRateVariant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.V1SpeakPostParametersBitRate value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsV1SpeakPostParametersBitRate0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.V1SpeakPostParametersBitRate0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.V1SpeakPostParametersBitRate0> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.V1SpeakPostParametersBitRate0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.V1SpeakPostParametersBitRate0!.Value, typeInfo);
            }
            else if (value.IsV1SpeakPostParametersBitRateVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(double), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<double> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(double).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.V1SpeakPostParametersBitRateVariant2!.Value, typeInfo);
            }
            else if (value.IsV1SpeakPostParametersBitRateVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(double), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<double> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(double).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.V1SpeakPostParametersBitRateVariant3!.Value, typeInfo);
            }
        }
    }
}