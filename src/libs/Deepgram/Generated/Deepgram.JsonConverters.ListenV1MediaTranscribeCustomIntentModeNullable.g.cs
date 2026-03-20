#nullable enable

namespace Deepgram.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListenV1MediaTranscribeCustomIntentModeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.ListenV1MediaTranscribeCustomIntentMode?>
    {
        /// <inheritdoc />
        public override global::Deepgram.ListenV1MediaTranscribeCustomIntentMode? Read(
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
                        return global::Deepgram.ListenV1MediaTranscribeCustomIntentModeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Deepgram.ListenV1MediaTranscribeCustomIntentMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Deepgram.ListenV1MediaTranscribeCustomIntentMode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.ListenV1MediaTranscribeCustomIntentMode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Deepgram.ListenV1MediaTranscribeCustomIntentModeExtensions.ToValueString(value.Value));
            }
        }
    }
}
