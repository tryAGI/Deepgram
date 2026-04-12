
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageV1ResponseResolution
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("units")]
        public string? Units { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageV1ResponseResolution" /> class.
        /// </summary>
        /// <param name="units"></param>
        /// <param name="amount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageV1ResponseResolution(
            string? units,
            double? amount)
        {
            this.Units = units;
            this.Amount = amount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageV1ResponseResolution" /> class.
        /// </summary>
        public UsageV1ResponseResolution()
        {
        }
    }
}