
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Map of line item names to human-readable descriptions for the time period<br/>
    /// Example: {"streaming::nova-3":"Nova - 3 (Stream)","sync::aura-2":"Aura -2 (Sync)"}
    /// </summary>
    public sealed partial class ListBillingFieldsV1ResponseLineItems
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}