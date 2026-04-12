
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Request body for updating an agent variable
    /// </summary>
    public sealed partial class UpdateAgentVariableV1Request
    {
        /// <summary>
        /// The new value to substitute
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentVariableV1Request" /> class.
        /// </summary>
        /// <param name="value">
        /// The new value to substitute
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAgentVariableV1Request(
            object value)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentVariableV1Request" /> class.
        /// </summary>
        public UpdateAgentVariableV1Request()
        {
        }
    }
}