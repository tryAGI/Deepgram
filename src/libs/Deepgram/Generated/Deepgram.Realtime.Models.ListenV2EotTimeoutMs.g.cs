
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// A turn will be finished when this much time has passed after speech,<br/>
    /// regardless of EOT confidence.<br/>
    /// Default Value: 5000
    /// </summary>
    public sealed partial class ListenV2EotTimeoutMs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}