
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeakV1TextMessage
    {
        /// <summary>
        /// Message type identifier<br/>
        /// Example: Speak
        /// </summary>
        /// <example>Speak</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.SpeakV1TextMessageTypeJsonConverter))]
        public global::Deepgram.Realtime.SpeakV1TextMessageType Type { get; set; }

        /// <summary>
        /// The input text to be converted to speech<br/>
        /// Example: Hello, world!
        /// </summary>
        /// <example>Hello, world!</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV1TextMessage" /> class.
        /// </summary>
        /// <param name="text">
        /// The input text to be converted to speech<br/>
        /// Example: Hello, world!
        /// </param>
        /// <param name="type">
        /// Message type identifier<br/>
        /// Example: Speak
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakV1TextMessage(
            string text,
            global::Deepgram.Realtime.SpeakV1TextMessageType type)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV1TextMessage" /> class.
        /// </summary>
        public SpeakV1TextMessage()
        {
        }
    }
}