
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChannelsListenV1MessagesListenV1ResultsMetadataModelInfo
    {
        /// <summary>
        /// The name of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The version of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// The arch of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsListenV1MessagesListenV1ResultsMetadataModelInfo" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the model
        /// </param>
        /// <param name="version">
        /// The version of the model
        /// </param>
        /// <param name="arch">
        /// The arch of the model
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelsListenV1MessagesListenV1ResultsMetadataModelInfo(
            string name,
            string version,
            string arch)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Arch = arch ?? throw new global::System.ArgumentNullException(nameof(arch));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsListenV1MessagesListenV1ResultsMetadataModelInfo" /> class.
        /// </summary>
        public ChannelsListenV1MessagesListenV1ResultsMetadataModelInfo()
        {
        }
    }
}