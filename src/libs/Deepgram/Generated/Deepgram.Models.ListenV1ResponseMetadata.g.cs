
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
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? TransactionKey { get; set; }

        /// <summary>
        /// Example: a847f427-4ad5-4d67-9b95-db801e58251c
        /// </summary>
        /// <example>a847f427-4ad5-4d67-9b95-db801e58251c</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RequestId { get; set; }

        /// <summary>
        /// Example: 154e291ecfa8be6ab8343560bcc109008fa7853eb5372533e8efdefc9b504c33
        /// </summary>
        /// <example>154e291ecfa8be6ab8343560bcc109008fa7853eb5372533e8efdefc9b504c33</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha256")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha256 { get; set; }

        /// <summary>
        /// Example: 2024-05-12T18:57:13.426Z
        /// </summary>
        /// <example>2024-05-12T18:57:13.426Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Created { get; set; }

        /// <summary>
        /// Example: 25.933313
        /// </summary>
        /// <example>25.933313</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Duration { get; set; }

        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Channels { get; set; }

        /// <summary>
        /// Example: [30089e05-99d1-4376-b32e-c263170674af]
        /// </summary>
        /// <example>[30089e05-99d1-4376-b32e-c263170674af]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Models { get; set; }

        /// <summary>
        /// Example: {"30089e05-99d1-4376-b32e-c263170674af":{"name":"2-general-nova","version":"2024-01-09.29447","arch":"nova-2"}}
        /// </summary>
        /// <example>{"30089e05-99d1-4376-b32e-c263170674af":{"name":"2-general-nova","version":"2024-01-09.29447","arch":"nova-2"}}</example>
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
        /// Example: [test]
        /// </summary>
        /// <example>[test]</example>
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
        /// <param name="requestId">
        /// Example: a847f427-4ad5-4d67-9b95-db801e58251c
        /// </param>
        /// <param name="sha256">
        /// Example: 154e291ecfa8be6ab8343560bcc109008fa7853eb5372533e8efdefc9b504c33
        /// </param>
        /// <param name="created">
        /// Example: 2024-05-12T18:57:13.426Z
        /// </param>
        /// <param name="duration">
        /// Example: 25.933313
        /// </param>
        /// <param name="channels">
        /// Example: 1
        /// </param>
        /// <param name="models">
        /// Example: [30089e05-99d1-4376-b32e-c263170674af]
        /// </param>
        /// <param name="modelInfo">
        /// Example: {"30089e05-99d1-4376-b32e-c263170674af":{"name":"2-general-nova","version":"2024-01-09.29447","arch":"nova-2"}}
        /// </param>
        /// <param name="summaryInfo"></param>
        /// <param name="sentimentInfo"></param>
        /// <param name="topicsInfo"></param>
        /// <param name="intentsInfo"></param>
        /// <param name="tags">
        /// Example: [test]
        /// </param>
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
            global::Deepgram.ListenV1ResponseMetadataSummaryInfo? summaryInfo,
            global::Deepgram.ListenV1ResponseMetadataSentimentInfo? sentimentInfo,
            global::Deepgram.ListenV1ResponseMetadataTopicsInfo? topicsInfo,
            global::Deepgram.ListenV1ResponseMetadataIntentsInfo? intentsInfo,
            global::System.Collections.Generic.IList<string>? tags)
        {
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