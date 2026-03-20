
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListenV1ResponseResultsSummary
    {
        /// <summary>
        /// Example: success
        /// </summary>
        /// <example>success</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public string? Result { get; set; }

        /// <summary>
        /// Example: Speaker 0 discusses the significance of the first all-female spacewalk with an all-female team, stating that it is a tribute to the skilled and qualified women who were denied opportunities in the past.
        /// </summary>
        /// <example>Speaker 0 discusses the significance of the first all-female spacewalk with an all-female team, stating that it is a tribute to the skilled and qualified women who were denied opportunities in the past.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("short")]
        public string? Short { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResponseResultsSummary" /> class.
        /// </summary>
        /// <param name="result">
        /// Example: success
        /// </param>
        /// <param name="short">
        /// Example: Speaker 0 discusses the significance of the first all-female spacewalk with an all-female team, stating that it is a tribute to the skilled and qualified women who were denied opportunities in the past.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV1ResponseResultsSummary(
            string? result,
            string? @short)
        {
            this.Result = result;
            this.Short = @short;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResponseResultsSummary" /> class.
        /// </summary>
        public ListenV1ResponseResultsSummary()
        {
        }
    }
}