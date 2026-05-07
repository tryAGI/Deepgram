
#nullable enable

namespace Deepgram.Realtime
{
    public sealed partial class DeepgramListenV2RealtimeClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendListenV2CloseStreamAsync(
            global::Deepgram.Realtime.ListenV2ListenV2CloseStream message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::Deepgram.Realtime.ListenV2ListenV2CloseStream), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}