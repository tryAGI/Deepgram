
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Audio file URL to transcribe
    /// </summary>
    public sealed partial class ListenV1RequestUrl
    {
        /// <summary>
        /// Example: https://dpgr.am/spacewalk.wav
        /// </summary>
        /// <example>https://dpgr.am/spacewalk.wav</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1RequestUrl" /> class.
        /// </summary>
        /// <param name="url">
        /// Example: https://dpgr.am/spacewalk.wav
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV1RequestUrl(
            string url)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1RequestUrl" /> class.
        /// </summary>
        public ListenV1RequestUrl()
        {
        }
    }
}