
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeakV1WarningEvent
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.SpeakV1WarningEventTypeJsonConverter))]
        public global::Deepgram.Realtime.SpeakV1WarningEventType Type { get; set; }

        /// <summary>
        /// A description of what went wrong
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Error code identifying the type of error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV1WarningEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier
        /// </param>
        /// <param name="description">
        /// A description of what went wrong
        /// </param>
        /// <param name="code">
        /// Error code identifying the type of error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakV1WarningEvent(
            string description,
            string code,
            global::Deepgram.Realtime.SpeakV1WarningEventType type)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV1WarningEvent" /> class.
        /// </summary>
        public SpeakV1WarningEvent()
        {
        }
    }
}