
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1FunctionCallRequestEventFunctions
    {
        /// <summary>
        /// Unique identifier for the function call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the function to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// JSON string containing the function arguments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arguments { get; set; }

        /// <summary>
        /// Whether the function should be executed client-side
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_side")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ClientSide { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1FunctionCallRequestEventFunctions" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the function call
        /// </param>
        /// <param name="name">
        /// The name of the function to call
        /// </param>
        /// <param name="arguments">
        /// JSON string containing the function arguments
        /// </param>
        /// <param name="clientSide">
        /// Whether the function should be executed client-side
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1FunctionCallRequestEventFunctions(
            string id,
            string name,
            string arguments,
            bool clientSide)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.ClientSide = clientSide;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1FunctionCallRequestEventFunctions" /> class.
        /// </summary>
        public AgentV1FunctionCallRequestEventFunctions()
        {
        }
    }
}