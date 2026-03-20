#nullable enable

namespace Deepgram.JsonConverters
{
    /// <inheritdoc />
    public sealed class ManageV1ProjectsRequestsListEndpointJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.ManageV1ProjectsRequestsListEndpoint>
    {
        /// <inheritdoc />
        public override global::Deepgram.ManageV1ProjectsRequestsListEndpoint Read(
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
                        return global::Deepgram.ManageV1ProjectsRequestsListEndpointExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Deepgram.ManageV1ProjectsRequestsListEndpoint)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Deepgram.ManageV1ProjectsRequestsListEndpoint);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.ManageV1ProjectsRequestsListEndpoint value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Deepgram.ManageV1ProjectsRequestsListEndpointExtensions.ToValueString(value));
        }
    }
}
