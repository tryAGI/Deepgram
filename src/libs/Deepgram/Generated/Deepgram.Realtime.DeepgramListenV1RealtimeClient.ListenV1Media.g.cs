
#nullable enable

namespace Deepgram.Realtime
{
    public sealed partial class DeepgramListenV1RealtimeClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendListenV1MediaAsync(
            byte[] message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            await SendAsync(
                new global::System.ArraySegment<byte>(message),
                global::System.Net.WebSockets.WebSocketMessageType.Binary,
                endOfMessage: true,
                cancellationToken).ConfigureAwait(false);
        }
    }
}