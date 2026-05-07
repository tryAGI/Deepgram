
#nullable enable

namespace Deepgram.Realtime
{
    public sealed partial class DeepgramAgentV1RealtimeClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendAgentV1InjectAgentMessageAsync(
            global::Deepgram.Realtime.AgentV1AgentV1InjectAgentMessage message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::Deepgram.Realtime.AgentV1AgentV1InjectAgentMessage), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}