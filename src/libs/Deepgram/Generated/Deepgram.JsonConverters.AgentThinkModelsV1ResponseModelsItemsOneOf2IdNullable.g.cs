#nullable enable

namespace Deepgram.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentThinkModelsV1ResponseModelsItemsOneOf2IdNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.AgentThinkModelsV1ResponseModelsItemsOneOf2Id?>
    {
        /// <inheritdoc />
        public override global::Deepgram.AgentThinkModelsV1ResponseModelsItemsOneOf2Id? Read(
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
                        return global::Deepgram.AgentThinkModelsV1ResponseModelsItemsOneOf2IdExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Deepgram.AgentThinkModelsV1ResponseModelsItemsOneOf2Id)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Deepgram.AgentThinkModelsV1ResponseModelsItemsOneOf2Id?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.AgentThinkModelsV1ResponseModelsItemsOneOf2Id? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Deepgram.AgentThinkModelsV1ResponseModelsItemsOneOf2IdExtensions.ToValueString(value.Value));
            }
        }
    }
}
