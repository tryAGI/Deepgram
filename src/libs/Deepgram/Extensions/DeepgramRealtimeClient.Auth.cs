#nullable enable

namespace Deepgram.Realtime;

public partial class DeepgramListenV1RealtimeClient
{
    private System.Net.WebSockets.ClientWebSocket? _webSocket;

    partial void Initialized(System.Net.WebSockets.ClientWebSocket client)
    {
        _webSocket = client;
    }

    /// <summary>
    /// Sets the Deepgram API key for WebSocket authentication.
    /// Deepgram uses "Token" scheme instead of "Bearer".
    /// </summary>
    /// <param name="apiKey">The Deepgram API key.</param>
    public void AuthorizeUsingToken(string apiKey)
    {
        ArgumentNullException.ThrowIfNull(apiKey);

        _webSocket?.Options.SetRequestHeader("Authorization", $"Token {apiKey}");
    }
}

public partial class DeepgramListenV2RealtimeClient
{
    private System.Net.WebSockets.ClientWebSocket? _webSocket;

    partial void Initialized(System.Net.WebSockets.ClientWebSocket client)
    {
        _webSocket = client;
    }

    /// <summary>
    /// Sets the Deepgram API key for WebSocket authentication.
    /// Deepgram uses "Token" scheme instead of "Bearer".
    /// </summary>
    /// <param name="apiKey">The Deepgram API key.</param>
    public void AuthorizeUsingToken(string apiKey)
    {
        ArgumentNullException.ThrowIfNull(apiKey);

        _webSocket?.Options.SetRequestHeader("Authorization", $"Token {apiKey}");
    }
}

public partial class DeepgramSpeakV1RealtimeClient
{
    private System.Net.WebSockets.ClientWebSocket? _webSocket;

    partial void Initialized(System.Net.WebSockets.ClientWebSocket client)
    {
        _webSocket = client;
    }

    /// <summary>
    /// Sets the Deepgram API key for WebSocket authentication.
    /// Deepgram uses "Token" scheme instead of "Bearer".
    /// </summary>
    /// <param name="apiKey">The Deepgram API key.</param>
    public void AuthorizeUsingToken(string apiKey)
    {
        ArgumentNullException.ThrowIfNull(apiKey);

        _webSocket?.Options.SetRequestHeader("Authorization", $"Token {apiKey}");
    }
}

public partial class DeepgramAgentV1RealtimeClient
{
    private System.Net.WebSockets.ClientWebSocket? _webSocket;

    partial void Initialized(System.Net.WebSockets.ClientWebSocket client)
    {
        _webSocket = client;
    }

    /// <summary>
    /// Sets the Deepgram API key for WebSocket authentication.
    /// Deepgram uses "Token" scheme instead of "Bearer".
    /// </summary>
    /// <param name="apiKey">The Deepgram API key.</param>
    public void AuthorizeUsingToken(string apiKey)
    {
        ArgumentNullException.ThrowIfNull(apiKey);

        _webSocket?.Options.SetRequestHeader("Authorization", $"Token {apiKey}");
    }
}
