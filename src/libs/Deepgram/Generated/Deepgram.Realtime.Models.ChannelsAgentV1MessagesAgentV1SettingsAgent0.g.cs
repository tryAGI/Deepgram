
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChannelsAgentV1MessagesAgentV1SettingsAgent0
    {
        /// <summary>
        /// Deprecated. Use `listen.provider.language` and `speak.provider.language` fields instead.<br/>
        /// Default Value: en
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Conversation context including the history of messages and function calls
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Context? Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("listen")]
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Listen? Listen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("think")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ThinkJsonConverter))]
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think? Think { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speak")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0SpeakJsonConverter))]
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Speak? Speak { get; set; }

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
        /// Initializes a new instance of the <see cref="ChannelsAgentV1MessagesAgentV1SettingsAgent0" /> class.
        /// </summary>
        /// <param name="language">
        /// Deprecated. Use `listen.provider.language` and `speak.provider.language` fields instead.<br/>
        /// Default Value: en
        /// </param>
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
        public ChannelsAgentV1MessagesAgentV1SettingsAgent0(
            string? language,
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Context? context,
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Listen? listen,
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think? think,
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Speak? speak,
            string? greeting)
        {
            this.Language = language;
            this.Context = context;
            this.Listen = listen;
            this.Think = think;
            this.Speak = speak;
            this.Greeting = greeting;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsAgentV1MessagesAgentV1SettingsAgent0" /> class.
        /// </summary>
        public ChannelsAgentV1MessagesAgentV1SettingsAgent0()
        {
        }
    }
}