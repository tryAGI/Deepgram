
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetModelV1ResponseOneOf1Metadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent")]
        public string? Accent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("age")]
        public string? Age { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample")]
        public string? Sample { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_cases")]
        public global::System.Collections.Generic.IList<string>? UseCases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelV1ResponseOneOf1Metadata" /> class.
        /// </summary>
        /// <param name="accent"></param>
        /// <param name="age"></param>
        /// <param name="color"></param>
        /// <param name="image"></param>
        /// <param name="sample"></param>
        /// <param name="tags"></param>
        /// <param name="useCases"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetModelV1ResponseOneOf1Metadata(
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
        /// Initializes a new instance of the <see cref="GetModelV1ResponseOneOf1Metadata" /> class.
        /// </summary>
        public GetModelV1ResponseOneOf1Metadata()
        {
        }

    }
}