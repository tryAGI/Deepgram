
#pragma warning disable CS0618 // Type or member is obsolete

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
        /// <default>"aws_polly"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "aws_polly";

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
        [global::System.Obsolete("This property marked as deprecated.")]
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
        /// <param name="type"></param>
        /// <param name="voice">
        /// AWS Polly voice name
        /// </param>
        /// <param name="language">
        /// Language code to use, e.g. 'en-US'. Corresponds to the `language_code` parameter in the AWS Polly API
        /// </param>
        /// <param name="engine"></param>
        /// <param name="credentials"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AwsPollySpeakProvider(
            global::Deepgram.Realtime.AwsPollySpeakProviderVoice voice,
            string language,
            global::Deepgram.Realtime.AwsPollySpeakProviderEngine engine,
            global::Deepgram.Realtime.AwsPollySpeakProviderCredentials credentials,
            string type = "aws_polly")
        {
            this.Voice = voice;
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Engine = engine;
            this.Credentials = credentials ?? throw new global::System.ArgumentNullException(nameof(credentials));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AwsPollySpeakProvider" /> class.
        /// </summary>
        public AwsPollySpeakProvider()
        {
        }
    }
}