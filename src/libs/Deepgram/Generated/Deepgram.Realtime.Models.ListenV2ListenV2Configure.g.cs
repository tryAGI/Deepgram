
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListenV2ListenV2Configure
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ListenV2ListenV2ConfigureTypeJsonConverter))]
        public global::Deepgram.Realtime.ListenV2ListenV2ConfigureType Type { get; set; }

        /// <summary>
        /// Updates each parameter, if it is supplied. If a particular threshold parameter<br/>
        /// is not supplied, the configuration continues using the currently configured value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thresholds")]
        public global::Deepgram.Realtime.ChannelsListenV2MessagesListenV2ConfigureThresholds? Thresholds { get; set; }

        /// <summary>
        /// Keyterm prompting can improve recognition of specialized terminology.<br/>
        /// Pass multiple keyterm query parameters to boost multiple keyterms.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyterms")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ListenV2KeytermJsonConverter))]
        public global::Deepgram.Realtime.ListenV2Keyterm? Keyterms { get; set; }

        /// <summary>
        /// Language hints to constrain and prioritize language detection.<br/>
        /// Only valid when the model is flux-general-multi. If this field is not supplied,<br/>
        /// the session will continue to use the currently configured value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_hints")]
        public global::System.Collections.Generic.IList<string>? LanguageHints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV2ListenV2Configure" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier
        /// </param>
        /// <param name="thresholds">
        /// Updates each parameter, if it is supplied. If a particular threshold parameter<br/>
        /// is not supplied, the configuration continues using the currently configured value.
        /// </param>
        /// <param name="keyterms">
        /// Keyterm prompting can improve recognition of specialized terminology.<br/>
        /// Pass multiple keyterm query parameters to boost multiple keyterms.
        /// </param>
        /// <param name="languageHints">
        /// Language hints to constrain and prioritize language detection.<br/>
        /// Only valid when the model is flux-general-multi. If this field is not supplied,<br/>
        /// the session will continue to use the currently configured value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV2ListenV2Configure(
            global::Deepgram.Realtime.ListenV2ListenV2ConfigureType type,
            global::Deepgram.Realtime.ChannelsListenV2MessagesListenV2ConfigureThresholds? thresholds,
            global::Deepgram.Realtime.ListenV2Keyterm? keyterms,
            global::System.Collections.Generic.IList<string>? languageHints)
        {
            this.Type = type;
            this.Thresholds = thresholds;
            this.Keyterms = keyterms;
            this.LanguageHints = languageHints;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV2ListenV2Configure" /> class.
        /// </summary>
        public ListenV2ListenV2Configure()
        {
        }

    }
}