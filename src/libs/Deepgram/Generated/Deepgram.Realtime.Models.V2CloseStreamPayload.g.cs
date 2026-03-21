
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V2CloseStreamPayload
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        /// <default>"CloseStream"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "CloseStream";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V2CloseStreamPayload" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V2CloseStreamPayload(
            string type = "CloseStream")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2CloseStreamPayload" /> class.
        /// </summary>
        public V2CloseStreamPayload()
        {
        }
    }
}