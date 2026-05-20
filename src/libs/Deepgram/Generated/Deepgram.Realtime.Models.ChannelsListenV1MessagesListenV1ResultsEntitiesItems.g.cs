
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChannelsListenV1MessagesListenV1ResultsEntitiesItems
    {
        /// <summary>
        /// The type/category of the entity (e.g., NAME, PHONE_NUMBER, EMAIL_ADDRESS, ORGANIZATION, CARDINAL)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// The formatted text representation of the entity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// The original spoken text of the entity (present when formatting is enabled)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RawValue { get; set; }

        /// <summary>
        /// The confidence score of the entity detection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// The index of the first word of the entity in the transcript (inclusive)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_word")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartWord { get; set; }

        /// <summary>
        /// The index of the last word of the entity in the transcript (exclusive)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_word")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndWord { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsListenV1MessagesListenV1ResultsEntitiesItems" /> class.
        /// </summary>
        /// <param name="label">
        /// The type/category of the entity (e.g., NAME, PHONE_NUMBER, EMAIL_ADDRESS, ORGANIZATION, CARDINAL)
        /// </param>
        /// <param name="value">
        /// The formatted text representation of the entity
        /// </param>
        /// <param name="rawValue">
        /// The original spoken text of the entity (present when formatting is enabled)
        /// </param>
        /// <param name="confidence">
        /// The confidence score of the entity detection
        /// </param>
        /// <param name="startWord">
        /// The index of the first word of the entity in the transcript (inclusive)
        /// </param>
        /// <param name="endWord">
        /// The index of the last word of the entity in the transcript (exclusive)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelsListenV1MessagesListenV1ResultsEntitiesItems(
            string label,
            string value,
            string rawValue,
            double confidence,
            int startWord,
            int endWord)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.RawValue = rawValue ?? throw new global::System.ArgumentNullException(nameof(rawValue));
            this.Confidence = confidence;
            this.StartWord = startWord;
            this.EndWord = endWord;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsListenV1MessagesListenV1ResultsEntitiesItems" /> class.
        /// </summary>
        public ChannelsListenV1MessagesListenV1ResultsEntitiesItems()
        {
        }

    }
}