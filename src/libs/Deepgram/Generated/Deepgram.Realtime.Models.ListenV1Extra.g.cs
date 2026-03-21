
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Arbitrary key-value pairs that are attached to the API response for usage in downstream processing
    /// </summary>
    public sealed partial class ListenV1Extra
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}