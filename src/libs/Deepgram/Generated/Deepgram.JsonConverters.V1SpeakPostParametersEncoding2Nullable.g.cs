#nullable enable

namespace Deepgram.JsonConverters
{
    /// <inheritdoc />
    public sealed class V1SpeakPostParametersEncoding2NullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.V1SpeakPostParametersEncoding2?>
    {
        /// <inheritdoc />
        public override global::Deepgram.V1SpeakPostParametersEncoding2? Read(
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
                        return global::Deepgram.V1SpeakPostParametersEncoding2Extensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Deepgram.V1SpeakPostParametersEncoding2)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Deepgram.V1SpeakPostParametersEncoding2?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.V1SpeakPostParametersEncoding2? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Deepgram.V1SpeakPostParametersEncoding2Extensions.ToValueString(value.Value));
            }
        }
    }
}
