
#nullable enable

namespace Deepgram.Realtime
{
    public sealed partial class DeepgramRealtimeClient
    {
        /// <summary>
        /// Close the WebSocket stream gracefully.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendCloseStreamAsync(
            global::Deepgram.Realtime.CloseStreamPayload message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::Deepgram.Realtime.CloseStreamPayload), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}