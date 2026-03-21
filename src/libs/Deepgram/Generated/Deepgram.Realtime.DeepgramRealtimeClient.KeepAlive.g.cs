
#nullable enable

namespace Deepgram.Realtime
{
    public sealed partial class DeepgramRealtimeClient
    {
        /// <summary>
        /// Keep the WebSocket connection alive.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendKeepAliveAsync(
            global::Deepgram.Realtime.KeepAlivePayload message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::Deepgram.Realtime.KeepAlivePayload), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}