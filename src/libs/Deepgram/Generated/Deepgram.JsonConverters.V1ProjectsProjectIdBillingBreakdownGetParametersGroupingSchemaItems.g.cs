#nullable enable

namespace Deepgram.JsonConverters
{
    /// <inheritdoc />
    public sealed class V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems>
    {
        /// <inheritdoc />
        public override global::Deepgram.V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems Read(
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
                        return global::Deepgram.V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItemsExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Deepgram.V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Deepgram.V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Deepgram.V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItemsExtensions.ToValueString(value));
        }
    }
}
