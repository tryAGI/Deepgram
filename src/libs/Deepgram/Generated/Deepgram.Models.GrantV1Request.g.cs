
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GrantV1Request
    {
        /// <summary>
        /// Time to live in seconds for the token. Defaults to 30 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl_seconds")]
        public double? TtlSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GrantV1Request" /> class.
        /// </summary>
        /// <param name="ttlSeconds">
        /// Time to live in seconds for the token. Defaults to 30 seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GrantV1Request(
            double? ttlSeconds)
        {
            this.TtlSeconds = ttlSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GrantV1Request" /> class.
        /// </summary>
        public GrantV1Request()
        {
        }
    }
}