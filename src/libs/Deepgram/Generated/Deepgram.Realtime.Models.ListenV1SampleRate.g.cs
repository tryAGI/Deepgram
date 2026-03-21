
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Sample rate of submitted audio. Required (and only read) when a value is provided for encoding
    /// </summary>
    public sealed partial class ListenV1SampleRate
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}