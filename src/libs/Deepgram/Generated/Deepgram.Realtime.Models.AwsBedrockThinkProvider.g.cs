
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AwsBedrockThinkProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AwsBedrockThinkProviderTypeJsonConverter))]
        public global::Deepgram.Realtime.AwsBedrockThinkProviderType Type { get; set; }

        /// <summary>
        /// AWS Bedrock model to use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AwsBedrockThinkProviderModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.AwsBedrockThinkProviderModel Model { get; set; }

        /// <summary>
        /// AWS Bedrock temperature (0-2)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// AWS credentials type (STS short-lived or IAM long-lived)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public global::Deepgram.Realtime.AwsBedrockThinkProviderCredentials? Credentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AwsBedrockThinkProvider" /> class.
        /// </summary>
        /// <param name="model">
        /// AWS Bedrock model to use
        /// </param>
        /// <param name="type"></param>
        /// <param name="temperature">
        /// AWS Bedrock temperature (0-2)
        /// </param>
        /// <param name="credentials">
        /// AWS credentials type (STS short-lived or IAM long-lived)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AwsBedrockThinkProvider(
            global::Deepgram.Realtime.AwsBedrockThinkProviderModel model,
            global::Deepgram.Realtime.AwsBedrockThinkProviderType type,
            double? temperature,
            global::Deepgram.Realtime.AwsBedrockThinkProviderCredentials? credentials)
        {
            this.Type = type;
            this.Model = model;
            this.Temperature = temperature;
            this.Credentials = credentials;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AwsBedrockThinkProvider" /> class.
        /// </summary>
        public AwsBedrockThinkProvider()
        {
        }
    }
}