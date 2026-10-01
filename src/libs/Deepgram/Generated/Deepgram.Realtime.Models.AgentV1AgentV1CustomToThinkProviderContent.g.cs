
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Any valid JSON value (object, array, string, number, boolean, or null). Deepgram forwards it to the think provider without validation
    /// </summary>
    public sealed partial class AgentV1AgentV1CustomToThinkProviderContent
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}