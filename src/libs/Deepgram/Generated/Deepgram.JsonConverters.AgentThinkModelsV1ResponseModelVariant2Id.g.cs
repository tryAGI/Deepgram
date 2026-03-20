#nullable enable

namespace Deepgram.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentThinkModelsV1ResponseModelVariant2IdJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.AgentThinkModelsV1ResponseModelVariant2Id>
    {
        /// <inheritdoc />
        public override global::Deepgram.AgentThinkModelsV1ResponseModelVariant2Id Read(
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
                        return global::Deepgram.AgentThinkModelsV1ResponseModelVariant2IdExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Deepgram.AgentThinkModelsV1ResponseModelVariant2Id)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Deepgram.AgentThinkModelsV1ResponseModelVariant2Id);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.AgentThinkModelsV1ResponseModelVariant2Id value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Deepgram.AgentThinkModelsV1ResponseModelVariant2IdExtensions.ToValueString(value));
        }
    }
}
