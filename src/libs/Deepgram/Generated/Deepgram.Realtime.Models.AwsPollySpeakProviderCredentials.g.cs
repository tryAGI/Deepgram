
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AwsPollySpeakProviderCredentials
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AwsPollySpeakProviderCredentialsTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.AwsPollySpeakProviderCredentialsType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessKeyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_access_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretAccessKey { get; set; }

        /// <summary>
        /// Required for STS only
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_token")]
        public string? SessionToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AwsPollySpeakProviderCredentials" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="region"></param>
        /// <param name="accessKeyId"></param>
        /// <param name="secretAccessKey"></param>
        /// <param name="sessionToken">
        /// Required for STS only
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AwsPollySpeakProviderCredentials(
            global::Deepgram.Realtime.AwsPollySpeakProviderCredentialsType type,
            string region,
            string accessKeyId,
            string secretAccessKey,
            string? sessionToken)
        {
            this.Type = type;
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.AccessKeyId = accessKeyId ?? throw new global::System.ArgumentNullException(nameof(accessKeyId));
            this.SecretAccessKey = secretAccessKey ?? throw new global::System.ArgumentNullException(nameof(secretAccessKey));
            this.SessionToken = sessionToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AwsPollySpeakProviderCredentials" /> class.
        /// </summary>
        public AwsPollySpeakProviderCredentials()
        {
        }

    }
}