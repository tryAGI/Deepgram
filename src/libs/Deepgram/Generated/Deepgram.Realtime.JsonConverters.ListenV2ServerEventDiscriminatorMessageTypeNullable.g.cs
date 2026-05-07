#nullable enable

namespace Deepgram.Realtime.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListenV2ServerEventDiscriminatorMessageTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.Realtime.ListenV2ServerEventDiscriminatorMessageType?>
    {
        /// <inheritdoc />
        public override global::Deepgram.Realtime.ListenV2ServerEventDiscriminatorMessageType? Read(
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
                        return global::Deepgram.Realtime.ListenV2ServerEventDiscriminatorMessageTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Deepgram.Realtime.ListenV2ServerEventDiscriminatorMessageType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Deepgram.Realtime.ListenV2ServerEventDiscriminatorMessageType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.Realtime.ListenV2ServerEventDiscriminatorMessageType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Deepgram.Realtime.ListenV2ServerEventDiscriminatorMessageTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
