#nullable enable

namespace Deepgram.JsonConverters
{
    /// <inheritdoc />
    public sealed class SpeakV1AudioGenerateContainerOpusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.SpeakV1AudioGenerateContainerOpus>
    {
        /// <inheritdoc />
        public override global::Deepgram.SpeakV1AudioGenerateContainerOpus Read(
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
                        return global::Deepgram.SpeakV1AudioGenerateContainerOpusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Deepgram.SpeakV1AudioGenerateContainerOpus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Deepgram.SpeakV1AudioGenerateContainerOpus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.SpeakV1AudioGenerateContainerOpus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Deepgram.SpeakV1AudioGenerateContainerOpusExtensions.ToValueString(value));
        }
    }
}
