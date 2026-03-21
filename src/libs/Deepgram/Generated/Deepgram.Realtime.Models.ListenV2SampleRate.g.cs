
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Sample rate of the audio stream in Hz. Required if sending non-containerized/raw audio. If sending containerized audio, this parameter should be omitted.
    /// </summary>
    public sealed partial class ListenV2SampleRate
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}