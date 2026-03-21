
#nullable enable

namespace Deepgram.Realtime
{
    public sealed partial class DeepgramListenV2RealtimeClient
    {
        /// <summary>
        /// Close the ListenV2 WebSocket stream.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendCloseStreamAsync(
            global::Deepgram.Realtime.V2CloseStreamPayload message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::Deepgram.Realtime.V2CloseStreamPayload), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}