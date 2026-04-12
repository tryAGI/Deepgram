
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1AgentV1InjectionRefused
    {
        /// <summary>
        /// Message type identifier for injection refused
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1InjectionRefusedTypeJsonConverter))]
        public global::Deepgram.Realtime.AgentV1AgentV1InjectionRefusedType Type { get; set; }

        /// <summary>
        /// Details about why the injection was refused
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1InjectionRefused" /> class.
        /// </summary>
        /// <param name="message">
        /// Details about why the injection was refused
        /// </param>
        /// <param name="type">
        /// Message type identifier for injection refused
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1AgentV1InjectionRefused(
            string message,
            global::Deepgram.Realtime.AgentV1AgentV1InjectionRefusedType type)
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1InjectionRefused" /> class.
        /// </summary>
        public AgentV1AgentV1InjectionRefused()
        {
        }
    }
}