
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Request body for creating an agent variable
    /// </summary>
    public sealed partial class CreateAgentVariableV1Request
    {
        /// <summary>
        /// The variable name, following the DG_&lt;VARIABLE_NAME&gt; format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// The value to substitute. Can be any valid JSON type (string, number, boolean, object, or array)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Value { get; set; }

        /// <summary>
        /// API version. Defaults to 1<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_version")]
        public int? ApiVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentVariableV1Request" /> class.
        /// </summary>
        /// <param name="key">
        /// The variable name, following the DG_&lt;VARIABLE_NAME&gt; format
        /// </param>
        /// <param name="value">
        /// The value to substitute. Can be any valid JSON type (string, number, boolean, object, or array)
        /// </param>
        /// <param name="apiVersion">
        /// API version. Defaults to 1<br/>
        /// Default Value: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentVariableV1Request(
            string key,
            object value,
            int? apiVersion)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.ApiVersion = apiVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentVariableV1Request" /> class.
        /// </summary>
        public CreateAgentVariableV1Request()
        {
        }

    }
}