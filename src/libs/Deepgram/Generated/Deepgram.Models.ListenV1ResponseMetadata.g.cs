
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListenV1ResponseMetadata
    {
        /// <summary>
        /// Default Value: deprecated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transaction_key")]
        public string? TransactionKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha256")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha256 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Channels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Models { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_info")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.ListenV1ResponseMetadataModelInfo ModelInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_info")]
        public global::Deepgram.ListenV1ResponseMetadataSummaryInfo? SummaryInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment_info")]
        public global::Deepgram.ListenV1ResponseMetadataSentimentInfo? SentimentInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics_info")]
        public global::Deepgram.ListenV1ResponseMetadataTopicsInfo? TopicsInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intents_info")]
        public global::Deepgram.ListenV1ResponseMetadataIntentsInfo? IntentsInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResponseMetadata" /> class.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="sha256"></param>
        /// <param name="created"></param>
        /// <param name="duration"></param>
        /// <param name="channels"></param>
        /// <param name="models"></param>
        /// <param name="modelInfo"></param>
        /// <param name="transactionKey">
        /// Default Value: deprecated
        /// </param>
        /// <param name="summaryInfo"></param>
        /// <param name="sentimentInfo"></param>
        /// <param name="topicsInfo"></param>
        /// <param name="intentsInfo"></param>
        /// <param name="tags"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV1ResponseMetadata(
            global::System.Guid requestId,
            string sha256,
            global::System.DateTime created,
            double duration,
            double channels,
            global::System.Collections.Generic.IList<string> models,
            global::Deepgram.ListenV1ResponseMetadataModelInfo modelInfo,
            string? transactionKey,
            global::Deepgram.ListenV1ResponseMetadataSummaryInfo? summaryInfo,
            global::Deepgram.ListenV1ResponseMetadataSentimentInfo? sentimentInfo,
            global::Deepgram.ListenV1ResponseMetadataTopicsInfo? topicsInfo,
            global::Deepgram.ListenV1ResponseMetadataIntentsInfo? intentsInfo,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.TransactionKey = transactionKey;
            this.RequestId = requestId;
            this.Sha256 = sha256 ?? throw new global::System.ArgumentNullException(nameof(sha256));
            this.Created = created;
            this.Duration = duration;
            this.Channels = channels;
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
            this.ModelInfo = modelInfo ?? throw new global::System.ArgumentNullException(nameof(modelInfo));
            this.SummaryInfo = summaryInfo;
            this.SentimentInfo = sentimentInfo;
            this.TopicsInfo = topicsInfo;
            this.IntentsInfo = intentsInfo;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResponseMetadata" /> class.
        /// </summary>
        public ListenV1ResponseMetadata()
        {
        }
    }
}