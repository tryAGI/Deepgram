
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeakV2SpeakV2ConfigureSuccess
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.SpeakV2SpeakV2ConfigureSuccessTypeJsonConverter))]
        public global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureSuccessType Type { get; set; }

        /// <summary>
        /// Synthesis configuration. A field is present only when it has been set on this session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applied")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.ChannelsSpeakV2MessagesSpeakV2ConfigureSuccessApplied Applied { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV2SpeakV2ConfigureSuccess" /> class.
        /// </summary>
        /// <param name="applied">
        /// Synthesis configuration. A field is present only when it has been set on this session.
        /// </param>
        /// <param name="type">
        /// Message type identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakV2SpeakV2ConfigureSuccess(
            global::Deepgram.Realtime.ChannelsSpeakV2MessagesSpeakV2ConfigureSuccessApplied applied,
            global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureSuccessType type)
        {
            this.Type = type;
            this.Applied = applied ?? throw new global::System.ArgumentNullException(nameof(applied));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV2SpeakV2ConfigureSuccess" /> class.
        /// </summary>
        public SpeakV2SpeakV2ConfigureSuccess()
        {
        }

    }
}