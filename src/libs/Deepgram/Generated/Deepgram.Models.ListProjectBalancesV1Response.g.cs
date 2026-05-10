
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListProjectBalancesV1Response
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("balances")]
        public global::System.Collections.Generic.IList<global::Deepgram.ListProjectBalancesV1ResponseBalancesItems>? Balances { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectBalancesV1Response" /> class.
        /// </summary>
        /// <param name="balances"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectBalancesV1Response(
            global::System.Collections.Generic.IList<global::Deepgram.ListProjectBalancesV1ResponseBalancesItems>? balances)
        {
            this.Balances = balances;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectBalancesV1Response" /> class.
        /// </summary>
        public ListProjectBalancesV1Response()
        {
        }

    }
}