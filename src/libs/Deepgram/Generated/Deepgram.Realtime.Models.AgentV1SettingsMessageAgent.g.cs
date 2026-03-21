
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1SettingsMessageAgent
    {
        /// <summary>
        /// Deprecated. Use `listen.provider.language` and `speak.provider.language` fields instead.<br/>
        /// Default Value: en
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Language { get; set; }

        /// <summary>
        /// Conversation context including the history of messages and function calls
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public global::Deepgram.Realtime.AgentV1SettingsMessageAgentContext? Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("listen")]
        public global::Deepgram.Realtime.AgentV1SettingsMessageAgentListen? Listen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("think")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.OneOfJsonConverter<global::Deepgram.Realtime.ThinkSettingsV1, global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1>>))]
        public global::Deepgram.Realtime.OneOf<global::Deepgram.Realtime.ThinkSettingsV1, global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1>>? Think { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speak")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.OneOfJsonConverter<global::Deepgram.Realtime.SpeakSettingsV1, global::System.Collections.Generic.IList<global::Deepgram.Realtime.SpeakSettingsV1>>))]
        public global::Deepgram.Realtime.OneOf<global::Deepgram.Realtime.SpeakSettingsV1, global::System.Collections.Generic.IList<global::Deepgram.Realtime.SpeakSettingsV1>>? Speak { get; set; }

        /// <summary>
        /// Optional message that agent will speak at the start
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("greeting")]
        public string? Greeting { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1SettingsMessageAgent" /> class.
        /// </summary>
        /// <param name="context">
        /// Conversation context including the history of messages and function calls
        /// </param>
        /// <param name="listen"></param>
        /// <param name="think"></param>
        /// <param name="speak"></param>
        /// <param name="greeting">
        /// Optional message that agent will speak at the start
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1SettingsMessageAgent(
            global::Deepgram.Realtime.AgentV1SettingsMessageAgentContext? context,
            global::Deepgram.Realtime.AgentV1SettingsMessageAgentListen? listen,
            global::Deepgram.Realtime.OneOf<global::Deepgram.Realtime.ThinkSettingsV1, global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1>>? think,
            global::Deepgram.Realtime.OneOf<global::Deepgram.Realtime.SpeakSettingsV1, global::System.Collections.Generic.IList<global::Deepgram.Realtime.SpeakSettingsV1>>? speak,
            string? greeting)
        {
            this.Context = context;
            this.Listen = listen;
            this.Think = think;
            this.Speak = speak;
            this.Greeting = greeting;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1SettingsMessageAgent" /> class.
        /// </summary>
        public AgentV1SettingsMessageAgent()
        {
        }
    }
}