#nullable enable

namespace Deepgram.Realtime.JsonConverters
{
    /// <inheritdoc />
    public sealed class DeepgramThinkProviderModelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.Realtime.DeepgramThinkProviderModel?>
    {
        /// <inheritdoc />
        public override global::Deepgram.Realtime.DeepgramThinkProviderModel? Read(
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
                        return global::Deepgram.Realtime.DeepgramThinkProviderModelExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Deepgram.Realtime.DeepgramThinkProviderModel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Deepgram.Realtime.DeepgramThinkProviderModel?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.Realtime.DeepgramThinkProviderModel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Deepgram.Realtime.DeepgramThinkProviderModelExtensions.ToValueString(value.Value));
            }
        }
    }
}
