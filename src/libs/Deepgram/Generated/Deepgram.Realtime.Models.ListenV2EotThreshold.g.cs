
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// End-of-turn confidence required to finish a turn. Valid Values 0.5 -<br/>
    /// 0.9.<br/>
    /// Default Value: 0.7
    /// </summary>
    public sealed partial class ListenV2EotThreshold
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}