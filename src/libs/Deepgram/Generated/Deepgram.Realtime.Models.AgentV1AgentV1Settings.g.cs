
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1AgentV1Settings
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1SettingsTypeJsonConverter))]
        public global::Deepgram.Realtime.AgentV1AgentV1SettingsType Type { get; set; }

        /// <summary>
        /// Tags to associate with the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// To enable experimental features<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimental")]
        public bool? Experimental { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flags")]
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsFlags? Flags { get; set; }

        /// <summary>
        /// To opt out of Deepgram Model Improvement Program<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mip_opt_out")]
        public bool? MipOptOut { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAudio Audio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAgentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgent Agent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1Settings" /> class.
        /// </summary>
        /// <param name="audio"></param>
        /// <param name="agent"></param>
        /// <param name="type"></param>
        /// <param name="tags">
        /// Tags to associate with the request
        /// </param>
        /// <param name="experimental">
        /// To enable experimental features<br/>
        /// Default Value: false
        /// </param>
        /// <param name="flags"></param>
        /// <param name="mipOptOut">
        /// To opt out of Deepgram Model Improvement Program<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1AgentV1Settings(
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAudio audio,
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgent agent,
            global::Deepgram.Realtime.AgentV1AgentV1SettingsType type,
            global::System.Collections.Generic.IList<string>? tags,
            bool? experimental,
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsFlags? flags,
            bool? mipOptOut)
        {
            this.Type = type;
            this.Tags = tags;
            this.Experimental = experimental;
            this.Flags = flags;
            this.MipOptOut = mipOptOut;
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Agent = agent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1Settings" /> class.
        /// </summary>
        public AgentV1AgentV1Settings()
        {
        }

    }
}