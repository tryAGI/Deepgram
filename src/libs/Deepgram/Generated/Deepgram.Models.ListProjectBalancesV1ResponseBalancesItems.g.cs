
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListProjectBalancesV1ResponseBalancesItems
    {
        /// <summary>
        /// The unique identifier of the balance
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance_id")]
        public string? BalanceId { get; set; }

        /// <summary>
        /// The amount of the balance<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// The units of the balance, such as "USD"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("units")]
        public string? Units { get; set; }

        /// <summary>
        /// Description or reference of the purchase
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchase_order_id")]
        public string? PurchaseOrderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectBalancesV1ResponseBalancesItems" /> class.
        /// </summary>
        /// <param name="balanceId">
        /// The unique identifier of the balance
        /// </param>
        /// <param name="amount">
        /// The amount of the balance<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="units">
        /// The units of the balance, such as "USD"
        /// </param>
        /// <param name="purchaseOrderId">
        /// Description or reference of the purchase
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectBalancesV1ResponseBalancesItems(
            string? balanceId,
            double? amount,
            string? units,
            string? purchaseOrderId)
        {
            this.BalanceId = balanceId;
            this.Amount = amount;
            this.Units = units;
            this.PurchaseOrderId = purchaseOrderId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectBalancesV1ResponseBalancesItems" /> class.
        /// </summary>
        public ListProjectBalancesV1ResponseBalancesItems()
        {
        }
    }
}