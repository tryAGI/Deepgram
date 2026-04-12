
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Request body for text-to-speech conversion
    /// </summary>
    public sealed partial class SpeakV1Request
    {
        /// <summary>
        /// The text content to be converted to speech
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
        /// Initializes a new instance of the <see cref="SpeakV1Request" /> class.
        /// </summary>
        /// <param name="text">
        /// The text content to be converted to speech
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakV1Request(
            string text)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV1Request" /> class.
        /// </summary>
        public SpeakV1Request()
        {
        }
    }
}