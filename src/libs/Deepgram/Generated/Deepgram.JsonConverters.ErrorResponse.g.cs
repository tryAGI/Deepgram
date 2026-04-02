#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Deepgram.JsonConverters
{
    /// <inheritdoc />
    public class ErrorResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.ErrorResponse>
    {
        /// <inheritdoc />
        public override global::Deepgram.ErrorResponse Read(
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
            if (__jsonProps.Contains("value")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("err_code")) __score1++;
            if (__jsonProps.Contains("err_msg")) __score1++;
            if (__jsonProps.Contains("request_id")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("category")) __score2++;
            if (__jsonProps.Contains("details")) __score2++;
            if (__jsonProps.Contains("message")) __score2++;
            if (__jsonProps.Contains("request_id")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Deepgram.ErrorResponseTextError? text = default;
            global::Deepgram.ErrorResponseLegacyError? legacy = default;
            global::Deepgram.ErrorResponseModernError? modern = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        text = global::System.Text.Json.JsonSerializer.Deserialize<global::Deepgram.ErrorResponseTextError>(__rawJson, options);
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
                        legacy = global::System.Text.Json.JsonSerializer.Deserialize<global::Deepgram.ErrorResponseLegacyError>(__rawJson, options);
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
                        modern = global::System.Text.Json.JsonSerializer.Deserialize<global::Deepgram.ErrorResponseModernError>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (text == null && legacy == null && modern == null)
            {
                try
                {
                    text = global::System.Text.Json.JsonSerializer.Deserialize<global::Deepgram.ErrorResponseTextError>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    legacy = global::System.Text.Json.JsonSerializer.Deserialize<global::Deepgram.ErrorResponseLegacyError>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    modern = global::System.Text.Json.JsonSerializer.Deserialize<global::Deepgram.ErrorResponseModernError>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Deepgram.ErrorResponse(
                text,

                legacy,

                modern
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.ErrorResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::Deepgram.ErrorResponseTextError), options);
            }
            else if (value.IsLegacy)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Legacy, typeof(global::Deepgram.ErrorResponseLegacyError), options);
            }
            else if (value.IsModern)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Modern, typeof(global::Deepgram.ErrorResponseModernError), options);
            }
        }
    }
}