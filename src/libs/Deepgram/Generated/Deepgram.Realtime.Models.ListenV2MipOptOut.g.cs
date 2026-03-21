
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Opts out requests from the Deepgram Model Improvement Program. Refer<br/>
    /// to our Docs for pricing impacts before setting this to true.<br/>
    /// https://dpgr.am/deepgram-mip
    /// </summary>
    public sealed partial class ListenV2MipOptOut
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}