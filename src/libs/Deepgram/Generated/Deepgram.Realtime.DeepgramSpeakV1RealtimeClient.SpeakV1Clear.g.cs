
#nullable enable

namespace Deepgram.Realtime
{
    public sealed partial class DeepgramSpeakV1RealtimeClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendSpeakV1ClearAsync(
            global::Deepgram.Realtime.SpeakV1SpeakV1Clear message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Clear), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}