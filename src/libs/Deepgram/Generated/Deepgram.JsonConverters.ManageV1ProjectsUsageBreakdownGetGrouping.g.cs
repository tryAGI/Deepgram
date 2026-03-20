#nullable enable

namespace Deepgram.JsonConverters
{
    /// <inheritdoc />
    public sealed class ManageV1ProjectsUsageBreakdownGetGroupingJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.ManageV1ProjectsUsageBreakdownGetGrouping>
    {
        /// <inheritdoc />
        public override global::Deepgram.ManageV1ProjectsUsageBreakdownGetGrouping Read(
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
                        return global::Deepgram.ManageV1ProjectsUsageBreakdownGetGroupingExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Deepgram.ManageV1ProjectsUsageBreakdownGetGrouping)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Deepgram.ManageV1ProjectsUsageBreakdownGetGrouping);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.ManageV1ProjectsUsageBreakdownGetGrouping value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Deepgram.ManageV1ProjectsUsageBreakdownGetGroupingExtensions.ToValueString(value));
        }
    }
}
