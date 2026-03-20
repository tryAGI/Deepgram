#nullable enable

namespace Deepgram.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReadV1TextAnalyzeCustomIntentModeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.ReadV1TextAnalyzeCustomIntentMode?>
    {
        /// <inheritdoc />
        public override global::Deepgram.ReadV1TextAnalyzeCustomIntentMode? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Deepgram.ReadV1TextAnalyzeCustomIntentModeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Deepgram.ReadV1TextAnalyzeCustomIntentMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Deepgram.ReadV1TextAnalyzeCustomIntentMode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.ReadV1TextAnalyzeCustomIntentMode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Deepgram.ReadV1TextAnalyzeCustomIntentModeExtensions.ToValueString(value.Value));
            }
        }
    }
}
