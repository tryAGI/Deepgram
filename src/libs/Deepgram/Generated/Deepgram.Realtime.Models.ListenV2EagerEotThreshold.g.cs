
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// End-of-turn confidence required to fire an eager end-of-turn event.<br/>
    /// When set, enables `EagerEndOfTurn` and `TurnResumed` events. Valid<br/>
    /// Values 0.3 - 0.9.
    /// </summary>
    public sealed partial class ListenV2EagerEotThreshold
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}