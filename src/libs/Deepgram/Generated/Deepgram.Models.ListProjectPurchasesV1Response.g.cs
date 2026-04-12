
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListProjectPurchasesV1Response
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orders")]
        public global::System.Collections.Generic.IList<global::Deepgram.ListProjectPurchasesV1ResponseOrdersItems>? Orders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectPurchasesV1Response" /> class.
        /// </summary>
        /// <param name="orders"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectPurchasesV1Response(
            global::System.Collections.Generic.IList<global::Deepgram.ListProjectPurchasesV1ResponseOrdersItems>? orders)
        {
            this.Orders = orders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectPurchasesV1Response" /> class.
        /// </summary>
        public ListProjectPurchasesV1Response()
        {
        }
    }
}