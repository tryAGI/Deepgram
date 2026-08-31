
#nullable enable

namespace Deepgram
{
    public sealed partial class DeepgramClient
    {

        /// <inheritdoc/>
        public void AuthorizeUsingToken(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "Http" &&
                    __authorization.Name == "Token")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::Deepgram.EndPointAuthorization
            {
                Type = "Http",
                SchemeId = "HttpToken",
                Location = "Header",
                Name = "Token",
                Value = apiKey,
            });
        }
    }
}