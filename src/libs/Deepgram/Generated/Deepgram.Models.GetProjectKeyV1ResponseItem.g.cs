
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectKeyV1ResponseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("member")]
        public global::Deepgram.GetProjectKeyV1ResponseItemMember? Member { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectKeyV1ResponseItem" /> class.
        /// </summary>
        /// <param name="member"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectKeyV1ResponseItem(
            global::Deepgram.GetProjectKeyV1ResponseItemMember? member)
        {
            this.Member = member;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectKeyV1ResponseItem" /> class.
        /// </summary>
        public GetProjectKeyV1ResponseItem()
        {
        }
    }
}