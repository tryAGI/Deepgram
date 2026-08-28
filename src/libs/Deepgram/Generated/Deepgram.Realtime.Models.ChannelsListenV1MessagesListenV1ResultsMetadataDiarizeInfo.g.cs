
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// The diarizer that produced the speaker labels. Present only when a diarizer ran.
    /// </summary>
    public sealed partial class ChannelsListenV1MessagesListenV1ResultsMetadataDiarizeInfo
    {
        /// <summary>
        /// The diarizer model UUID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelUuid { get; set; }

        /// <summary>
        /// The diarizer arch, such as `v1` or `v2`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsListenV1MessagesListenV1ResultsMetadataDiarizeInfo" /> class.
        /// </summary>
        /// <param name="modelUuid">
        /// The diarizer model UUID
        /// </param>
        /// <param name="arch">
        /// The diarizer arch, such as `v1` or `v2`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelsListenV1MessagesListenV1ResultsMetadataDiarizeInfo(
            string modelUuid,
            string arch)
        {
            this.ModelUuid = modelUuid ?? throw new global::System.ArgumentNullException(nameof(modelUuid));
            this.Arch = arch ?? throw new global::System.ArgumentNullException(nameof(arch));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsListenV1MessagesListenV1ResultsMetadataDiarizeInfo" /> class.
        /// </summary>
        public ChannelsListenV1MessagesListenV1ResultsMetadataDiarizeInfo()
        {
        }

    }
}