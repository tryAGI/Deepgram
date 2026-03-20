
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListModelsV1ResponseTtsModelsMetadata
    {
        /// <summary>
        /// Example: American
        /// </summary>
        /// <example>American</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent")]
        public string? Accent { get; set; }

        /// <summary>
        /// Example: Adult
        /// </summary>
        /// <example>Adult</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("age")]
        public string? Age { get; set; }

        /// <summary>
        /// Example: #C58DFF
        /// </summary>
        /// <example>#C58DFF</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// Example: https://static.deepgram.com/examples/avatars/zeus.jpg
        /// </summary>
        /// <example>https://static.deepgram.com/examples/avatars/zeus.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Example: https://static.deepgram.com/examples/Aura-2-zeus.wav
        /// </summary>
        /// <example>https://static.deepgram.com/examples/Aura-2-zeus.wav</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample")]
        public string? Sample { get; set; }

        /// <summary>
        /// Example: [masculine, deep, trustworthy, smooth]
        /// </summary>
        /// <example>[masculine, deep, trustworthy, smooth]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Example: [IVR]
        /// </summary>
        /// <example>[IVR]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_cases")]
        public global::System.Collections.Generic.IList<string>? UseCases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListModelsV1ResponseTtsModelsMetadata" /> class.
        /// </summary>
        /// <param name="accent">
        /// Example: American
        /// </param>
        /// <param name="age">
        /// Example: Adult
        /// </param>
        /// <param name="color">
        /// Example: #C58DFF
        /// </param>
        /// <param name="image">
        /// Example: https://static.deepgram.com/examples/avatars/zeus.jpg
        /// </param>
        /// <param name="sample">
        /// Example: https://static.deepgram.com/examples/Aura-2-zeus.wav
        /// </param>
        /// <param name="tags">
        /// Example: [masculine, deep, trustworthy, smooth]
        /// </param>
        /// <param name="useCases">
        /// Example: [IVR]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListModelsV1ResponseTtsModelsMetadata(
            string? accent,
            string? age,
            string? color,
            string? image,
            string? sample,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<string>? useCases)
        {
            this.Accent = accent;
            this.Age = age;
            this.Color = color;
            this.Image = image;
            this.Sample = sample;
            this.Tags = tags;
            this.UseCases = useCases;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListModelsV1ResponseTtsModelsMetadata" /> class.
        /// </summary>
        public ListModelsV1ResponseTtsModelsMetadata()
        {
        }
    }
}