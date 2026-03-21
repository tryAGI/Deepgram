
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeechStartedPayload
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.SpeechStartedPayloadTypeJsonConverter))]
        public global::Deepgram.Realtime.SpeechStartedPayloadType Type { get; set; }

        /// <summary>
        /// The channel indices
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> Channel { get; set; }

        /// <summary>
        /// Timestamp when speech was detected
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Timestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechStartedPayload" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier
        /// </param>
        /// <param name="channel">
        /// The channel indices
        /// </param>
        /// <param name="timestamp">
        /// Timestamp when speech was detected
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechStartedPayload(
            global::System.Collections.Generic.IList<double> channel,
            double timestamp,
            global::Deepgram.Realtime.SpeechStartedPayloadType type)
        {
            this.Channel = channel ?? throw new global::System.ArgumentNullException(nameof(channel));
            this.Timestamp = timestamp;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechStartedPayload" /> class.
        /// </summary>
        public SpeechStartedPayload()
        {
        }
    }
}