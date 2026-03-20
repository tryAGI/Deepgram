#nullable enable

namespace Deepgram.JsonConverters
{
    /// <inheritdoc />
    public sealed class SpeakV1AudioGenerateEncodingLinear16JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.SpeakV1AudioGenerateEncodingLinear16>
    {
        /// <inheritdoc />
        public override global::Deepgram.SpeakV1AudioGenerateEncodingLinear16 Read(
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
                        return global::Deepgram.SpeakV1AudioGenerateEncodingLinear16Extensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Deepgram.SpeakV1AudioGenerateEncodingLinear16)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Deepgram.SpeakV1AudioGenerateEncodingLinear16);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.SpeakV1AudioGenerateEncodingLinear16 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Deepgram.SpeakV1AudioGenerateEncodingLinear16Extensions.ToValueString(value));
        }
    }
}
