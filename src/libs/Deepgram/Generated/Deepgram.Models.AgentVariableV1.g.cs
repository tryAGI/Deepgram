
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// A template variable for agent configurations
    /// </summary>
    public sealed partial class AgentVariableV1
    {
        /// <summary>
        /// The unique identifier of the variable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variable_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VariableId { get; set; }

        /// <summary>
        /// The variable name, following the DG_&lt;VARIABLE_NAME&gt; format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// The value to substitute. Can be any valid JSON type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Value { get; set; }

        /// <summary>
        /// Timestamp when the variable was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the variable was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentVariableV1" /> class.
        /// </summary>
        /// <param name="variableId">
        /// The unique identifier of the variable
        /// </param>
        /// <param name="key">
        /// The variable name, following the DG_&lt;VARIABLE_NAME&gt; format
        /// </param>
        /// <param name="value">
        /// The value to substitute. Can be any valid JSON type
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the variable was created
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the variable was last updated
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentVariableV1(
            string variableId,
            string key,
            object value,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.VariableId = variableId ?? throw new global::System.ArgumentNullException(nameof(variableId));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentVariableV1" /> class.
        /// </summary>
        public AgentVariableV1()
        {
        }
    }
}