
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListenV1ListenV1Error
    {
        /// <summary>
        /// Message type identifier for error responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV1MessagesListenV1ErrorTypeJsonConverter))]
        public global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ErrorType Type { get; set; }

        /// <summary>
        /// The error category. `SchemaError` means the server could not parse a client text message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variant")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Variant { get; set; }

        /// <summary>
        /// A human-readable description of what went wrong
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Deprecated. Present only on legacy error frames; use `ConfigureFailure.code` for `Configure`<br/>
        /// rejections.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Code { get; set; }

        /// <summary>
        /// For `SchemaError`, the original client message that could not be parsed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ListenV1Error" /> class.
        /// </summary>
        /// <param name="variant">
        /// The error category. `SchemaError` means the server could not parse a client text message.
        /// </param>
        /// <param name="description">
        /// A human-readable description of what went wrong
        /// </param>
        /// <param name="type">
        /// Message type identifier for error responses
        /// </param>
        /// <param name="message">
        /// For `SchemaError`, the original client message that could not be parsed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV1ListenV1Error(
            string variant,
            string description,
            global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ErrorType type,
            string? message)
        {
            this.Type = type;
            this.Variant = variant ?? throw new global::System.ArgumentNullException(nameof(variant));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ListenV1Error" /> class.
        /// </summary>
        public ListenV1ListenV1Error()
        {
        }

    }
}