#nullable enable

namespace Deepgram.JsonConverters
{
    /// <inheritdoc />
    public sealed class ManageV1ProjectsUsageGetMethodNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.ManageV1ProjectsUsageGetMethod?>
    {
        /// <inheritdoc />
        public override global::Deepgram.ManageV1ProjectsUsageGetMethod? Read(
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
                        return global::Deepgram.ManageV1ProjectsUsageGetMethodExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Deepgram.ManageV1ProjectsUsageGetMethod)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Deepgram.ManageV1ProjectsUsageGetMethod?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.ManageV1ProjectsUsageGetMethod? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Deepgram.ManageV1ProjectsUsageGetMethodExtensions.ToValueString(value.Value));
            }
        }
    }
}
