
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// AWS credentials type (STS short-lived or IAM long-lived)
    /// </summary>
    public sealed partial class AwsBedrockThinkProviderCredentials
    {
        /// <summary>
        /// AWS credentials type (STS short-lived or IAM long-lived)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AwsBedrockThinkProviderCredentialsTypeJsonConverter))]
        public global::Deepgram.Realtime.AwsBedrockThinkProviderCredentialsType? Type { get; set; }

        /// <summary>
        /// AWS region
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// AWS access key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_key_id")]
        public string? AccessKeyId { get; set; }

        /// <summary>
        /// AWS secret access key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_access_key")]
        public string? SecretAccessKey { get; set; }

        /// <summary>
        /// AWS session token (required for STS only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_token")]
        public string? SessionToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AwsBedrockThinkProviderCredentials" /> class.
        /// </summary>
        /// <param name="type">
        /// AWS credentials type (STS short-lived or IAM long-lived)
        /// </param>
        /// <param name="region">
        /// AWS region
        /// </param>
        /// <param name="accessKeyId">
        /// AWS access key
        /// </param>
        /// <param name="secretAccessKey">
        /// AWS secret access key
        /// </param>
        /// <param name="sessionToken">
        /// AWS session token (required for STS only)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AwsBedrockThinkProviderCredentials(
            global::Deepgram.Realtime.AwsBedrockThinkProviderCredentialsType? type,
            string? region,
            string? accessKeyId,
            string? secretAccessKey,
            string? sessionToken)
        {
            this.Type = type;
            this.Region = region;
            this.AccessKeyId = accessKeyId;
            this.SecretAccessKey = secretAccessKey;
            this.SessionToken = sessionToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AwsBedrockThinkProviderCredentials" /> class.
        /// </summary>
        public AwsBedrockThinkProviderCredentials()
        {
        }
    }
}