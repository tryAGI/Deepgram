#nullable enable

namespace Deepgram.Realtime.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChannelsListenV1MessagesListenV1ConfigureSuccessTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ConfigureSuccessType>
    {
        /// <inheritdoc />
        public override global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ConfigureSuccessType Read(
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
                        return global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ConfigureSuccessTypeExtensions.ToEnum(stringValue) ?? throw new global::System.Text.Json.JsonException($"Unknown discriminator value '{stringValue}' for global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ConfigureSuccessType.");
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ConfigureSuccessType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ConfigureSuccessType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ConfigureSuccessType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ConfigureSuccessTypeExtensions.ToValueString(value));
        }
    }
}
