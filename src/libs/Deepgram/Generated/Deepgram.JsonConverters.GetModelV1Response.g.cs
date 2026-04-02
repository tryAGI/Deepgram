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
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("uuid")) __score1++;
            if (__jsonProps.Contains("version")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Deepgram.GetModelV1ResponseVariant1? getModelV1ResponseVariant1 = default;
            global::Deepgram.GetModelV1ResponseVariant2? getModelV1ResponseVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        getModelV1ResponseVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::Deepgram.GetModelV1ResponseVariant1>(__rawJson, options);
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
                        getModelV1ResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Deepgram.GetModelV1ResponseVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (getModelV1ResponseVariant1 == null && getModelV1ResponseVariant2 == null)
            {
                try
                {
                    getModelV1ResponseVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::Deepgram.GetModelV1ResponseVariant1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    getModelV1ResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Deepgram.GetModelV1ResponseVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Deepgram.GetModelV1Response(
                getModelV1ResponseVariant1,

                getModelV1ResponseVariant2
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

            if (value.IsGetModelV1ResponseVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetModelV1ResponseVariant1, typeof(global::Deepgram.GetModelV1ResponseVariant1), options);
            }
            else if (value.IsGetModelV1ResponseVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetModelV1ResponseVariant2, typeof(global::Deepgram.GetModelV1ResponseVariant2), options);
            }
        }
    }
}