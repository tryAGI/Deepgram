#nullable enable

namespace Deepgram.Realtime.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentV1SettingsMessageAudioInputEncodingJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.Realtime.AgentV1SettingsMessageAudioInputEncoding>
    {
        /// <inheritdoc />
        public override global::Deepgram.Realtime.AgentV1SettingsMessageAudioInputEncoding Read(
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
                        return global::Deepgram.Realtime.AgentV1SettingsMessageAudioInputEncodingExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Deepgram.Realtime.AgentV1SettingsMessageAudioInputEncoding)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Deepgram.Realtime.AgentV1SettingsMessageAudioInputEncoding);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.Realtime.AgentV1SettingsMessageAudioInputEncoding value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Deepgram.Realtime.AgentV1SettingsMessageAudioInputEncodingExtensions.ToValueString(value));
        }
    }
}
