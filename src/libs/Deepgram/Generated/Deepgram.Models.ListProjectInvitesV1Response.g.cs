
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListProjectInvitesV1Response
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invites")]
        public global::System.Collections.Generic.IList<global::Deepgram.ListProjectInvitesV1ResponseInvitesItems>? Invites { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectInvitesV1Response" /> class.
        /// </summary>
        /// <param name="invites"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectInvitesV1Response(
            global::System.Collections.Generic.IList<global::Deepgram.ListProjectInvitesV1ResponseInvitesItems>? invites)
        {
            this.Invites = invites;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectInvitesV1Response" /> class.
        /// </summary>
        public ListProjectInvitesV1Response()
        {
        }

    }
}