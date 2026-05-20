
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThinkSettingsV1FunctionsItems
    {
        /// <summary>
        /// Function name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Function description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Function parameters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::Deepgram.Realtime.ThinkSettingsV1FunctionsItemsParameters? Parameters { get; set; }

        /// <summary>
        /// The Function endpoint to call. if not passed, function is called client-side
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        public global::Deepgram.Realtime.ThinkSettingsV1FunctionsItemsEndpoint? Endpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkSettingsV1FunctionsItems" /> class.
        /// </summary>
        /// <param name="name">
        /// Function name
        /// </param>
        /// <param name="description">
        /// Function description
        /// </param>
        /// <param name="parameters">
        /// Function parameters
        /// </param>
        /// <param name="endpoint">
        /// The Function endpoint to call. if not passed, function is called client-side
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThinkSettingsV1FunctionsItems(
            string? name,
            string? description,
            global::Deepgram.Realtime.ThinkSettingsV1FunctionsItemsParameters? parameters,
            global::Deepgram.Realtime.ThinkSettingsV1FunctionsItemsEndpoint? endpoint)
        {
            this.Name = name;
            this.Description = description;
            this.Parameters = parameters;
            this.Endpoint = endpoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkSettingsV1FunctionsItems" /> class.
        /// </summary>
        public ThinkSettingsV1FunctionsItems()
        {
        }

    }
}