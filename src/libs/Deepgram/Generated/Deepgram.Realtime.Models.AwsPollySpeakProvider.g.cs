
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AwsPollySpeakProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AwsPollySpeakProviderTypeJsonConverter))]
        public global::Deepgram.Realtime.AwsPollySpeakProviderType Type { get; set; }

        /// <summary>
        /// AWS Polly voice name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AwsPollySpeakProviderVoiceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.AwsPollySpeakProviderVoice Voice { get; set; }

        /// <summary>
        /// Language code to use, e.g. 'en-US'. Corresponds to the `language_code` parameter in the AWS Polly API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// Use the `language` field instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_code")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("engine")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AwsPollySpeakProviderEngineJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.AwsPollySpeakProviderEngine Engine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.AwsPollySpeakProviderCredentials Credentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AwsPollySpeakProvider" /> class.
        /// </summary>
        /// <param name="voice">
        /// AWS Polly voice name
        /// </param>
        /// <param name="language">
        /// Language code to use, e.g. 'en-US'. Corresponds to the `language_code` parameter in the AWS Polly API
        /// </param>
        /// <param name="engine"></param>
        /// <param name="credentials"></param>
        /// <param name="type"></param>
        /// <param name="languageCode">
        /// Use the `language` field instead.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AwsPollySpeakProvider(
            global::Deepgram.Realtime.AwsPollySpeakProviderVoice voice,
            string language,
            global::Deepgram.Realtime.AwsPollySpeakProviderEngine engine,
            global::Deepgram.Realtime.AwsPollySpeakProviderCredentials credentials,
            global::Deepgram.Realtime.AwsPollySpeakProviderType type,
            string? languageCode)
        {
            this.Type = type;
            this.Voice = voice;
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.LanguageCode = languageCode;
            this.Engine = engine;
            this.Credentials = credentials ?? throw new global::System.ArgumentNullException(nameof(credentials));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AwsPollySpeakProvider" /> class.
        /// </summary>
        public AwsPollySpeakProvider()
        {
        }

    }
}