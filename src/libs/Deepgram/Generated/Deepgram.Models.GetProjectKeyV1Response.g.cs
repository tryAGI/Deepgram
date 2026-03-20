
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectKeyV1Response
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        public global::Deepgram.GetProjectKeyV1ResponseItem? Item { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectKeyV1Response" /> class.
        /// </summary>
        /// <param name="item"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectKeyV1Response(
            global::Deepgram.GetProjectKeyV1ResponseItem? item)
        {
            this.Item = item;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectKeyV1Response" /> class.
        /// </summary>
        public GetProjectKeyV1Response()
        {
        }
    }
}