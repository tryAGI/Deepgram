
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Updates each parameter, if it is supplied. If a particular threshold parameter<br/>
    /// is not supplied, the configuration continues using the currently configured value.
    /// </summary>
    public sealed partial class ChannelsListenV2MessagesListenV2ConfigureSuccessThresholds
    {
        /// <summary>
        /// Any type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eager_eot_threshold")]
        public global::Deepgram.Realtime.ListenV2EagerEotThreshold? EagerEotThreshold { get; set; }

        /// <summary>
        /// Any type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eot_threshold")]
        public global::Deepgram.Realtime.ListenV2EotThreshold? EotThreshold { get; set; }

        /// <summary>
        /// Any type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eot_timeout_ms")]
        public global::Deepgram.Realtime.ListenV2EotTimeoutMs? EotTimeoutMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsListenV2MessagesListenV2ConfigureSuccessThresholds" /> class.
        /// </summary>
        /// <param name="eagerEotThreshold">
        /// Any type
        /// </param>
        /// <param name="eotThreshold">
        /// Any type
        /// </param>
        /// <param name="eotTimeoutMs">
        /// Any type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelsListenV2MessagesListenV2ConfigureSuccessThresholds(
            global::Deepgram.Realtime.ListenV2EagerEotThreshold? eagerEotThreshold,
            global::Deepgram.Realtime.ListenV2EotThreshold? eotThreshold,
            global::Deepgram.Realtime.ListenV2EotTimeoutMs? eotTimeoutMs)
        {
            this.EagerEotThreshold = eagerEotThreshold;
            this.EotThreshold = eotThreshold;
            this.EotTimeoutMs = eotTimeoutMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsListenV2MessagesListenV2ConfigureSuccessThresholds" /> class.
        /// </summary>
        public ChannelsListenV2MessagesListenV2ConfigureSuccessThresholds()
        {
        }
    }
}