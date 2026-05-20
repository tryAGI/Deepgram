
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListProjectPurchasesV1ResponseOrdersItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public global::System.Guid? OrderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration")]
        public global::System.DateTime? Expiration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("units")]
        public string? Units { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order_type")]
        public string? OrderType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectPurchasesV1ResponseOrdersItems" /> class.
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="expiration"></param>
        /// <param name="created"></param>
        /// <param name="amount"></param>
        /// <param name="units"></param>
        /// <param name="orderType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectPurchasesV1ResponseOrdersItems(
            global::System.Guid? orderId,
            global::System.DateTime? expiration,
            global::System.DateTime? created,
            double? amount,
            string? units,
            string? orderType)
        {
            this.OrderId = orderId;
            this.Expiration = expiration;
            this.Created = created;
            this.Amount = amount;
            this.Units = units;
            this.OrderType = orderType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectPurchasesV1ResponseOrdersItems" /> class.
        /// </summary>
        public ListProjectPurchasesV1ResponseOrdersItems()
        {
        }

    }
}