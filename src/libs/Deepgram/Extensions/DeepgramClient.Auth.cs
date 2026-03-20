#nullable enable

namespace Deepgram;

public partial class DeepgramClient
{
    // Deepgram uses "Token" scheme instead of "Bearer" for API key auth.
    // The generated code sends "Authorization: Bearer <key>" but Deepgram
    // expects "Authorization: Token <key>".
    partial void Authorized(System.Net.Http.HttpClient client)
    {
        for (int i = 0; i < Authorizations.Count; i++)
        {
            var auth = Authorizations[i];
            if (auth is { Type: "Http", Name: "Bearer" })
            {
                Authorizations[i] = new EndPointAuthorization
                {
                    Type = auth.Type,
                    Location = auth.Location,
                    Name = "Token",
                    Value = auth.Value,
                };
            }
        }
    }
}
