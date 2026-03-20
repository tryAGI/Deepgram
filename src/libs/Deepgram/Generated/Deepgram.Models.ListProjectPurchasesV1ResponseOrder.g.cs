
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListProjectPurchasesV1ResponseOrder
    {
        /// <summary>
        /// Example: 025e19ba-b6d9-4a04-9f99-4fe715aca5f1
        /// </summary>
        /// <example>025e19ba-b6d9-4a04-9f99-4fe715aca5f1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public global::System.Guid? OrderId { get; set; }

        /// <summary>
        /// Example: 2026-03-04T00:00:00Z
        /// </summary>
        /// <example>2026-03-04T00:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration")]
        public global::System.DateTime? Expiration { get; set; }

        /// <summary>
        /// Example: 2023-02-21T21:13:40.014373Z
        /// </summary>
        /// <example>2023-02-21T21:13:40.014373Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// Example: 150
        /// </summary>
        /// <example>150</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public float? Amount { get; set; }

        /// <summary>
        /// Example: usd
        /// </summary>
        /// <example>usd</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("units")]
        public string? Units { get; set; }

        /// <summary>
        /// Example: promotional
        /// </summary>
        /// <example>promotional</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("order_type")]
        public string? OrderType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectPurchasesV1ResponseOrder" /> class.
        /// </summary>
        /// <param name="orderId">
        /// Example: 025e19ba-b6d9-4a04-9f99-4fe715aca5f1
        /// </param>
        /// <param name="expiration">
        /// Example: 2026-03-04T00:00:00Z
        /// </param>
        /// <param name="created">
        /// Example: 2023-02-21T21:13:40.014373Z
        /// </param>
        /// <param name="amount">
        /// Example: 150
        /// </param>
        /// <param name="units">
        /// Example: usd
        /// </param>
        /// <param name="orderType">
        /// Example: promotional
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectPurchasesV1ResponseOrder(
            global::System.Guid? orderId,
            global::System.DateTime? expiration,
            global::System.DateTime? created,
            float? amount,
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
        /// Initializes a new instance of the <see cref="ListProjectPurchasesV1ResponseOrder" /> class.
        /// </summary>
        public ListProjectPurchasesV1ResponseOrder()
        {
        }
    }
}