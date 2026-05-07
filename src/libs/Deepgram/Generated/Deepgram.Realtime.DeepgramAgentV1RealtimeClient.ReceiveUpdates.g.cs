
#nullable enable

namespace Deepgram.Realtime
{
    public sealed partial class DeepgramAgentV1RealtimeClient
    {
        /// <summary>
        /// Receives updates from the WebSocket connection as an async enumerable.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token.</param>
        /// <returns>An async enumerable of server events.</returns>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Deepgram.Realtime.AgentV1ServerEvent> ReceiveUpdatesAsync(
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            if (!IsConnected)
            {
                await ConnectAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
            }

            var buffer = new byte[1024 * 1024]; // 1MB buffer size
            var arraySegment = new global::System.ArraySegment<byte>(buffer);

            while (_clientWebSocket.State == global::System.Net.WebSockets.WebSocketState.Open)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    yield break;
                }

                using var __messageBuffer = new global::System.IO.MemoryStream();
                var __receivedTextMessage = false;

                while (true)
                {
                    global::System.Net.WebSockets.WebSocketReceiveResult result;

                    try
                    {
                        result = await _clientWebSocket.ReceiveAsync(arraySegment, cancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.WebSockets.WebSocketException exception)
                    {
                        RaiseException(exception);
                        var rethrow = false;
                        OnReceiveException(exception, ref rethrow);
                        if (await TryReconnectAsync(exception, cancellationToken).ConfigureAwait(false))
                        {
                            continue;
                        }

                        if (rethrow)
                        {
                            throw;
                        }

                        yield break;
                    }
                    catch (global::System.OperationCanceledException exception)
                    {
                        if (!cancellationToken.IsCancellationRequested)
                        {
                            RaiseException(exception);
                        }

                        var rethrow = false;
                        OnReceiveException(exception, ref rethrow);
                        if (rethrow)
                        {
                            throw;
                        }

                        yield break;
                    }

                    if (result.MessageType == global::System.Net.WebSockets.WebSocketMessageType.Close)
                    {
                        RaiseClosed(result.CloseStatus, result.CloseStatusDescription);
                        await _clientWebSocket.CloseAsync(
                            closeStatus: global::System.Net.WebSockets.WebSocketCloseStatus.NormalClosure,
                            statusDescription: "Closing",
                            cancellationToken: cancellationToken).ConfigureAwait(false);
                        yield break;
                    }

                    if (result.MessageType == global::System.Net.WebSockets.WebSocketMessageType.Text)
                    {
                        __receivedTextMessage = true;

                        if (result.Count > 0)
                        {
                            __messageBuffer.Write(buffer, 0, result.Count);
                        }
                    }

                    if (result.EndOfMessage)
                    {
                        break;
                    }
                }

                if (!__receivedTextMessage)
                {
                    continue;
                }

                string json = global::System.Text.Encoding.UTF8.GetString(__messageBuffer.ToArray());
                    global::Deepgram.Realtime.AgentV1ServerEvent @event;
                    try
                    {
                        @event = (global::Deepgram.Realtime.AgentV1ServerEvent)global::System.Text.Json.JsonSerializer.Deserialize(json, typeof(global::Deepgram.Realtime.AgentV1ServerEvent), JsonSerializerContext)!;
                    }
                    catch (global::System.Exception exception) when (
                        exception is global::System.Text.Json.JsonException ||
                        exception is global::System.NotSupportedException ||
                        exception is global::System.InvalidOperationException)
                    {
                        var rethrow = false;
                        OnReceiveException(exception, ref rethrow);
                        DispatchUnknownMessage(json);
                        if (rethrow)
                        {
                            throw;
                        }

                        continue;
                    }

                    DispatchReceivedMessage(@event, json);
                    yield return @event;
            }
        }


        private static global::System.Text.Json.JsonElement? TryParseMessageJson(
            string rawText)
        {
            try
            {
                using var document = global::System.Text.Json.JsonDocument.Parse(rawText);
                return document.RootElement.Clone();
            }
            catch (global::System.Text.Json.JsonException)
            {
                return null;
            }
        }

        private void DispatchUnknownMessage(
            string rawText)
        {
            UnknownMessage?.Invoke(
                this,
                new AutoSDKWebSocketUnknownMessageEventArgs(
                    rawText,
                    TryParseMessageJson(rawText)));
        }

        private void DispatchReceivedMessage(
            global::Deepgram.Realtime.AgentV1ServerEvent @event,
            string rawText)
        {
            var json = TryParseMessageJson(rawText);
            MessageReceived?.Invoke(
                this,
                new AutoSDKWebSocketMessageEventArgs<global::Deepgram.Realtime.AgentV1ServerEvent>(
                    @event,
                    rawText,
                    json));

            if (@event.AgentV1ReceiveFunctionCallResponse is { } __AgentV1ReceiveFunctionCallResponseReceived)
            {
                AgentV1ReceiveFunctionCallResponseReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse>(
                        __AgentV1ReceiveFunctionCallResponseReceived,
                        rawText,
                        json));
            }
            if (@event.AgentV1PromptUpdated is { } __AgentV1PromptUpdatedReceived)
            {
                AgentV1PromptUpdatedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated>(
                        __AgentV1PromptUpdatedReceived,
                        rawText,
                        json));
            }
            if (@event.AgentV1SpeakUpdated is { } __AgentV1SpeakUpdatedReceived)
            {
                AgentV1SpeakUpdatedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated>(
                        __AgentV1SpeakUpdatedReceived,
                        rawText,
                        json));
            }
            if (@event.AgentV1ThinkUpdated is { } __AgentV1ThinkUpdatedReceived)
            {
                AgentV1ThinkUpdatedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated>(
                        __AgentV1ThinkUpdatedReceived,
                        rawText,
                        json));
            }
            if (@event.AgentV1InjectionRefused is { } __AgentV1InjectionRefusedReceived)
            {
                AgentV1InjectionRefusedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused>(
                        __AgentV1InjectionRefusedReceived,
                        rawText,
                        json));
            }
            if (@event.AgentV1Welcome is { } __AgentV1WelcomeReceived)
            {
                AgentV1WelcomeReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Deepgram.Realtime.AgentV1AgentV1Welcome>(
                        __AgentV1WelcomeReceived,
                        rawText,
                        json));
            }
            if (@event.AgentV1SettingsApplied is { } __AgentV1SettingsAppliedReceived)
            {
                AgentV1SettingsAppliedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied>(
                        __AgentV1SettingsAppliedReceived,
                        rawText,
                        json));
            }
            if (@event.AgentV1ConversationText is { } __AgentV1ConversationTextReceived)
            {
                AgentV1ConversationTextReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Deepgram.Realtime.AgentV1AgentV1ConversationText>(
                        __AgentV1ConversationTextReceived,
                        rawText,
                        json));
            }
            if (@event.AgentV1UserStartedSpeaking is { } __AgentV1UserStartedSpeakingReceived)
            {
                AgentV1UserStartedSpeakingReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking>(
                        __AgentV1UserStartedSpeakingReceived,
                        rawText,
                        json));
            }
            if (@event.AgentV1AgentThinking is { } __AgentV1AgentThinkingReceived)
            {
                AgentV1AgentThinkingReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Deepgram.Realtime.AgentV1AgentV1AgentThinking>(
                        __AgentV1AgentThinkingReceived,
                        rawText,
                        json));
            }
            if (@event.AgentV1FunctionCallRequest is { } __AgentV1FunctionCallRequestReceived)
            {
                AgentV1FunctionCallRequestReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest>(
                        __AgentV1FunctionCallRequestReceived,
                        rawText,
                        json));
            }
            if (@event.AgentV1AgentStartedSpeaking is { } __AgentV1AgentStartedSpeakingReceived)
            {
                AgentV1AgentStartedSpeakingReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking>(
                        __AgentV1AgentStartedSpeakingReceived,
                        rawText,
                        json));
            }
            if (@event.AgentV1AgentAudioDone is { } __AgentV1AgentAudioDoneReceived)
            {
                AgentV1AgentAudioDoneReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone>(
                        __AgentV1AgentAudioDoneReceived,
                        rawText,
                        json));
            }
            if (@event.AgentV1Error is { } __AgentV1ErrorReceived)
            {
                AgentV1ErrorReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Deepgram.Realtime.AgentV1AgentV1Error>(
                        __AgentV1ErrorReceived,
                        rawText,
                        json));
            }
            if (@event.AgentV1Warning is { } __AgentV1WarningReceived)
            {
                AgentV1WarningReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Deepgram.Realtime.AgentV1AgentV1Warning>(
                        __AgentV1WarningReceived,
                        rawText,
                        json));
            }
            if (@event.AgentV1History is { } __AgentV1HistoryReceived)
            {
                AgentV1HistoryReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Deepgram.Realtime.AgentV1AgentV1History>(
                        __AgentV1HistoryReceived,
                        rawText,
                        json));
            }
            if (@event.AgentV1Audio is { } __AgentV1AudioReceived)
            {
                AgentV1AudioReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<byte[]>(
                        __AgentV1AudioReceived,
                        rawText,
                        json));
            }
        }
    }
}