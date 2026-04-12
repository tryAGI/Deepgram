
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BillingBreakdownV1ResponseResolution
    {
        /// <summary>
        /// Time unit for the resolution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("units")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Units { get; set; }

        /// <summary>
        /// Amount of units
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Amount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingBreakdownV1ResponseResolution" /> class.
        /// </summary>
        /// <param name="units">
        /// Time unit for the resolution
        /// </param>
        /// <param name="amount">
        /// Amount of units
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingBreakdownV1ResponseResolution(
            string units,
            double amount)
        {
            this.Units = units ?? throw new global::System.ArgumentNullException(nameof(units));
            this.Amount = amount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingBreakdownV1ResponseResolution" /> class.
        /// </summary>
        public BillingBreakdownV1ResponseResolution()
        {
        }
    }
}