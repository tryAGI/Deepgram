#nullable enable

namespace Deepgram.Realtime.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItemsOneOf0RoleNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItemsOneOf0Role?>
    {
        /// <inheritdoc />
        public override global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItemsOneOf0Role? Read(
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
                        return global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItemsOneOf0RoleExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItemsOneOf0Role)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItemsOneOf0Role?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItemsOneOf0Role? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItemsOneOf0RoleExtensions.ToValueString(value.Value));
            }
        }
    }
}
