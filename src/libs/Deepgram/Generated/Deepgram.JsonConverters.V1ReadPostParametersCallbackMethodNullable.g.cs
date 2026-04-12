#nullable enable

namespace Deepgram.JsonConverters
{
    /// <inheritdoc />
    public sealed class V1ReadPostParametersCallbackMethodNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.V1ReadPostParametersCallbackMethod?>
    {
        /// <inheritdoc />
        public override global::Deepgram.V1ReadPostParametersCallbackMethod? Read(
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
                        return global::Deepgram.V1ReadPostParametersCallbackMethodExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Deepgram.V1ReadPostParametersCallbackMethod)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Deepgram.V1ReadPostParametersCallbackMethod?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.V1ReadPostParametersCallbackMethod? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Deepgram.V1ReadPostParametersCallbackMethodExtensions.ToValueString(value.Value));
            }
        }
    }
}
