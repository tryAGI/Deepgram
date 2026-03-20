
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Example: {"access_token":"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIn0.dozjgNryP4J3jVmNHl0w5N_XgL0n3I9PlFUP0THsR8U","expires_in":30}
    /// </summary>
    public sealed partial class GrantV1Response
    {
        /// <summary>
        /// JSON Web Token (JWT)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessToken { get; set; }

        /// <summary>
        /// Time in seconds until the JWT expires
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        public double? ExpiresIn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GrantV1Response" /> class.
        /// </summary>
        /// <param name="accessToken">
        /// JSON Web Token (JWT)
        /// </param>
        /// <param name="expiresIn">
        /// Time in seconds until the JWT expires
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GrantV1Response(
            string accessToken,
            double? expiresIn)
        {
            this.AccessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));
            this.ExpiresIn = expiresIn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GrantV1Response" /> class.
        /// </summary>
        public GrantV1Response()
        {
        }
    }
}