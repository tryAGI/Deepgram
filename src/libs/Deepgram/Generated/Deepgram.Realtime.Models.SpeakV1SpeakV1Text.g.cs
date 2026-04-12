
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeakV1SpeakV1Text
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsSpeakV1MessagesSpeakV1TextTypeJsonConverter))]
        public global::Deepgram.Realtime.ChannelsSpeakV1MessagesSpeakV1TextType Type { get; set; }

        /// <summary>
        /// The input text to be converted to speech
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV1SpeakV1Text" /> class.
        /// </summary>
        /// <param name="text">
        /// The input text to be converted to speech
        /// </param>
        /// <param name="type">
        /// Message type identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakV1SpeakV1Text(
            string text,
            global::Deepgram.Realtime.ChannelsSpeakV1MessagesSpeakV1TextType type)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV1SpeakV1Text" /> class.
        /// </summary>
        public SpeakV1SpeakV1Text()
        {
        }
    }
}