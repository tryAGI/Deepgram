
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReadV1ResponseMetadataMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public global::System.Guid? RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_info")]
        public global::Deepgram.ReadV1ResponseMetadataMetadataSummaryInfo? SummaryInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment_info")]
        public global::Deepgram.ReadV1ResponseMetadataMetadataSentimentInfo? SentimentInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics_info")]
        public global::Deepgram.ReadV1ResponseMetadataMetadataTopicsInfo? TopicsInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intents_info")]
        public global::Deepgram.ReadV1ResponseMetadataMetadataIntentsInfo? IntentsInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadV1ResponseMetadataMetadata" /> class.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="created"></param>
        /// <param name="language"></param>
        /// <param name="summaryInfo"></param>
        /// <param name="sentimentInfo"></param>
        /// <param name="topicsInfo"></param>
        /// <param name="intentsInfo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReadV1ResponseMetadataMetadata(
            global::System.Guid? requestId,
            global::System.DateTime? created,
            string? language,
            global::Deepgram.ReadV1ResponseMetadataMetadataSummaryInfo? summaryInfo,
            global::Deepgram.ReadV1ResponseMetadataMetadataSentimentInfo? sentimentInfo,
            global::Deepgram.ReadV1ResponseMetadataMetadataTopicsInfo? topicsInfo,
            global::Deepgram.ReadV1ResponseMetadataMetadataIntentsInfo? intentsInfo)
        {
            this.RequestId = requestId;
            this.Created = created;
            this.Language = language;
            this.SummaryInfo = summaryInfo;
            this.SentimentInfo = sentimentInfo;
            this.TopicsInfo = topicsInfo;
            this.IntentsInfo = intentsInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadV1ResponseMetadataMetadata" /> class.
        /// </summary>
        public ReadV1ResponseMetadataMetadata()
        {
        }
    }
}