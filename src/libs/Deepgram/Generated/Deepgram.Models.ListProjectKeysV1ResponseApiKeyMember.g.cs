
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListProjectKeysV1ResponseApiKeyMember
    {
        /// <summary>
        /// Example: 1000-2000-3000-4000
        /// </summary>
        /// <example>1000-2000-3000-4000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("member_id")]
        public string? MemberId { get; set; }

        /// <summary>
        /// Example: john@test.com
        /// </summary>
        /// <example>john@test.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectKeysV1ResponseApiKeyMember" /> class.
        /// </summary>
        /// <param name="memberId">
        /// Example: 1000-2000-3000-4000
        /// </param>
        /// <param name="email">
        /// Example: john@test.com
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectKeysV1ResponseApiKeyMember(
            string? memberId,
            string? email)
        {
            this.MemberId = memberId;
            this.Email = email;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectKeysV1ResponseApiKeyMember" /> class.
        /// </summary>
        public ListProjectKeysV1ResponseApiKeyMember()
        {
        }
    }
}