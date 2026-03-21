
#nullable enable

namespace Deepgram.Realtime
{
    public sealed partial class DeepgramRealtimeClient
    {
        /// <summary>
        /// Flush the transcription buffer and receive any remaining results.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendFinalizeAsync(
            global::Deepgram.Realtime.FinalizePayload message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::Deepgram.Realtime.FinalizePayload), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}