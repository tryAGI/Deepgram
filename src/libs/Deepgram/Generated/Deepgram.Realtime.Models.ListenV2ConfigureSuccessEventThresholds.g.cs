
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Updates each parameter, if it is supplied. If a particular threshold parameter <br/>
    /// is not supplied, the configuration continues using the currently configured value.
    /// </summary>
    public sealed partial class ListenV2ConfigureSuccessEventThresholds
    {
        /// <summary>
        /// End-of-turn confidence required to fire an eager end-of-turn event.<br/>
        /// When set, enables `EagerEndOfTurn` and `TurnResumed` events. Valid<br/>
        /// Values 0.3 - 0.9.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eager_eot_threshold")]
        public global::Deepgram.Realtime.ListenV2EagerEotThreshold? EagerEotThreshold { get; set; }

        /// <summary>
        /// End-of-turn confidence required to finish a turn. Valid Values 0.5 -<br/>
        /// 0.9.<br/>
        /// Default Value: 0.7
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eot_threshold")]
        public global::Deepgram.Realtime.ListenV2EotThreshold? EotThreshold { get; set; }

        /// <summary>
        /// A turn will be finished when this much time has passed after speech,<br/>
        /// regardless of EOT confidence.<br/>
        /// Default Value: 5000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eot_timeout_ms")]
        public global::Deepgram.Realtime.ListenV2EotTimeoutMs? EotTimeoutMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV2ConfigureSuccessEventThresholds" /> class.
        /// </summary>
        /// <param name="eagerEotThreshold">
        /// End-of-turn confidence required to fire an eager end-of-turn event.<br/>
        /// When set, enables `EagerEndOfTurn` and `TurnResumed` events. Valid<br/>
        /// Values 0.3 - 0.9.
        /// </param>
        /// <param name="eotThreshold">
        /// End-of-turn confidence required to finish a turn. Valid Values 0.5 -<br/>
        /// 0.9.<br/>
        /// Default Value: 0.7
        /// </param>
        /// <param name="eotTimeoutMs">
        /// A turn will be finished when this much time has passed after speech,<br/>
        /// regardless of EOT confidence.<br/>
        /// Default Value: 5000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV2ConfigureSuccessEventThresholds(
            global::Deepgram.Realtime.ListenV2EagerEotThreshold? eagerEotThreshold,
            global::Deepgram.Realtime.ListenV2EotThreshold? eotThreshold,
            global::Deepgram.Realtime.ListenV2EotTimeoutMs? eotTimeoutMs)
        {
            this.EagerEotThreshold = eagerEotThreshold;
            this.EotThreshold = eotThreshold;
            this.EotTimeoutMs = eotTimeoutMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV2ConfigureSuccessEventThresholds" /> class.
        /// </summary>
        public ListenV2ConfigureSuccessEventThresholds()
        {
        }
    }
}