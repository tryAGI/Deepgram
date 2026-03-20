
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListModelsV1Response
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stt")]
        public global::System.Collections.Generic.IList<global::Deepgram.ListModelsV1ResponseSttModels>? Stt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts")]
        public global::System.Collections.Generic.IList<global::Deepgram.ListModelsV1ResponseTtsModels>? Tts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListModelsV1Response" /> class.
        /// </summary>
        /// <param name="stt"></param>
        /// <param name="tts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListModelsV1Response(
            global::System.Collections.Generic.IList<global::Deepgram.ListModelsV1ResponseSttModels>? stt,
            global::System.Collections.Generic.IList<global::Deepgram.ListModelsV1ResponseTtsModels>? tts)
        {
            this.Stt = stt;
            this.Tts = tts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListModelsV1Response" /> class.
        /// </summary>
        public ListModelsV1Response()
        {
        }
    }
}