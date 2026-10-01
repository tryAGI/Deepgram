
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// The think provider's response body, passed through unchanged. If the provider's response is not valid JSON, it arrives as a JSON string
    /// </summary>
    public sealed partial class AgentV1AgentV1CustomFromThinkProviderContent
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}