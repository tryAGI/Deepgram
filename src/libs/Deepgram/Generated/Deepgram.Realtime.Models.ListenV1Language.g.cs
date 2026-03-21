
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// The [BCP-47 language tag](https://tools.ietf.org/html/bcp47) that hints at the primary spoken language. Depending on the Model you choose only certain languages are available<br/>
    /// Default Value: en
    /// </summary>
    public sealed partial class ListenV1Language
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}