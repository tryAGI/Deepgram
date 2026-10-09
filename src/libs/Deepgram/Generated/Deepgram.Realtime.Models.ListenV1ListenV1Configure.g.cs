
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListenV1ListenV1Configure
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV1MessagesListenV1ConfigureTypeJsonConverter))]
        public global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ConfigureType Type { get; set; }

        /// <summary>
        /// Replaces the stream's keyterms. Compatible with all Nova-3 models, monolingual and multilingual; on other<br/>
        /// models the server returns an `Error` with code `KeytermsNotSupported`. Each array replaces the entire list,<br/>
        /// including keyterms set with the `keyterm` query parameter. Send an empty array to clear all keyterms. Omit<br/>
        /// the field, or set it to `null`, to keep the current keyterms.<br/>
        /// Each entry is a plain term or phrase with no weights or intensifiers. The 500-token keyterm limit that<br/>
        /// applies to the `keyterm` query parameter also applies to each update. An over-limit update currently stops<br/>
        /// transcription without an `Error`; after about 30 seconds, the server closes the stream with `1011`<br/>
        /// (`NET-0000`). Keep each list under the limit and check its size before sending.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyterms")]
        public global::System.Collections.Generic.IList<string>? Keyterms { get; set; }

        /// <summary>
        /// Turns formatting features on or off. Each key is a feature name and each value is a boolean, for<br/>
        /// example `{"numerals": true}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("features")]
        public global::System.Collections.Generic.Dictionary<string, bool>? Features { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ListenV1Configure" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier
        /// </param>
        /// <param name="keyterms">
        /// Replaces the stream's keyterms. Compatible with all Nova-3 models, monolingual and multilingual; on other<br/>
        /// models the server returns an `Error` with code `KeytermsNotSupported`. Each array replaces the entire list,<br/>
        /// including keyterms set with the `keyterm` query parameter. Send an empty array to clear all keyterms. Omit<br/>
        /// the field, or set it to `null`, to keep the current keyterms.<br/>
        /// Each entry is a plain term or phrase with no weights or intensifiers. The 500-token keyterm limit that<br/>
        /// applies to the `keyterm` query parameter also applies to each update. An over-limit update currently stops<br/>
        /// transcription without an `Error`; after about 30 seconds, the server closes the stream with `1011`<br/>
        /// (`NET-0000`). Keep each list under the limit and check its size before sending.
        /// </param>
        /// <param name="features">
        /// Turns formatting features on or off. Each key is a feature name and each value is a boolean, for<br/>
        /// example `{"numerals": true}`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV1ListenV1Configure(
            global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ConfigureType type,
            global::System.Collections.Generic.IList<string>? keyterms,
            global::System.Collections.Generic.Dictionary<string, bool>? features)
        {
            this.Type = type;
            this.Keyterms = keyterms;
            this.Features = features;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ListenV1Configure" /> class.
        /// </summary>
        public ListenV1ListenV1Configure()
        {
        }

    }
}