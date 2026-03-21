
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UtteranceEndPayload
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.UtteranceEndPayloadTypeJsonConverter))]
        public global::Deepgram.Realtime.UtteranceEndPayloadType Type { get; set; }

        /// <summary>
        /// The channel indices
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> Channel { get; set; }

        /// <summary>
        /// End time of the last word
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_word_end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LastWordEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UtteranceEndPayload" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier
        /// </param>
        /// <param name="channel">
        /// The channel indices
        /// </param>
        /// <param name="lastWordEnd">
        /// End time of the last word
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UtteranceEndPayload(
            global::System.Collections.Generic.IList<double> channel,
            double lastWordEnd,
            global::Deepgram.Realtime.UtteranceEndPayloadType type)
        {
            this.Channel = channel ?? throw new global::System.ArgumentNullException(nameof(channel));
            this.LastWordEnd = lastWordEnd;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UtteranceEndPayload" /> class.
        /// </summary>
        public UtteranceEndPayload()
        {
        }
    }
}