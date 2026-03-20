
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Request body for creating distribution credentials
    /// </summary>
    public sealed partial class CreateProjectDistributionCredentialsV1Request
    {
        /// <summary>
        /// Optional comment about the credentials
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectDistributionCredentialsV1Request" /> class.
        /// </summary>
        /// <param name="comment">
        /// Optional comment about the credentials
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectDistributionCredentialsV1Request(
            string? comment)
        {
            this.Comment = comment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectDistributionCredentialsV1Request" /> class.
        /// </summary>
        public CreateProjectDistributionCredentialsV1Request()
        {
        }
    }
}