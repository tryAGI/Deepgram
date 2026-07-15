
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeakV2SpeakV2Error
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.SpeakV2SpeakV2ErrorTypeJsonConverter))]
        public global::Deepgram.Realtime.SpeakV2SpeakV2ErrorType Type { get; set; }

        /// <summary>
        /// A code identifying the error, e.g. `MESSAGE-0000` or `NET-0000`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsSpeakV2MessagesSpeakV2ErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.ChannelsSpeakV2MessagesSpeakV2ErrorCode Code { get; set; }

        /// <summary>
        /// Prose description of the error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV2SpeakV2Error" /> class.
        /// </summary>
        /// <param name="code">
        /// A code identifying the error, e.g. `MESSAGE-0000` or `NET-0000`.
        /// </param>
        /// <param name="description">
        /// Prose description of the error
        /// </param>
        /// <param name="type">
        /// Message type identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakV2SpeakV2Error(
            global::Deepgram.Realtime.ChannelsSpeakV2MessagesSpeakV2ErrorCode code,
            string description,
            global::Deepgram.Realtime.SpeakV2SpeakV2ErrorType type)
        {
            this.Type = type;
            this.Code = code;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV2SpeakV2Error" /> class.
        /// </summary>
        public SpeakV2SpeakV2Error()
        {
        }

    }
}