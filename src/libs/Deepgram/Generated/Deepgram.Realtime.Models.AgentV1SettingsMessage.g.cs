
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1SettingsMessage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"Settings"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "Settings";

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
        public global::Deepgram.Realtime.AgentV1SettingsMessageFlags? Flags { get; set; }

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
        public required global::Deepgram.Realtime.AgentV1SettingsMessageAudio Audio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.OneOfJsonConverter<global::Deepgram.Realtime.AgentV1SettingsMessageAgent, global::System.Guid?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.OneOf<global::Deepgram.Realtime.AgentV1SettingsMessageAgent, global::System.Guid?> Agent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1SettingsMessage" /> class.
        /// </summary>
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
        /// <param name="audio"></param>
        /// <param name="agent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1SettingsMessage(
            global::Deepgram.Realtime.AgentV1SettingsMessageAudio audio,
            global::Deepgram.Realtime.OneOf<global::Deepgram.Realtime.AgentV1SettingsMessageAgent, global::System.Guid?> agent,
            global::System.Collections.Generic.IList<string>? tags,
            bool? experimental,
            global::Deepgram.Realtime.AgentV1SettingsMessageFlags? flags,
            bool? mipOptOut,
            string type = "Settings")
        {
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Agent = agent;
            this.Type = type;
            this.Tags = tags;
            this.Experimental = experimental;
            this.Flags = flags;
            this.MipOptOut = mipOptOut;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1SettingsMessage" /> class.
        /// </summary>
        public AgentV1SettingsMessage()
        {
        }
    }
}